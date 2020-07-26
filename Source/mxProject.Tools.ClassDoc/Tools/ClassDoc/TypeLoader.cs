using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Reflection;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Loads type information.
    /// </summary>
    public static class TypeLoader
    {

        /// <summary>
        /// Loads the types defined in the specified assembly.
        /// </summary>
        /// <param name="dllPath">The assembly file path.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        /// <param name="nameSpace">The namespace to load.</param>
        /// <returns>The type information.</returns>
        public static IReadOnlyList<TypeWithComment> LoadTypes(string dllPath, ClassDocContext context, string? nameSpace = null)
        {
            return EnumerateTypes(dllPath, context, nameSpace).ToArray();
        }

        /// <summary>
        /// Loads the types defined in the specified assemblies.
        /// </summary>
        /// <param name="dllPaths">The assembly file path.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        /// <param name="nameSpace">The namespace to load.</param>
        /// <returns>The type information.</returns>
        public static IReadOnlyList<TypeWithComment> LoadTypes(IEnumerable<string> dllPaths, ClassDocContext context, string? nameSpace = null)
        {
            List<TypeWithComment> types = new List<TypeWithComment>();

            foreach (var dllPath in dllPaths)
            {
                foreach (var type in EnumerateTypes(dllPath, context, nameSpace))
                {
                    types.Add(type);
                }
            }

            return types.AsReadOnly();
        }

        /// <summary>
        /// Loads the types defined in the specified assembly.
        /// </summary>
        /// <param name="dllPath">The assembly file path.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        /// <param name="nameSpace">The namespace to load.</param>
        /// <returns>The type information.</returns>
        private static IEnumerable<TypeWithComment> EnumerateTypes(string dllPath, ClassDocContext context, string? nameSpace = null)
        {

            var xmlPath = Path.Combine(Directory.GetParent(dllPath).FullName, Path.GetFileNameWithoutExtension(dllPath) + ".xml");

            IEnumerable<XmlComment> comments = new XmlComment[0];

            if (File.Exists(xmlPath))
            {
                comments = XmlCommentReader.ReadXmlComments(XDocument.Parse(File.ReadAllText(xmlPath)), context, nameSpace);
            }

            var commentsLookup = comments.ToLookup(x => x.TypeName);

            // List<TypeWithComment> typeComments = new List<TypeWithComment>();

            Func<Type, bool> typeFilter;

            if (!string.IsNullOrEmpty(nameSpace))
            {
                typeFilter = type =>
                {
                    if (!type.Namespace.StartsWith(nameSpace)) { return false; }
                    if (context.TypeFilter != null && !context.TypeFilter(type)) { return false; }
                    return true;
                };
            }
            else
            {
                typeFilter = context.TypeFilter;
            }

            foreach (var type in EnumerateTypes(Assembly.LoadFrom(dllPath), typeFilter))
            {
                var info = new TypeWithComment(type, commentsLookup, context);

                // typeComments.Add(info);

                context.StoreTypeInfo(info);

                yield return info;
            }

            // return typeComments.AsReadOnly();

        }

        /// <summary>
        /// Enumerates the types defined in the specified assembly.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        /// <param name="filter">The method to determine if a type should be enumerated.</param>
        /// <returns>The enumerator.</returns>
        public static IEnumerable<Type> EnumerateTypes(Assembly assembly, Func<Type, bool> filter)
        {
            static IEnumerable<Type> getTypeAndNestedTypes(Type type)
            {
                yield return type;

                foreach (var t in type.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
                {
                    foreach (var t1 in getTypeAndNestedTypes(t))
                    {
                        yield return t1;
                    }
                }
            }

            HashSet<Type> founds = new HashSet<Type>();

            foreach (var type in assembly.GetTypes())
            {
                foreach (var t in getTypeAndNestedTypes(type))
                {
                    if ((filter != null) && !filter(t)) { continue; }
                    if (founds.Contains(t)) { continue; }

                    yield return t;

                    founds.Add(t);
                }
            }

        }

        /// <summary>
        /// Gets the type with the specified name.
        /// </summary>
        /// <param name="typeName">The type name.</param>
        /// <param name="type">The type found.</param>
        /// <returns>Return true if got. Otherwise, false.</returns>
        internal static bool TryGetType(string typeName, out Type? type)
        {

            var t = Type.GetType(typeName);

            if (t != null)
            {
                type = t;
                return true;
            }

            if (t == null)
            {
                foreach (var asm in AppDomain.CurrentDomain.GetAssemblies())
                {
                    t = asm.GetType(typeName);

                    if (t != null)
                    {
                        type = t;
                        return true;
                    }
                }
            }

            type = null;
            return false;

        }

    }

}

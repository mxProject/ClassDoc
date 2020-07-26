using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Reflection;
using Cysharp.Text;
using System.Runtime.CompilerServices;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="Type"/>.
    /// </summary>
    public static class TypeExtenstions
    {

        /// <summary>
        /// Gets a value indicating whether the current System.Type represents a delegate.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool IsDelegate(this Type type)
        {
            return type.IsSubclassOf(typeof(Delegate));
        }

        /// <summary>
        /// Gets a value indicating whether the type is a class, exclude interfaces and delegates.
        /// </summary>
        public static bool IsClassExcludeDelegateAndInterface(this Type type)
        {
            return type.IsClass && !type.IsDelegate() && !type.IsInterface;
        }

        #region name

        /// <summary>
        /// Format it to a human-readable name, like "SampleClass&lt;T&gt;".
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isFullName">A value whether to get the full type name with namespace.</param>
        /// <returns></returns>
        public static string FormatToReadableTypeName(this Type type, bool isFullName)
        {
            return FormatToReadableTypeNameCore(type, isFullName, false);
        }

        /// <summary>
        /// Format it to a human-readable name, like "SampleClass&lt;T&gt;".
        /// </summary>
        /// <param name="type"></param>
        /// <param name="isFullName">A value whether to get the full type name with namespace.</param>
        /// <param name="inProsessingNesting">A value whether it is processing for a nested type.</param>
        /// <returns></returns>
        private static string FormatToReadableTypeNameCore(Type type, bool isFullName, bool inProsessingNesting)
        {
            if (type.HasElementType)
            {
                return ZString.Concat(FormatToReadableTypeNameCore(type.GetElementType(), isFullName, inProsessingNesting), type.IsArray ? "[]" : "", type.IsByRef ? "" : "", type.IsPointer ? "" : "");
            }

            if (type.IsGenericParameter) { return type.Name; }

            if (!isFullName)
            {
                if (type == typeof(void)) { return "void"; }
                if (type == typeof(string)) { return "string"; }
                if (type == typeof(char)) { return "char"; }
                if (type == typeof(bool)) { return "bool"; }
                if (type == typeof(byte)) { return "byte"; }
                if (type == typeof(short)) { return "short"; }
                if (type == typeof(int)) { return "int"; }
                if (type == typeof(long)) { return "long"; }
                if (type == typeof(float)) { return "float"; }
                if (type == typeof(double)) { return "double"; }
                if (type == typeof(decimal)) { return "decimal"; }
                if (type == typeof(sbyte)) { return "sbyte"; }
                if (type == typeof(ushort)) { return "ushort"; }
                if (type == typeof(uint)) { return "uint"; }
                if (type == typeof(ulong)) { return "ulong"; }
                if (type == typeof(object)) { return "object"; }
            }

            if (type.IsNested && !inProsessingNesting)
            {
                if (isFullName)
                {
                    return ZString.Concat(FormatToReadableTypeNameCore(type.DeclaringType, true, false), ".", FormatToReadableTypeNameCore(type, false, true));
                }
                else
                {
                    return ZString.Concat(FormatToReadableTypeNameCore(type.DeclaringType, false, false), ".", FormatToReadableTypeNameCore(type, false, true));
                }
            }

            if (!type.IsGenericType)
            {
                return isFullName ? type.FullName : type.Name;
            }

            var definition = type.GetGenericTypeDefinition();

            if (!isFullName)
            {
                if (definition == typeof(Nullable<>))
                {
                    return ZString.Concat(FormatToReadableTypeNameCore(type.GetGenericArguments()[0], isFullName, inProsessingNesting), "?");
                }
                else if (definition == typeof(ValueTuple<,>)
                    || definition == typeof(ValueTuple<,,>)
                    || definition == typeof(ValueTuple<,,,>)
                    || definition == typeof(ValueTuple<,,,,>)
                    || definition == typeof(ValueTuple<,,,,,>)
                    || definition == typeof(ValueTuple<,,,,,,>)
                    || definition == typeof(ValueTuple<,,,,,,,>)
                    )
                {
                    string valueTypeToString(Type type)
                    {
                        var arguments = type.GetGenericArguments();
                        var sb = ZString.CreateStringBuilder();

                        sb.Append("(");

                        for (int i = 0; i < arguments.Length; ++i)
                        {
                            if (i > 0) { sb.Append(", "); }
                            sb.Append(FormatToReadableTypeNameCore(arguments[i], isFullName, inProsessingNesting));
                        }

                        sb.Append(")");

                        return sb.ToString();
                    };

                    return valueTypeToString(type);
                }
            }

            var genericArgs = type.GetGenericArguments().AsSpan();

            if (type.IsNested && type.DeclaringType.IsGenericType)
            {
                genericArgs = genericArgs.Slice(type.DeclaringType.GetGenericArguments().Length);
            }

            var sb = ZString.CreateStringBuilder();

            if (isFullName)
            {
                sb.Append(type.Namespace);
                sb.Append(".");
            }

            if (genericArgs.Length > 0)
            {
                sb.Append(type.Name.Substring(0, type.Name.IndexOf("`")));
            }
            else
            {
                sb.Append(type.Name);
            }

            if (genericArgs.Length > 0)
            {

                sb.Append("<");

                for (int i = 0; i < genericArgs.Length; ++i)
                {
                    if (i > 0) { sb.Append(", "); }
                    sb.Append(genericArgs[i].FormatToReadableTypeName(false));
                }

                sb.Append(">");

            }


            return sb.ToString();

        }

        /// <summary>
        /// Format it to a type name in XML comment signature, like "SampleNamespace.SampleClass`1".
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        internal static string FormatToXmlCommentTypeName(this Type type)
        {
            if (type.IsGenericType)
            {
                return FormatToXmlCommentTypeNameCore(type, type.GetGenericArguments(), Type.EmptyTypes, true, false);
            }
            else
            {
                return FormatToXmlCommentTypeNameCore(type, Type.EmptyTypes, Type.EmptyTypes, true, false);
            }
        }

        /// <summary>
        /// Format it to a parameter type name in XML comment signature, like "System.Generic.Collection.IDictionary{`0,``0}".
        /// </summary>
        /// <param name="type"></param>
        /// <param name="typeGenericParameters">The generic arguments of the type in which the specified method is declared.</param>
        /// <param name="methodGenericParameters">The generic arguments of the specified method.</param>
        /// <returns></returns>
        internal static string FormatToXmlCommentParameterTypeName(this Type type, Type[] typeGenericParameters, Type[] methodGenericParameters)
        {
            return FormatToXmlCommentTypeNameCore(type, typeGenericParameters, methodGenericParameters, true, false);
        }

        /// <summary>
        /// Format it to a parameter type name in XML comment signature, like "System.Generic.Collection.IDictionary{`0,``0}".
        /// </summary>
        /// <param name="type"></param>
        /// <param name="typeGenericParameters">The generic arguments of the type in which the specified method is declared.</param>
        /// <param name="methodGenericParameters">The generic arguments of the specified method.</param>
        /// <param name="isFullName">A value whether to get the full type name with namespace.</param>
        /// <param name="inProsessingNesting">A value whether it is processing for a nested type.</param>
        /// <returns></returns>
        private static string FormatToXmlCommentTypeNameCore(Type type, Type[] typeGenericParameters, Type[] methodGenericParameters, bool isFullName, bool inProsessingNesting)
        {
            if (type.HasElementType)
            {
                return ZString.Concat(FormatToXmlCommentTypeNameCore(type.GetElementType(), typeGenericParameters, methodGenericParameters, isFullName, inProsessingNesting), type.IsArray ? "[]" : "", type.IsByRef ? "@" : "", type.IsPointer ? "*" : "");
            }

            if (type.IsGenericParameter)
            {
                int index = Array.IndexOf(typeGenericParameters, type);
                if (index >= 0) { return $"`{index}"; }

                index = Array.IndexOf(methodGenericParameters, type);
                if (index >= 0) { return $"``{index}"; }

                return type.Name;
            }

            if (type.IsNested && !inProsessingNesting)
            {
                if (isFullName)
                {
                    return ZString.Concat(FormatToXmlCommentTypeNameCore(type.DeclaringType, typeGenericParameters, methodGenericParameters, true, false), ".", FormatToXmlCommentTypeNameCore(type, typeGenericParameters, methodGenericParameters, false, true));
                }
                else
                {
                    return ZString.Concat(FormatToXmlCommentTypeNameCore(type.DeclaringType, typeGenericParameters, methodGenericParameters, false, false), ".", FormatToXmlCommentTypeNameCore(type, typeGenericParameters, methodGenericParameters, false, true));
                }
            }

            if (!type.IsGenericType)
            {
                return isFullName ? type.FullName : type.Name;
            }

            var genericArgs = type.GetGenericArguments().AsSpan();

            if (type.IsNested && type.DeclaringType.IsGenericType)
            {
                genericArgs = genericArgs.Slice(type.DeclaringType.GetGenericArguments().Length);
            }

            var sb = ZString.CreateStringBuilder();

            if (isFullName)
            {
                sb.Append(type.Namespace);
                sb.Append(".");
            }

            if (genericArgs.Length > 0)
            {
                sb.Append(type.Name.Substring(0, type.Name.IndexOf("`")));
            }
            else
            {
                sb.Append(type.Name);
            }

            if (genericArgs.Length > 0)
            {
                if (type.IsConstructedGenericType)
                {
                    sb.Append("{");

                    for (int i = 0; i < genericArgs.Length; ++i)
                    {
                        if (i > 0) { sb.Append(","); }
                        sb.Append(genericArgs[i].FormatToXmlCommentParameterTypeName(typeGenericParameters, methodGenericParameters));
                    }

                    sb.Append("}");
                }
                else
                {
                    sb.Append("`");
                    sb.Append(genericArgs.Length);
                }

            }


            return sb.ToString();

        }

        #endregion

        #region Inheritance tree

        /// <summary>
        /// Go up the inheritance tree and enumerate the base types.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<Type> EnumerateBaseTypes(this Type type)
        {
            Type? baseType = type?.BaseType;

            while (baseType != null)
            {
                yield return baseType;

                baseType = baseType.BaseType;
            }
        }

        #endregion

        #region filter

        /// <summary>
        /// Gets whether output to document is recommended.
        /// </summary>
        /// <param name="method"></param>
        /// <returns>Returns true if recommended. Otherwise, false.</returns>
        /// <remarks>
        /// <para>
        /// If <see cref="MethodBase.IsSpecialName"/> property returns true, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="IsAccesibleFromOutsideAssembly"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsBrowsable"/> method returns false, then this method will return false.
        /// </para>
        /// </remarks>
        public static bool IsRecommendOutputToDocument(this Type method)
        {
            if (method == null) { return false; }

            if (method.IsSpecialName) { return false; }

            if (!IsAccesibleFromOutsideAssembly(method)) { return false; }
            if (!method.IsBrowsable()) { return false; }

            return true;
        }

        /// <summary>
        /// Gets whether it can be accessed from outside the assembly.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Returns true if public or nested public. Otherwise, false.</returns>
        public static bool IsAccesibleFromOutsideAssembly(Type type)
        {
            if (type == null) { return false; }

            if (type.IsNested)
            {
                return (type.IsNestedPublic && IsAccesibleFromOutsideAssembly(type.DeclaringType));
            }
            else
            {
                return (type.IsPublic);
            }
        }

        /// <summary>
        /// Gets whether the type namespace matches the specified namespace.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="regexPattern">The regular expression pattern.</param>
        /// <returns>Return true if match, otherwize false.</returns>
        public static bool IsMatchNamespace(this Type type, string regexPattern)
        {
            return IsMatchNamespace(type, new Regex(regexPattern));
        }

        /// <summary>
        /// Gets whether the type namespace matches the specified namespace.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="regex">The regular expression.</param>
        /// <returns>Return true if match, otherwize false.</returns>
        public static bool IsMatchNamespace(this Type type, Regex regex)
        {
            return regex.IsMatch(type.Namespace != null ? type.Namespace : string.Empty);
        }

        #endregion

    }

}

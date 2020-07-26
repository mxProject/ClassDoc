using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Namespace information.
    /// </summary>
    public sealed class NamespaceInfo
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="nameSpace">The namespace.</param>
        /// <param name="types">The types defined in the namespace.</param>
        public NamespaceInfo(string nameSpace, IEnumerable<TypeWithComment> types)
        {
            Namespace = nameSpace;
            Classes = CreateTypeList(nameSpace, types, type => type.Info.IsClassExcludeDelegateAndInterface());
            ValueTypes = CreateTypeList(nameSpace, types, type => !type.Info.IsEnum && type.Info.IsValueType);
            Enums = CreateTypeList(nameSpace, types, type => type.Info.IsEnum);
            Delegates = CreateTypeList(nameSpace, types, type => type.Info.IsDelegate());
            Interfaces = CreateTypeList(nameSpace, types, type => type.Info.IsInterface);
        }

        /// <summary>
        /// Creates a type information list that matches the specified conditions.
        /// </summary>
        /// <param name="nameSpace">The namespace.</param>
        /// <param name="types">The types defined in the namespace.</param>
        /// <param name="filter">The method to determine if a specified type satisfies the condition.</param>
        /// <returns></returns>
        private IReadOnlyList<TypeWithComment> CreateTypeList(string nameSpace, IEnumerable<TypeWithComment> types, Func<TypeWithComment, bool> filter)
        {
            List<TypeWithComment> list = new List<TypeWithComment>();

            if (types != null)
            {
                foreach (var type in types)
                {
                    if (type == null || !filter(type)) { continue; }
                    if (type.Info == null || !type.Info.IsMatchNamespace(nameSpace)) { continue; }

                    list.Add(type);
                }
            }

            list.Sort((a, b) => a.FullName.CompareTo(b.FullName));

            return list.AsReadOnly();
        }

        /// <summary>
        /// Gets the namespace.
        /// </summary>
        public string Namespace { get; }

        /// <summary>
        /// Gets the class list.
        /// </summary>
        public IReadOnlyList<TypeWithComment> Classes { get; }

        /// <summary>
        /// Gets the valueType list.
        /// </summary>
        public IReadOnlyList<TypeWithComment> ValueTypes { get; }

        /// <summary>
        /// Gets the enum list.
        /// </summary>
        public IReadOnlyList<TypeWithComment> Enums { get; }

        /// <summary>
        /// Gets the delegate list.
        /// </summary>
        public IReadOnlyList<TypeWithComment> Delegates { get; }

        /// <summary>
        /// Gets the interface list.
        /// </summary>
        public IReadOnlyList<TypeWithComment> Interfaces { get; }
    }

}

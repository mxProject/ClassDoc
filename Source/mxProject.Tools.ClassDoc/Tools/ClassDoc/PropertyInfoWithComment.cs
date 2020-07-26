using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Property information and its XML comment.
    /// </summary>
    public sealed class PropertyInfoWithComment : MemberInfoWithComment<PropertyInfo>
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="prop">The property information.</param>
        /// <param name="comment">The XML comment.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public PropertyInfoWithComment(PropertyInfo prop, XmlComment comment, ClassDocContext context) : base(prop, comment, context)
        {
            Parameters = CreateParameterList(Info.GetIndexParameters());
        }

        /// <summary>
        /// Gets a value indicating whether the property is static.
        /// </summary>
        public bool IsStatic
        {
            get { return Info.IsStatic(); }
        }

        #region scope

        /// <summary>
        /// Gets the scope. If the getter and the setter have different scopes, the wider scope is returned.
        /// </summary>
        protected override MemberScope GetMemberScope()
        {
            var setter = SetterScope;
            var getter = GetterScope;

            if (setter == getter)
            {
                return setter;
            }
            else if (setter < getter)
            {
                return getter;
            }
            else
            {
                return setter;
            }
        }

        /// <summary>
        /// Gets the scope of the set accessor.
        /// </summary>
        public MemberScope SetterScope
        {
            get { return Info.GetSettterScope(); }
        }

        /// <summary>
        /// Gets the scope of the get accessor.
        /// </summary>
        public MemberScope GetterScope
        {
            get { return Info.GetGettterScope(); }
        }

        #endregion

        /// <summary>
        /// Get the type information of the property.
        /// </summary>
        public TypeWithComment PropertyTypeInfo
        {
            get { return Context.GetTypeInfo(Info.PropertyType);  }
        }

        /// <summary>
        /// Gets the declaretion statement.
        /// </summary>
        public string Declaretion
        {
            get { return Info.FormatToDeclaretion(); }
        }

        #region parameters

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        public IReadOnlyList<ParameterInfoWithComment> Parameters { get; }

        #endregion

        #region XML comment

        /// <summary>
        /// Gets the inherited XML comment.
        /// </summary>
        /// <returns></returns>
        protected override XmlComment? GetInheritComment()
        {
            MethodInfo[] methods = Info.GetAccessors(true);

            if (methods == null || methods.Length == 0) { return null; }

            var baseMethod = methods[0].GetBaseDefinition();

            TypeWithComment baseType = Context.GetTypeInfo(baseMethod.DeclaringType);

            foreach (var m in baseType.Methods)
            {
                if (m.Info == baseMethod)
                {
                    return m.Comment;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the summary. Add the content about inheritance.
        /// </summary>
        /// <returns></returns>
        public string GetSummaryWithInherits()
        {
            return GetSummaryWithInherits(InheritComment);
        }

        #endregion

    }

}

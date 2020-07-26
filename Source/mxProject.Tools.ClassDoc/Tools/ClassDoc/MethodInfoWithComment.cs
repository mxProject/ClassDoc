using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel;
using Cysharp.Text;
using System.Data;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Method information and its XML comment.
    /// </summary>
    public sealed class MethodInfoWithComment : MemberInfoWithComment<MethodInfo>
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="method">The method information.</param>
        /// <param name="comment">The XML comment.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public MethodInfoWithComment(MethodInfo method, XmlComment comment, ClassDocContext context): base(method, comment, context)
        {
            Parameters = CreateParameterList(method.GetParameters());
            GenericParameterTypes = CreateGenericParameters().AsReadOnly();
        }

        /// <summary>
        /// Gets a value indicating whether the method is static.
        /// </summary>
        public bool IsStatic
        {
            get { return Info.IsStatic; }
        }

        /// <summary>
        /// Gets whether the method is an extension method.
        /// </summary>
        public bool IsExtensionMethod
        {
            get { return Info.IsExtensionMethod(); }
        }

        /// <summary>
        /// Gets the scope.
        /// </summary>
        /// <returns>The scope.</returns>
        protected override MemberScope GetMemberScope()
        {
            return Info.GetScope();
        }

        /// <summary>
        /// Gets the declaretion statement.
        /// </summary>
        public string Declaretion
        {
            get { return Info.FormatToDeclaretion(); }
        }

        #region return value

        /// <summary>
        /// Gets whether the method returns a return value.
        /// </summary>
        public bool HasReturnValue
        {
            get
            {
                if (Info.ReturnType == typeof(void)) { return false; }
                if (Info.ReturnType == typeof(Task)) { return false; }
                if (Info.ReturnType == typeof(ValueTask)) { return false; }

                return true;
            }
        }

        /// <summary>
        /// Get the type information of the return value.
        /// </summary>
        public TypeWithComment ReturnTypeInfo
        {
            get { return Context.GetTypeInfo(Info.ReturnType); }
        }

        #endregion

        #region parameters

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        public IReadOnlyList<ParameterInfoWithComment> Parameters { get; }

        #endregion

        #region type parameters

        /// <summary>
        /// Gets a value indicating whether this method represents a generic method definition.
        /// </summary>
        public bool IsGenericMethodDefinition
        {
            get { return Info.IsGenericMethodDefinition; }
        }

        /// <summary>
        /// Gets the generic parameters.
        /// </summary>
        public IReadOnlyList<TypeParameterWithComment> GenericParameterTypes { get; }

        /// <summary>
        /// Create a generic parameter list.
        /// </summary>
        /// <returns></returns>
        private List<TypeParameterWithComment> CreateGenericParameters()
        {
            List<TypeParameterWithComment> list = new List<TypeParameterWithComment>();

            foreach (var type in Info.GetGenericArguments())
            {
                Comment.TypeParameters.TryGetValue(type.Name, out ParameterComment parameterComment);

                list.Add(new TypeParameterWithComment(type, () => parameterComment, Context));
            }

            return list;
        }

        #endregion

        #region XML comment

        /// <summary>
        /// Gets the inherited XML comment.
        /// </summary>
        /// <returns></returns>
        protected override XmlComment? GetInheritComment()
        {
            var baseMethod = Info.GetBaseDefinition();

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

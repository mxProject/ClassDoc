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
    /// Field information and its XML comment.
    /// </summary>
    public sealed class FieldInfoWithComment : MemberInfoWithComment<FieldInfo>
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="field">The field information.</param>
        /// <param name="comment">The XML comment.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public FieldInfoWithComment(FieldInfo field, XmlComment comment, ClassDocContext context) : base(field, comment, context)
        {
        }

        /// <summary>
        /// Gets a value indicating whether the field is static.
        /// </summary>
        public bool IsStatic
        {
            get { return Info.IsStatic; }
        }

        #region scope

        /// <inheritdoc/>
        protected override MemberScope GetMemberScope()
        {
            return Info.GetScope();
        }

        #endregion

        /// <summary>
        /// Get the type information of the field.
        /// </summary>
        public TypeWithComment FieldTypeInfo
        {
            get { return Context.GetTypeInfo(Info.FieldType);  }
        }

        #region XML comment

        /// <inheritdoc/>
        /// <remarks>
        /// <para>
        /// This class always returns null.
        /// </para>
        /// </remarks>
        protected override XmlComment? GetInheritComment()
        {
            return null;
        }

        ///// <summary>
        ///// Gets the summary. Add the content about inheritance.
        ///// </summary>
        ///// <returns></returns>
        //public string GetSummaryWithInherits()
        //{
        //    return GetSummaryWithInherits(InheritComment);
        //}

        #endregion

    }

}

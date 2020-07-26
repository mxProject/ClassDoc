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
    /// Constructor information and its XML comment.
    /// </summary>
    public sealed class ConstructorInfoWithComment : MemberInfoWithComment<ConstructorInfo>
    {

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="ctor">The constructor information.</param>
        /// <param name="comment">The XML comment.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public ConstructorInfoWithComment(ConstructorInfo ctor, XmlComment comment, ClassDocContext context): base(ctor, comment, context)
        {
            Parameters = CreateParameterList(ctor.GetParameters());
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

        #region parameters.

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        public IReadOnlyList<ParameterInfoWithComment> Parameters { get; }

        #endregion

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

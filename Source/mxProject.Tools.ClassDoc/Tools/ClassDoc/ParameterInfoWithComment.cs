using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// parameter information and its XML comment.
    /// </summary>
    public class ParameterInfoWithComment
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="parameter">The parameter information.</param>
        /// <param name="commentGetter">The method to get comment of parameter.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public ParameterInfoWithComment(ParameterInfo parameter, Func<ParameterComment> commentGetter, ClassDocContext context)
        {
            m_Context = context;

            Info = parameter;

            m_CommentGetter = commentGetter;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        private readonly ClassDocContext m_Context;

        /// <summary>
        /// Gets the parameter information.
        /// </summary>
        public ParameterInfo Info { get; }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name
        {
            get { return Info.Name; }
        }

        /// <summary>
        /// Get the type information of the parameter.
        /// </summary>
        public TypeWithComment ParameterTypeInfo
        {
            get { return m_Context.GetTypeInfo(Info.ParameterType); }
        }

        /// <summary>
        /// Gets the direction of the parameter.
        /// </summary>
        public string IO
        {
            get
            {
                if (Info.IsOut) { return "out"; }
                if (Info.IsIn) { return "in"; }
                return "";
            }
        }

        /// <summary>
        /// Get the description.
        /// </summary>
        /// <param name="delimiter">The delimiter when multiple descriptions are listed.</param>
        /// <returns></returns>
        public string GetDescription(string delimiter = " ")
        {
            return Comment.GetDescription(delimiter);
        }

        #region comment

        /// <summary>
        /// Gets the XML comment.
        /// </summary>
        public ParameterComment Comment
        {
            get
            {
                return m_CommentGetter() ?? ParameterComment.Empty;
            }
        }

        /// <summary>
        /// The method to get comment of parameter.
        /// </summary>
        private readonly Func<ParameterComment> m_CommentGetter;

        #endregion

    }
}

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
    /// Member information and its XML comment.
    /// </summary>
    public abstract class MemberInfoWithComment<TInfo> where TInfo : MemberInfo
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="member">The member information.</param>
        /// <param name="comment">The XML comment.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        protected MemberInfoWithComment(TInfo member, XmlComment comment, ClassDocContext context)
        {
            Context = context;
            
            Info = member;
            Comment = comment ?? XmlComment.Empty;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        internal ClassDocContext Context { get; }

        /// <summary>
        /// Gets the member information.
        /// </summary>
        public TInfo Info { get; }

        /// <summary>
        /// Gets the member name.
        /// </summary>
        public string Name => Info.Name;

        /// <summary>
        /// Gets whether it is obsolete.
        /// </summary>
        public bool IsObsolete => Info.IsObsolete();

        #region scope

        /// <summary>
        /// Gets the scope.
        /// </summary>
        public MemberScope Scope
        {
            get { return GetMemberScope(); }
        }

        /// <summary>
        /// Gets the scope.
        /// </summary>
        /// <returns>The scope.</returns>
        protected abstract MemberScope GetMemberScope();

        #endregion

        #region type

        /// <summary>
        /// Gets information of the type for which this member is declared.
        /// </summary>
        /// <returns></returns>
        public TypeWithComment GetDeclaringTypeInfo()
        {
            return Context.GetTypeInfo(Info.DeclaringType);
        }

        #endregion

        #region parameters

        /// <summary>
        /// Creates a list that stores information for the specified parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        protected List<ParameterInfoWithComment> CreateParameterList(ParameterInfo[] parameters)
        {

            List<ParameterInfoWithComment> list = new List<ParameterInfoWithComment>(parameters.Length);

            for (int i = 0; i < parameters.Length; ++i)
            {
                ParameterComment comment;

                if (parameters[i].Name == null)
                {
                    comment = ParameterComment.Empty;
                }
                else
                {
                    Comment.Parameters.TryGetValue(parameters[i].Name, out comment);
                }

                Func<ParameterComment> commentGetter;

                if (Comment.IsInherit)
                {
                    string name = parameters[i].Name;

                    commentGetter = () =>
                    {
                        if (comment != null) { return comment; }

                        if (InheritComment != null && InheritComment.Parameters.TryGetValue(name, out comment) && comment != null) { return comment; }

                        return ParameterComment.Empty;
                    };
                }
                else
                {
                    commentGetter = () => comment;
                }

                list.Add(new ParameterInfoWithComment(parameters[i], commentGetter, Context));
            }

            return list;

        }

        #endregion

        #region XML comment

        /// <summary>
        /// Gets the XML comment.
        /// </summary>
        public XmlComment Comment { get; }

        /// <summary>
        /// Gets the inherited XML comment.
        /// </summary>
        public XmlComment? InheritComment
        {
            get
            {
                if (!Comment.IsInherit) { return null; }
                m_InheritComment = GetInheritComment();
                return m_InheritComment;
            }
        }
        private XmlComment? m_InheritComment;

        /// <summary>
        /// Gets the inherited XML comment.
        /// </summary>
        /// <returns></returns>
        protected abstract XmlComment? GetInheritComment();

        /// <summary>
        /// Gets the summary. Add the content about inheritance.
        /// </summary>
        /// <param name="inheritComment">The inherited XML comment.</param>
        /// <returns></returns>
        protected string GetSummaryWithInherits(XmlComment? inheritComment)
        {
            if (Comment.IsInherit)
            {
                string? inheritSummary = inheritComment?.Summary;

                if (inheritSummary == null)
                {
                    return $"( {MessageResource.NotFoundInheritComment} )";
                }
                else
                {
                    return inheritSummary + ZString.Format(MessageResource.InheritFrom, $@"<see cref=""T:{Info.DeclaringType.FormatToXmlCommentTypeName()}"" />");
                }
            }
            else if (Info.DeclaringType != Info.ReflectedType)
            {
                return ZString.Format(MessageResource.InheritFrom, $@"<see cref=""T:{Info.DeclaringType.FormatToXmlCommentTypeName()}"" />");
            }
            else
            {
                return Comment.Summary;
            }
        }

        #endregion

    }

}

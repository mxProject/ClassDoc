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
    /// Event information and its XML comment.
    /// </summary>
    public sealed class EventInfoWithComment : MemberInfoWithComment<EventInfo>
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="evt">The field information.</param>
        /// <param name="comment">The XML comment.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public EventInfoWithComment(EventInfo evt, XmlComment comment, ClassDocContext context) : base(evt, comment, context)
        {
        }

        #region scope

        /// <summary>
        /// Gets the scope. If AddMethod and RemoveMethod and RaizeMethod have different scopes, the wider scope is returned.
        /// </summary>
        /// <returns>The scope.</returns>
        protected override MemberScope GetMemberScope()
        {
            var add = GetAddMethodScope();
            var remove = GetRemoveMethodScope();
            var raise = GetRaiseMethodScope();

            if (add == remove && add == raise)
            {
                return add;
            }

            if (add > remove)
            {
                if (add > raise)
                {
                    return add;
                }
                else
                {
                    return raise;
                }
            }
            else
            {
                if (remove > raise)
                {
                    return remove;
                }
                else
                {
                    return raise;
                }
            }
        }

        /// <summary>
        /// Gets the scope of AddMethod.
        /// </summary>
        /// <returns>The scope.</returns>
        public MemberScope GetAddMethodScope()
        {
            return Info.GetAddMethodScope();
        }

        /// <summary>
        /// Gets the scope of RemoveMethod.
        /// </summary>
        /// <returns>The scope.</returns>
        public MemberScope GetRemoveMethodScope()
        {
            return Info.GetRemoveMethodScope();
        }

        /// <summary>
        /// Gets the scope of RaizeMethod.
        /// </summary>
        /// <returns>The scope.</returns>
        public MemberScope GetRaiseMethodScope()
        {
            return Info.GetRaiseMethodScope();
        }

        #endregion

        /// <summary>
        /// Gets a value indicating whether the event is static.
        /// </summary>
        public bool IsStatic
        {
            get { return Info.IsStatic(); }
        }

        /// <summary>
        /// Get the type information of the event handler.
        /// </summary>
        public TypeWithComment EventHandlerTypeInfo
        {
            get { return Context.GetTypeInfo(Info.EventHandlerType);  }
        }

        #region XML comment

        /// <inheritdoc/>
        protected override XmlComment? GetInheritComment()
        {
            MethodInfo? method = Info.GetAddMethod(true) ?? Info.GetRemoveMethod(true) ?? Info.GetRaiseMethod(true);

            if (method == null) { return null; }

            var baseMethod = method.GetBaseDefinition();

            TypeWithComment baseType = Context.GetTypeInfo(baseMethod.DeclaringType);

            foreach (var e in baseType.Events)
            {
                if (e.Name == this.Name)
                {
                    return e.Comment;
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

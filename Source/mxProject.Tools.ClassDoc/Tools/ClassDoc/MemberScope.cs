using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Member scope.
    /// </summary>
    public enum MemberScope
    {

        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// private.
        /// </summary>
        Private,

        /// <summary>
        /// protected.
        /// </summary>
        Protected,

        /// <summary>
        /// protected internal.
        /// </summary>
        ProtectedInternal,

        /// <summary>
        /// internal.
        /// </summary>
        Internal,

        /// <summary>
        /// public.
        /// </summary>
        Public,

    }

    /// <summary>
    /// 
    /// </summary>
    internal static class MemberScopeExtensions
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal static string Format(this MemberScope value)
        {
            switch (value)
            {
                case MemberScope.Public: return "public";
                case MemberScope.Internal: return "internal";
                case MemberScope.ProtectedInternal: return "protected internal";
                case MemberScope.Protected: return "protected";
                case MemberScope.Private: return "private";
                default:
                    return "";
            }
        }
    }

}

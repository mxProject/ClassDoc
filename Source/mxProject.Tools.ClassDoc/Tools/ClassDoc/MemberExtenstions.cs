using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.ComponentModel;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="MemberInfo"/>.
    /// </summary>
    public static class MemberExtenstions
    {

        /// <summary>
        /// Gets whether it is obsolete.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>Returns true if obsoleted. Otherwise, false.</returns>
        public static bool IsObsolete(this MemberInfo member)
        {
            if (member == null) { return false; }

            return (member.GetCustomAttribute<ObsoleteAttribute>() != null);
        }

        /// <summary>
        /// Gets whether it is browsable.
        /// </summary>
        /// <param name="member"></param>
        /// <returns>Returns true if browsable. Otherwise, false.</returns>
        public static bool IsBrowsable(this MemberInfo member)
        {
            if (member == null) { return false; }

            var attr = member.GetCustomAttribute<BrowsableAttribute>();

            return (attr == null || attr.Browsable);
        }

    }

}

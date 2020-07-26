using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="GenericParameterAttributes"/>.
    /// </summary>
    public static class GenericParameterAttributesExtensions
    {

        /// <summary>
        /// Gets the expression used in the declaration.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDeclaration(this GenericParameterAttributes value)
        {
            var sb = ZString.CreateStringBuilder();

            if ((value & GenericParameterAttributes.ReferenceTypeConstraint) > 0)
            {
                if (sb.Length > 0) { sb.Append(", "); }
                sb.Append("class");
            }

            if ((value & GenericParameterAttributes.NotNullableValueTypeConstraint) > 0)
            {
                if (sb.Length > 0) { sb.Append(", "); }
                sb.Append("struct");
            }

            if ((value & GenericParameterAttributes.DefaultConstructorConstraint) > 0 && ((value & GenericParameterAttributes.NotNullableValueTypeConstraint) == 0))
            {
                if (sb.Length > 0) { sb.Append(", "); }
                sb.Append("new()");
            }

            return sb.ToString();
        }

    }

}

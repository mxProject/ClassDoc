using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Utility methods.
    /// </summary>
    internal static class ClassDocUtility
    {

        /// <summary>
        /// Enumerates generic constraints.
        /// </summary>
        /// <param name="genericArgument"></param>
        /// <returns></returns>
        internal static IEnumerable<string> EnumerateGenericConstraints(Type genericArgument)
        {
            var attr = genericArgument.GenericParameterAttributes;

            if ((attr & GenericParameterAttributes.ReferenceTypeConstraint) > 0)
            {
                yield return "class";
            }

            bool isStruct = (attr & GenericParameterAttributes.NotNullableValueTypeConstraint) > 0;

            if (isStruct)
            {
                yield return "struct";
            }

            foreach (var constraint in genericArgument.GetGenericParameterConstraints())
            {
                if (constraint == typeof(ValueType) && isStruct) { continue; }

                yield return constraint.FormatToReadableTypeName(false);
            }

            if ((attr & GenericParameterAttributes.DefaultConstructorConstraint) > 0 && !isStruct)
            {
                yield return "new()";
            }
        }

    }

}

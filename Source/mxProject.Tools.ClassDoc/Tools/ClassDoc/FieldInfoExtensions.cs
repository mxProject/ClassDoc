using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="FieldInfo"/>.
    /// </summary>
    public static class FieldInfoExtensions
    {

        /// <summary>
        /// Gets the scope.
        /// </summary>
        /// <param name="field"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetScope(this FieldInfo field)
        {
            if (field.IsPublic) { return MemberScope.Public; }
            if (field.IsFamilyOrAssembly) { return MemberScope.ProtectedInternal; }
            if (field.IsAssembly) { return MemberScope.Internal; }
            if (field.IsFamily) { return MemberScope.Protected; }
            if (field.IsPrivate) { return MemberScope.Private; }

            return MemberScope.None;
        }

        #region signature

        /// <summary>
        /// Format it to a XML comment signature, like "F:SampleNamespace.SampleClass.Item".
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public static string FormatToXmlCommentSignature(this FieldInfo field)
        {

            Type type = field.DeclaringType;

            var sb = ZString.CreateStringBuilder();

            sb.Append("F:");

            if (field.DeclaringType.IsGenericType)
            {
                sb.Append(field.DeclaringType.FormatToXmlCommentParameterTypeName(field.DeclaringType.GetGenericArguments(), Type.EmptyTypes));
            }
            else
            {
                sb.Append(field.DeclaringType.FormatToXmlCommentParameterTypeName(Type.EmptyTypes, Type.EmptyTypes));
            }

            sb.Append(".");
            sb.Append(field.Name);

            return sb.ToString();
        }

        #endregion

        #region filter

        /// <summary>
        /// Gets whether output to document is recommended.
        /// </summary>
        /// <param name="field"></param>
        /// <returns>Returns true if recommended. Otherwise, false.</returns>
        /// <remarks>
        /// <para>
        /// If <see cref="FieldInfo.IsSpecialName"/> field returns true, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="IsAccesibleFromOutsideAssembly"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsBrowsable"/> method returns false, then this method will return false.
        /// </para>
        /// </remarks>
        public static bool IsRecommendOutputToDocument(this FieldInfo field)
        {
            if (field == null) { return false; }

            if (field.IsSpecialName) { return false; }

            if (!IsAccesibleFromOutsideAssembly(field)) { return false; }
            if (!field.IsBrowsable()) { return false; }

            return true;
        }

        /// <summary>
        /// Gets whether it can be accessed from outside the assembly.
        /// </summary>
        /// <param name="field"></param>
        /// <returns>Returns true if getter or setter is accessible. Otherwise, false.</returns>
        public static bool IsAccesibleFromOutsideAssembly(this FieldInfo field)
        {
            if (field == null) { return false; }

            if (field.IsPublic) { return true; }
            if (field.IsFamily) { return true; }
            if (field.IsFamilyOrAssembly) { return true; }

            return false;
        }

        #endregion

    }

}

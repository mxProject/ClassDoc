using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="EventInfo"/>.
    /// </summary>
    public static class EventInfoExtensions
    {

        /// <summary>
        /// Gets the scope of AddMethod.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetAddMethodScope(this EventInfo evt)
        {
            var method = evt.GetAddMethod(true);

            if (method == null) { return MemberScope.None; }

            return method.GetScope();
        }

        /// <summary>
        /// Gets the scope of RemoveMethod.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetRemoveMethodScope(this EventInfo evt)
        {
            var method = evt.GetRemoveMethod(true);

            if (method == null) { return MemberScope.None; }

            return method.GetScope();
        }

        /// <summary>
        /// Gets the scope of RaizeMethod.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetRaiseMethodScope(this EventInfo evt)
        {
            var method = evt.GetRaiseMethod(true);

            if (method == null) { return MemberScope.None; }

            return method.GetScope();
        }

        /// <summary>
        /// Gets a value indicating whether the event is static.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public static bool IsStatic(this EventInfo evt)
        {
            MethodInfo method;

            method = evt.GetAddMethod(true);
            if (method != null) { return method.IsStatic; }

            method = evt.GetRemoveMethod(true);
            if (method != null) { return method.IsStatic; }

            method = evt.GetRaiseMethod(true);
            if (method != null) { return method.IsStatic; }

            return false;
        }

        #region signature

        /// <summary>
        /// Format it to a XML comment signature, like "E:SampleNamespace.SampleClass.AddedItem".
        /// </summary>
        /// <param name="evt"></param>
        /// <returns></returns>
        public static string FormatToXmlCommentSignature(this EventInfo evt)
        {

            Type type = evt.DeclaringType;

            var sb = ZString.CreateStringBuilder();

            sb.Append("E:");

            if (evt.DeclaringType.IsGenericType)
            {
                sb.Append(evt.DeclaringType.FormatToXmlCommentParameterTypeName(evt.DeclaringType.GetGenericArguments(), Type.EmptyTypes));
            }
            else
            {
                sb.Append(evt.DeclaringType.FormatToXmlCommentParameterTypeName(Type.EmptyTypes, Type.EmptyTypes));
            }

            sb.Append(".");
            sb.Append(evt.Name);

            return sb.ToString();
        }

        #endregion

        #region filter

        /// <summary>
        /// Gets whether output to document is recommended.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns>Returns true if recommended. Otherwise, false.</returns>
        /// <remarks>
        /// <para>
        /// If <see cref="EventInfo.IsSpecialName"/> event returns true, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="IsAccesibleFromOutsideAssembly"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsBrowsable"/> method returns false, then this method will return false.
        /// </para>
        /// </remarks>
        public static bool IsRecommendOutputToDocument(this EventInfo evt)
        {
            if (evt == null) { return false; }

            if (evt.IsSpecialName) { return false; }

            if (!IsAccesibleFromOutsideAssembly(evt)) { return false; }
            if (!evt.IsBrowsable()) { return false; }

            return true;
        }

        /// <summary>
        /// Gets whether it can be accessed from outside the assembly.
        /// </summary>
        /// <param name="evt"></param>
        /// <returns>Returns true if getter or setter is accessible. Otherwise, false.</returns>
        public static bool IsAccesibleFromOutsideAssembly(this EventInfo evt)
        {
            if (evt == null) { return false; }

            MethodInfo[] methods = new[] { evt.GetAddMethod(true), evt.GetRemoveMethod(true), evt.GetRaiseMethod(true) };

            for (int i = 0; i < methods.Length; ++i)
            {
                if (methods[i] == null) { continue; }
                if (methods[i].IsAccesibleFromOutsideAssembly()) { return true; }
            }

            return false;
        }

        #endregion

    }

}

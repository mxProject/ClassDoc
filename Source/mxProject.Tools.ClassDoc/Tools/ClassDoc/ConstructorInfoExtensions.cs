using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="ConstructorInfo"/>.
    /// </summary>
    public static class ConstructorInfoExtensions
    {

        /// <summary>
        /// Gets the scope.
        /// </summary>
        /// <param name="method"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetScope(this ConstructorInfo method)
        {
            if (method.IsPublic) { return MemberScope.Public; }
            if (method.IsFamilyOrAssembly) { return MemberScope.ProtectedInternal; }
            if (method.IsAssembly) { return MemberScope.Internal; }
            if (method.IsFamily) { return MemberScope.Protected; }
            if (method.IsPrivate) { return MemberScope.Private; }

            return MemberScope.None;
        }

        #region signature

        /// <summary>
        /// Format it to a human-readable signature, like ".ctor(IList&lt;int&gt;)".
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string FormatToReadableSignature(this ConstructorInfo method)
        {

            var sb = ZString.CreateStringBuilder();

            sb.Append(method.Name);

            var parameters = method.GetParameters();

            if (parameters.Length > 0)
            {
                sb.Append("(");

                for (int i = 0; i < parameters.Length; ++i)
                {
                    if (i > 0) { sb.Append(", "); }

                    if (parameters[i].IsIn) { sb.Append("in "); }
                    if (parameters[i].IsOut) { sb.Append("out "); }

                    sb.Append(parameters[i].ParameterType.FormatToReadableTypeName(false));
                }

                sb.Append(")");
            }

            return sb.ToString();

        }

        /// <summary>
        /// Format it to a XML comment signature, like "M:SampleNamespace.SampleClass.#ctor(System.Collection.Generic.IList{int})".
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string FormatToXmlCommentSignature(this ConstructorInfo method)
        {

            Type type = method.DeclaringType;

            var sb = ZString.CreateStringBuilder();

            sb.Append("M:");

            sb.Append(method.DeclaringType.FullName);

            sb.Append(".#ctor");

            var parameters = method.GetParameters();

            if (parameters.Length > 0)
            {
                sb.Append("(");

                for (int i = 0; i < parameters.Length; ++i)
                {
                    if (i > 0) { sb.Append(","); }

                    sb.Append(parameters[i].ParameterType.FormatToXmlCommentParameterTypeName(
                        type.IsGenericType ? type.GetGenericArguments() : new Type[] { }
                        , method.IsGenericMethod ? method.GetGenericArguments() : new Type[] { }
                        ));
                }

                sb.Append(")");
            }

            return sb.ToString();
        }

        #endregion

        #region declaretion

        /// <summary>
        /// Foramt it to a declaretion statement.
        /// </summary>
        /// <param name="ctor"></param>
        /// <returns></returns>
        public static string FormatToDeclaretion(this ConstructorInfo ctor)
        {
            var sb = ZString.CreateStringBuilder();

            MemberScope scope = ctor.GetScope();

            sb.Append(scope.Format());

            if (ctor.IsStatic)
            {
                sb.Append(" static");
            }
            else if (ctor.IsAbstract)
            {
                sb.Append(" abstract");
            }
            else if (ctor.IsVirtual)
            {
                sb.Append(" virtual");
            }

            sb.Append(" ");

            var name = ctor.DeclaringType.Name;
            var delimiter = name.IndexOf('`');

            if (delimiter > 0)
            {
                sb.Append(name.Substring(0, delimiter));
            }
            else
            {
                sb.Append(name);
            }

            sb.Append("(");

            var parameters = ctor.GetParameters();

            if (parameters.Length > 0)
            {

                for (int i = 0; i < parameters.Length; ++i)
                {
                    sb.AppendLine();
                    sb.Append("\t");

                    if (i > 0) { sb.Append(", "); }

                    sb.Append(parameters[i].ParameterType.FormatToReadableTypeName(false));

                    sb.Append(" ");
                    sb.Append(parameters[i].Name);
                }

                sb.AppendLine();
            }

            sb.Append(")");

            return sb.ToString();

        }

        #endregion

        #region filter

        /// <summary>
        /// Gets whether output to document is recommended.
        /// </summary>
        /// <param name="ctor"></param>
        /// <returns>Returns true if recommended. Otherwise, false.</returns>
        /// <remarks>
        /// <para>
        /// If <see cref="IsAccesibleFromOutsideAssembly"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsObsolete"/> method returns true, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsBrowsable"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If the type for which the specified constructor is declared is delegate, then this method will return false.
        /// </para>
        /// </remarks>
        public static bool IsRecommendOutputToDocument(this ConstructorInfo ctor)
        {
            if (ctor == null) { return false; }

            if (!IsAccesibleFromOutsideAssembly(ctor)) { return false; }
            if (ctor.IsObsolete()) { return false; }
            if (!ctor.IsBrowsable()) { return false; }

            if (ctor.DeclaringType.IsDelegate()) { return false; }

            return true;
        }

        /// <summary>
        /// Gets whether it can be accessed from outside the assembly.
        /// </summary>
        /// <param name="ctor"></param>
        /// <returns>Returns true if public or protected. Otherwise, false.</returns>
        public static bool IsAccesibleFromOutsideAssembly(this ConstructorInfo ctor)
        {
            if (ctor == null) { return false; }

            if (ctor.IsPublic) { return true; }
            if (ctor.IsFamily) { return true; }
            if (ctor.IsFamilyOrAssembly) { return true; }

            return false;
        }

        #endregion

    }
}

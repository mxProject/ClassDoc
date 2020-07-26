using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Cysharp.Text;
using System.Threading;
using System.Runtime.CompilerServices;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="MethodInfo"/>.
    /// </summary>
    public static class MethodInfoExtensions
    {

        /// <summary>
        /// Gets the scope.
        /// </summary>
        /// <param name="method"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetScope(this MethodInfo method)
        {
            if (method.IsPublic) { return MemberScope.Public; }
            if (method.IsFamilyOrAssembly) { return MemberScope.ProtectedInternal; }
            if (method.IsAssembly) { return MemberScope.Internal; }
            if (method.IsFamily) { return MemberScope.Protected; }
            if (method.IsPrivate) { return MemberScope.Private; }

            return MemberScope.None;
        }

        /// <summary>
        /// Gets whether it is an extension method.
        /// </summary>
        /// <param name="method"></param>
        /// <returns>Return true if it is an extension method, otherwise false.</returns>
        public static bool IsExtensionMethod(this MethodInfo method)
        {
            return method.GetCustomAttribute<ExtensionAttribute>() != null;
        }

        #region signature

        /// <summary>
        /// Format it to a human-readable signature, like "AddValues&lt;T&gt;(IEnumerable&lt;T&gt;)".
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string FormatToReadableSignature(this MethodInfo method)
        {
            
            var sb = ZString.CreateStringBuilder();

            sb.Append(method.Name);

            if (method.IsGenericMethod)
            {
                var genericArgs = method.GetGenericArguments();

                if (genericArgs.Length > 0)
                {
                    sb.Append("<");

                    for (int i = 0; i < genericArgs.Length; ++i)
                    {
                        if (i > 0) { sb.Append(", "); }
                        sb.Append(genericArgs[i].FormatToReadableTypeName(false));
                    }

                    sb.Append(">");
                }

            }

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
        /// Format it to a XML comment signature, like "M:SampleNamespace.SampleClass.AddValues`1(System.Collection.Generic.IEnumerable{`0})".
        /// </summary>
        /// <param name="method"></param>
        /// <returns></returns>
        public static string FormatToXmlCommentSignature(this MethodInfo method)
        {

            Type type = method.DeclaringType;

            var sb = ZString.CreateStringBuilder();

            sb.Append("M:");

            if (method.DeclaringType.IsGenericType)
            {
                sb.Append(method.DeclaringType.FormatToXmlCommentParameterTypeName(method.DeclaringType.GetGenericArguments(), Type.EmptyTypes));
            }
            else
            {
                sb.Append(method.DeclaringType.FormatToXmlCommentParameterTypeName(Type.EmptyTypes, Type.EmptyTypes));
            }

            sb.Append(".");
            sb.Append(method.Name);

            if (method.IsGenericMethod)
            {
                sb.Append($"``{method.GetGenericArguments().Length}");
            }

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
        /// <param name="method"></param>
        /// <returns></returns>
        public static string FormatToDeclaretion(this MethodInfo method)
        {
            var genericArgs = method.IsGenericMethod ? method.GetGenericArguments() : Type.EmptyTypes;

            var sb = ZString.CreateStringBuilder();

            // modifier & scope

            MemberScope scope = method.GetScope();

            if (!method.DeclaringType.IsInterface)
            {
                sb.Append(scope.Format());

                if (method.IsStatic)
                {
                    sb.Append(" static");
                }
                else if (method.IsAbstract)
                {
                    sb.Append(" abstract");
                }
                else if (method.IsVirtual)
                {
                    sb.Append(" virtual");
                }

                sb.Append(" ");
            }

            // return value

            sb.Append(method.ReturnType.FormatToReadableTypeName(false));

            // name

            sb.Append(" ");
            sb.Append(method.Name);

            // generic arguments

            if (genericArgs.Length > 0)
            {
                sb.Append("<");

                for (int i = 0; i < genericArgs.Length; ++i)
                {
                    if (i > 0) { sb.Append(", "); }
                    sb.Append(genericArgs[i].FormatToReadableTypeName(false));
                }

                sb.Append(">");
            }

            // arguments

            var parameters = method.GetParameters();

            if (parameters.Length > 0)
            {
                sb.AppendLine();
                sb.Append("(");

                for (int i = 0; i < parameters.Length; ++i)
                {
                    sb.AppendLine();
                    sb.Append("\t");

                    if (i > 0) { sb.Append(", "); }

                    if (i == 0 && method.IsExtensionMethod())
                    {
                        sb.Append("this ");
                    }

                    if (parameters[i].IsIn) { sb.Append("in "); }
                    if (parameters[i].IsOut) { sb.Append("out "); }

                    sb.Append(parameters[i].ParameterType.FormatToReadableTypeName(false));

                    sb.Append(" ");
                    sb.Append(parameters[i].Name);

                    if (parameters[i].IsOptional)
                    {
                        if (parameters[i].DefaultValue == null)
                        {
                            sb.Append(" = null");
                        }
                        else if (parameters[i].ParameterType == typeof(string))
                        {
                            sb.AppendFormat(@" = ""{0}""", parameters[i].DefaultValue);
                        }
                        else if (parameters[i].ParameterType == typeof(char))
                        {
                            sb.AppendFormat(" = '{0}'", parameters[i].DefaultValue);
                        }
                        else 
                        {
                            sb.AppendFormat(" = {0}", parameters[i].DefaultValue);
                        }
                    }
                }

                sb.AppendLine();
                sb.Append(")");
            }
            else
            {
                sb.Append("()");
            }


            // generic constraint

            foreach (var genericArg in genericArgs)
            {
                bool foundConstraint = false;

                foreach (var constraint in ClassDocUtility.EnumerateGenericConstraints(genericArg))
                {
                    if (foundConstraint)
                    {
                        sb.Append(", ");
                    }
                    else
                    {
                        sb.AppendLine();
                        sb.AppendFormat("where {0} : ", genericArg.Name);
                        foundConstraint = true;
                    }
                    sb.Append(constraint);
                }
            }

            return sb.ToString();

        }

        #endregion

        #region filter

        /// <summary>
        /// Gets whether output to document is recommended.
        /// </summary>
        /// <param name="method"></param>
        /// <returns>Returns true if recommended. Otherwise, false.</returns>
        /// <remarks>
        /// <para>
        /// If <see cref="MethodBase.IsSpecialName"/> property returns true, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="IsAccesibleFromOutsideAssembly"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsBrowsable"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If the type for which the spacified method is declared is delegate or enum, then this method will return false.
        /// </para>
        /// </remarks>
        public static bool IsRecommendOutputToDocument(this MethodInfo method)
        {
            if (method == null) { return false; }

            if (method.IsSpecialName) { return false; }

            if (!IsAccesibleFromOutsideAssembly(method)) { return false; }
            if (!method.IsBrowsable()) { return false; }

            if (method.ReflectedType.IsDelegate() || method.ReflectedType.IsEnum)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets whether it can be accessed from outside the assembly.
        /// </summary>
        /// <param name="method"></param>
        /// <returns>Returns true if public or protected. Otherwise, false.</returns>
        public static bool IsAccesibleFromOutsideAssembly(this MethodInfo method)
        {
            if (method == null) { return false; }

            if (method.IsPublic) { return true; }
            if (method.IsFamily) { return true; }
            if (method.IsFamilyOrAssembly) { return true; }

            return false;
        }

        #endregion


    }

}

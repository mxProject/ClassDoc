using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Extension methods for <see cref="PropertyInfo"/>.
    /// </summary>
    public static class PropertyInfoExtensions
    {

        /// <summary>
        /// Gets the scope of the get accessor.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetGettterScope(this PropertyInfo property)
        {
            var getter = property.GetGetMethod(true);

            if (getter == null) { return MemberScope.None; }

            return getter.GetScope();
        }

        /// <summary>
        /// Gets the scope of the set accessor.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>The scope.</returns>
        public static MemberScope GetSettterScope(this PropertyInfo property)
        {
            var setter = property.GetSetMethod(true);

            if (setter == null) { return MemberScope.None; }

            return setter.GetScope();
        }

        /// <summary>
        /// Gets a value indicating whether the property is static.
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static bool IsStatic(this PropertyInfo property)
        {
            var getter = property.GetGetMethod(true);

            if (getter != null) { return getter.IsStatic; }

            var setter = property.GetSetMethod(true);

            if (setter != null) { return setter.IsStatic; }

            return false;
        }

        #region signature

        /// <summary>
        /// Format it to a human-readable name or signature, like "Item[int]".
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string FormatToReadableSignature(this PropertyInfo property)
        {

            var parameters = property.GetIndexParameters();

            if (parameters == null || parameters.Length == 0) { return property.Name; }

            var sb = ZString.CreateStringBuilder();

            sb.Append(property.Name);

            sb.Append("[");

            for (int i = 0; i < parameters.Length; ++i)
            {
                if (i > 0) { sb.Append(", "); }
                sb.Append(parameters[i].ParameterType.FormatToReadableTypeName(false));
            }

            sb.Append("]");

            return sb.ToString();

        }

        /// <summary>
        /// Format it to a XML comment signature, like "P:SampleNamespace.SampleClass.Item(System.Int32)".
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        public static string FormatToXmlCommentSignature(this PropertyInfo property)
        {

            Type type = property.DeclaringType;

            var sb = ZString.CreateStringBuilder();

            sb.Append("P:");

            if (property.DeclaringType.IsGenericType)
            {
                sb.Append(property.DeclaringType.FormatToXmlCommentParameterTypeName(property.DeclaringType.GetGenericArguments(), Type.EmptyTypes));
            }
            else
            {
                sb.Append(property.DeclaringType.FormatToXmlCommentParameterTypeName(Type.EmptyTypes, Type.EmptyTypes));
            }

            sb.Append(".");
            sb.Append(property.Name);

            var parameters = property.GetIndexParameters();

            if (parameters.Length > 0)
            {
                sb.Append("(");

                for (int i = 0; i < parameters.Length; ++i)
                {
                    if (i > 0) { sb.Append(","); }

                    sb.Append(parameters[i].ParameterType.FormatToXmlCommentParameterTypeName(
                        type.IsGenericType ? type.GetGenericArguments() : new Type[] { }
                        , new Type[] { }
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
        /// <param name="property"></param>
        /// <returns></returns>
        public static string FormatToDeclaretion(this PropertyInfo property)
        {

            MethodInfo? getter = property.GetGetMethod(true);
            MethodInfo? setter = property.GetSetMethod(true);

            if (getter== null && setter == null) { return ""; }

            MethodInfo method = getter ?? setter;

            MemberScope getterScope = getter?.GetScope() ?? MemberScope.None;
            MemberScope setterScope = setter?.GetScope() ?? MemberScope.None;
            MemberScope wideScope = getterScope > setterScope ? getterScope : setterScope;

            var sb = ZString.CreateStringBuilder();

            if (!property.DeclaringType.IsInterface)
            {
                sb.Append(wideScope.Format());

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

            sb.Append(property.PropertyType.FormatToReadableTypeName(false));

            sb.Append(" ");
            sb.Append(property.Name);

            var parameters = property.GetIndexParameters();

            if (parameters.Length > 0)
            {
                sb.Append("[");

                for (int i = 0; i < parameters.Length; ++i)
                {
                    if (i > 0) { sb.Append(", "); }

                    sb.Append(parameters[i].ParameterType.FormatToReadableTypeName(false));

                    sb.Append(" ");
                    sb.Append(parameters[i].Name);
                }

                sb.Append("]");
            }

            sb.Append(" {");

            if (getter != null)
            {
                sb.Append(" ");

                if (getterScope != wideScope)
                {
                    sb.Append(getterScope.Format());
                    sb.Append(" ");
                }

                sb.Append("get;");
            }

            if (setter != null)
            {
                sb.Append(" ");

                if (setterScope != wideScope)
                {
                    sb.Append(setterScope.Format());
                    sb.Append(" ");
                }

                sb.Append("set;");
            }

            sb.Append(" }");

            return sb.ToString();

        }

        #endregion

        #region filter

        /// <summary>
        /// Gets whether output to document is recommended.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>Returns true if recommended. Otherwise, false.</returns>
        /// <remarks>
        /// <para>
        /// If <see cref="PropertyInfo.IsSpecialName"/> property returns true, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="IsAccesibleFromOutsideAssembly"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If <see cref="MemberExtenstions.IsBrowsable"/> method returns false, then this method will return false.
        /// </para>
        /// <para>
        /// If the type for which the spacified method is declared is delegate, then this method will return false.
        /// </para>
        /// </remarks>
        public static bool IsRecommendOutputToDocument(this PropertyInfo property)
        {
            if (property == null) { return false; }

            if (property.IsSpecialName) { return false; }

            if (!IsAccesibleFromOutsideAssembly(property)) { return false; }
            if (!property.IsBrowsable()) { return false; }

            if (property.ReflectedType.IsDelegate())
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets whether it can be accessed from outside the assembly.
        /// </summary>
        /// <param name="property"></param>
        /// <returns>Returns true if getter or setter is accessible. Otherwise, false.</returns>
        public static bool IsAccesibleFromOutsideAssembly(this PropertyInfo property)
        {
            if (property == null) { return false; }

            MethodInfo[] methods = property.GetAccessors(true);

            for (int i = 0; i < methods.Length; ++i)
            {
                if (methods[i].IsAccesibleFromOutsideAssembly()) { return true; }
            }

            return false;
        }

        #endregion

    }

}

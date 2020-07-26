using Cysharp.Text;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Comment about the exception.
    /// </summary>
    public sealed class ExceptionComment
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="exceptionTypeSignature">The exception type signature.</param>
        /// <param name="descriptions">The descriptions.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public ExceptionComment(string exceptionTypeSignature, string[] descriptions, ClassDocContext context)
        {
            Context = context;

            ExceptionTypeSignatureName = exceptionTypeSignature;
            Descriptions = descriptions;

            m_ExceptionType = null;

            if (XmlCommentSignature.TryParse(exceptionTypeSignature, out var signature))
            {
                if (TypeLoader.TryGetType(signature.TypeName, out Type? type))
                {
                    m_ExceptionType = type;
                }
            }

            ExceptionTypeSignature = signature;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        internal ClassDocContext Context { get; }

        /// <summary>
        /// Gets the exception type signature.
        /// </summary>
        public string ExceptionTypeSignatureName { get; }

        /// <summary>
        /// Gets the exception type signature.
        /// </summary>
        public XmlCommentSignature ExceptionTypeSignature { get; }

        /// <summary>
        /// Gets the exception type. Returns null if the type cannot be obtained from the comment signature.
        /// </summary>
        private readonly Type? m_ExceptionType;

        /// <summary>
        /// Gets the exception type information. Returns null if the type cannot be obtained from the comment signature.
        /// </summary>
        public TypeWithComment? ExceptionTypeInfo
        {
            get
            {
                if (m_ExceptionType == null) { return null; }
                return Context.GetTypeInfo(m_ExceptionType);
            }
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public IReadOnlyList<string> Descriptions { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <param name="delimiter">The delimiter when multiple descriptions are listed.</param>
        /// <returns>The description.</returns>
        public string GetDescriptions(string delimiter = " ")
        {
            if (Descriptions == null) { return ""; }

            if (Descriptions.Count == 1) { return Descriptions[0] ?? ""; }

            var sb = ZString.CreateStringBuilder();

            for (int i = 0; i < Descriptions.Count; ++i)
            {
                if (i > 0 && sb.Length > 0) { sb.Append(delimiter); }
                sb.Append(Descriptions[i]);
            }

            return sb.ToString();
        }

    }

}

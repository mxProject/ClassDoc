using Cysharp.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// XML comment.
    /// </summary>
    public class XmlComment
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public XmlComment(ClassDocContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        private ClassDocContext Context { get; }

        /// <summary>
        /// Empty instance.
        /// </summary>
        public static readonly XmlComment Empty = new XmlComment(ClassDocContext.Null);

        /// <summary>
        /// Gets whether it is an empty instance.
        /// </summary>
        public bool IsEmpty
        {
            get { return SignatureName == null || SignatureName == ""; }
        }

        #region signature

        /// <summary>
        /// Gets the signature.
        /// </summary>
        public string SignatureName { get; internal set; } = "";

        /// <summary>
        /// Gets the parsed signature.
        /// </summary>
        public XmlCommentSignature Signature { get; internal set; }

        /// <summary>
        /// Gets whether to inherit the comment of the inheritance source.
        /// </summary>
        public bool IsInherit { get; internal set; }

        /// <summary>
        /// Gets the kind.
        /// </summary>
        public XmlCommentKind Kind { get => Signature.Kind; }

        /// <summary>
        /// Gets the type name.
        /// </summary>
        public string TypeName { get => Signature.TypeName; }

        /// <summary>
        /// Gets the member name.
        /// </summary>
        public string? MemberName { get => Signature.MemberName; }

        /// <summary>
        /// Gets the method arguments.
        /// </summary>
        public string? MethodArguments { get => Signature.MethodArguments; }

        #endregion



        /// <summary>
        /// Gets the summary.
        /// </summary>
        public string Summary { get; internal set; } = "";

        #region remarks

        /// <summary>
        /// Gets the remarks.
        /// </summary>
        public string Remarks { get; internal set; } = "";

        /// <summary>
        /// Enumerates remarks by line.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> RemarkLines()
        {
            if (string.IsNullOrWhiteSpace(Remarks)) { yield break; }

            if (!Remarks.Contains(Environment.NewLine))
            {
                yield return Remarks;
                yield break;
            }

            foreach (var line in Remarks.Split(Environment.NewLine.ToCharArray()))
            {
                if (string.IsNullOrWhiteSpace(line)) { continue; }
                yield return line;
            }
        }

        #endregion

        #region parameters

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        public IReadOnlyDictionary<string, ParameterComment> Parameters
        {
            get { return ParametersInternal ?? EmptyParameters; }
        }

        internal Dictionary<string, ParameterComment>? ParametersInternal { get; set; }

        private static readonly Dictionary<string, ParameterComment> EmptyParameters = new Dictionary<string, ParameterComment>();

        #endregion

        #region type parameters

        /// <summary>
        /// Gets the type parameters.
        /// </summary>
        public IReadOnlyDictionary<string, ParameterComment> TypeParameters
        {
            get { return TypeParametersInternal ?? EmptyParameters; }
        }

        internal Dictionary<string, ParameterComment>? TypeParametersInternal { get; set; }

        #endregion

        /// <summary>
        /// Gets the return value.
        /// </summary>
        public string? Returns { get; internal set; }

        #region exceptions

        /// <summary>
        /// Gets the exceptions.
        /// </summary>
        public IReadOnlyList<ExceptionComment> Exceptions
        {
            get { return ExceptionsInternal ?? EmptyExceptions; }
        }

        internal IReadOnlyList<ExceptionComment>? ExceptionsInternal { get; set; }

        private static readonly IReadOnlyList<ExceptionComment> EmptyExceptions = new ExceptionComment[] { };

        #endregion

        /// <inheritdoc/>
        public override string ToString()
        {
            return SignatureName;
        }

    }

}

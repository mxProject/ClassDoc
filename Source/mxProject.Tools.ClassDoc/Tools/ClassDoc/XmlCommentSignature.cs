using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// XML comment signature.
    /// </summary>
    public readonly struct XmlCommentSignature : IEquatable<XmlCommentSignature>
    {

        /// <summary>
        /// Create a new instance/
        /// </summary>
        /// <param name="kind">The kind.</param>
        /// <param name="typeName">The type name.</param>
        /// <param name="memberName">The member name.</param>
        /// <param name="methodArguments">The method arguments.</param>
        public XmlCommentSignature(XmlCommentKind kind, string typeName, string? memberName = null, string? methodArguments = null)
        {
            Kind = kind;
            TypeName = typeName;
            MemberName = memberName;
            MethodArguments = methodArguments;
        }

        /// <summary>
        /// Gets the kind.
        /// </summary>
        public readonly XmlCommentKind Kind { get; }

        /// <summary>
        /// Gets the type name.
        /// </summary>
        public readonly string TypeName { get; }

        /// <summary>
        /// Gets the member name.
        /// </summary>
        public readonly string? MemberName { get; }

        /// <summary>
        /// Gets the method arguments.
        /// </summary>
        public readonly string? MethodArguments { get; }


        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is XmlCommentSignature signature && Equals(signature);
        }

        /// <inheritdoc/>
        public bool Equals(XmlCommentSignature other)
        {
            return Kind == other.Kind &&
                   TypeName == other.TypeName &&
                   MemberName == other.MemberName &&
                   MethodArguments == other.MethodArguments;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -84544035;
            hashCode = hashCode * -1521134295 + Kind.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TypeName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(MemberName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(MethodArguments);
            return hashCode;
        }

        /// <summary>
        /// Parses the specified signature.
        /// </summary>
        /// <param name="signatureName">signature string.</param>
        /// <param name="signature">A parsed signature.</param>
        /// <returns>Returns true if parsed. Otherwise, false.</returns>
        internal static bool TryParse(string signatureName, out XmlCommentSignature signature)
        {

            var match = Regex.Match(signatureName, @"(.):(.+)\.([^.()]+)?(\(.+\)|$)");

            if (!match.Groups[1].Success)
            {
                signature = default;
                return false;
            }

            var memberType = (XmlCommentKind)match.Groups[1].Value[0];

            if (memberType == XmlCommentKind.Unknown)
            {
                signature = default;
                return false;
            }

            string className;

            if (memberType == XmlCommentKind.Type)
            {
                className = match.Groups[2].Value + "." + match.Groups[3].Value;
            }
            else
            {
                className = match.Groups[2].Value;
            }

            var memberName = match.Groups[3].Value;

            string methodArgs;

            if ((memberType == XmlCommentKind.Method || memberType == XmlCommentKind.Property) && match.Groups.Count >= 5)
            {
                methodArgs = match.Groups[4].Value;
            }
            else
            {
                methodArgs = "";
            }

            signature = new XmlCommentSignature(memberType, className, memberName, methodArgs);
            return true;

        }

    }

}

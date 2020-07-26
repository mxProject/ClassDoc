using System;
using System.Collections.Generic;
using System.Text;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Comment about the parameter.
    /// </summary>
    public sealed class ParameterComment
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="name">The parameter name.</param>
        /// <param name="descriptions">The descriptions.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public ParameterComment(string name, string[] descriptions, ClassDocContext context)
        {
            Context = context;
            Name = name;
            Descriptions = descriptions ?? EmptyStringArray;
        }

        internal ParameterComment(string name, ClassDocContext context)
        {
            Context = context;
            Name = name;
            Descriptions = EmptyStringArray;
        }

        private static readonly string[] EmptyStringArray = new string[] { };

        /// <summary>
        /// Empty instance.
        /// </summary>
        internal static readonly ParameterComment Empty = new ParameterComment("", EmptyStringArray, ClassDocContext.Null);

        /// <summary>
        /// Gets the context.
        /// </summary>
        internal ClassDocContext Context { get; }

        /// <summary>
        /// Gets the parameter name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public IReadOnlyList<string> Descriptions { get; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        /// <param name="delimiter">The delimiter when multiple descriptions are listed.</param>
        /// <returns>The description.</returns>
        public string GetDescription(string delimiter = " ")
        {
            if (Descriptions == null) { return ""; }
            if (Descriptions.Count == 0) { return ""; }
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

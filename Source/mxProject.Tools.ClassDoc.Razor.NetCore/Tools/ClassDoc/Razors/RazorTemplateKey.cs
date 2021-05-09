using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine.Templating;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// Template key.
    /// </summary>
    public readonly struct RazorTemplateKey : ITemplateKey
    {
        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="name">The unique name.</param>
        public RazorTemplateKey(string name)
        {
            Name = name;
        }

        /// <inheritdoc/>
        public string Name { get; }

        /// <inheritdoc/>
        public ResolveType TemplateType => ResolveType.Global;

        /// <inheritdoc/>
        public ITemplateKey Context => this;

        /// <inheritdoc/>
        public string GetUniqueKeyString()
        {
            return Name;
        }
    }

}

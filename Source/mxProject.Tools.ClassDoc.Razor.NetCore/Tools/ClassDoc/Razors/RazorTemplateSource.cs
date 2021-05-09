using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using RazorEngine.Templating;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// Template source.
    /// </summary>
    public class RazorTemplateSource : ITemplateSource
    {
        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="template">The template.</param>
        public RazorTemplateSource(string template)
        {
            Template = template;
        }

        /// <inheritdoc/>
        public string TemplateFile => null!;

        /// <inheritdoc/>
        public string Template { get; set; }

        /// <inheritdoc/>
        public TextReader GetTemplateReader()
        {
            return new StringReader(Template ?? "");
        }
    }

}

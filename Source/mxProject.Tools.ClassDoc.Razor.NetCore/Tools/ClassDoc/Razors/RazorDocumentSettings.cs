using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// Output document settings.
    /// </summary>
    /// <typeparam name="T">The type of object to output to the document.</typeparam>
    public class RazorDocumentSettings<T>
    {

        /// <summary>
        /// Gets or sets the document encoding.
        /// </summary>
        public Encoding? Encoding { get; set; }

        /// <summary>
        /// Gets or sets the Razor template.
        /// </summary>
        public string? Template { get; set; }

        /// <summary>
        /// Gets or sets the document formatter.
        /// </summary>
        public IClassDocumentFormatter? DocumentFormatter { get; set; }

        /// <summary>
        /// Gets or sets the output file name formatter.
        /// </summary>
        public Func<T, string>? FileNameFormatter { get; set; }

    }

}

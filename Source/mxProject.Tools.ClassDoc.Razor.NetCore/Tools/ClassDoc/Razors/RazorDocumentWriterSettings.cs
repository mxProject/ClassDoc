using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// DocumentWriter Setting.
    /// </summary>
    public class RazorDocumentWriterSettings
    {

        /// <summary>
        /// Gets or sets the path of the root directory of the output destination.
        /// </summary>
        public string? RootDirectory { get; set; }

        /// <summary>
        /// Gets or sets the namespace document settings.
        /// </summary>
        public RazorDocumentSettings<NamespaceInfo>? NamespaceDodumentSettings { get; set; }

        /// <summary>
        /// Gets or sets the type document settings.
        /// </summary>
        public RazorDocumentSettings<TypeWithComment>? TypeDodumentSettings { get; set; }

        /// <summary>
        /// Create a default settings.
        /// </summary>
        /// <param name="encoding">The output document encoding.</param>
        /// <param name="rootDirectory">The path of the root directory of the output destination.</param>
        /// <param name="documentFormatter">The document formatter.</param>
        /// <param name="namespaceDocumentTemplate">The Razor template for the namespace document.</param>
        /// <param name="typeDocumentTemplate">The Razor template for the type document.</param>
        /// <returns></returns>
        public static RazorDocumentWriterSettings CreateDefaultSettings(Encoding encoding, string rootDirectory, IClassDocumentFormatter documentFormatter, string namespaceDocumentTemplate, string typeDocumentTemplate)
        {
            return new RazorDocumentWriterSettings()
            {
                RootDirectory =rootDirectory,

                NamespaceDodumentSettings = new RazorDocumentSettings<NamespaceInfo>()
                {
                    Encoding = encoding,
                    DocumentFormatter = documentFormatter,
                    Template = namespaceDocumentTemplate
                },

                TypeDodumentSettings = new RazorDocumentSettings<TypeWithComment>
                {
                    Encoding = encoding,
                    DocumentFormatter = documentFormatter,
                    Template = typeDocumentTemplate
                }
            };
        }

    }

}

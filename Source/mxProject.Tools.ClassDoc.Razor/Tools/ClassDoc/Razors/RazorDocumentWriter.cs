using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// Document writer using Razor.
    /// </summary>
    public class RazorDocumentWriter : IClassDocumentWriter
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="encoding">The output document encoding.</param>
        public RazorDocumentWriter(Encoding encoding)
        {
            Encoding = encoding;

            var config = new RazorEngine.Configuration.TemplateServiceConfiguration
            {
                EncodedStringFactory = new RazorEngine.Text.RawStringFactory()
            };

#pragma warning disable CS0618
            var myConfiguredTemplateService = new RazorEngine.Templating.TemplateService(config);
            RazorEngine.Razor.SetTemplateService(myConfiguredTemplateService);
#pragma warning restore CS0618

        }

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        public Encoding Encoding { get; }

        /// <summary>
        /// Gets or sets the namespace document template.
        /// </summary>
        public string NamespaceDocumentTemplate { get; set; }

        /// <summary>
        /// Gets or sets the type document template.
        /// </summary>
        public string TypeDocumentTemplate { get; set; }

        /// <summary>
        /// Gets or sets the path of the root directory of the output destination.
        /// </summary>
        public string RootDirectory { get; set; }


        #region namaspace document

        /// <inheritdoc/>
        public void WriteNamespaceDocument(NamespaceInfo nameSpace, IClassDocumentFormatter formatter)
        {
            string filePath = GetNamespaceDocumentFilePath(nameSpace.Namespace, false);
            string dir = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            RazorEngine.Templating.DynamicViewBag viewBag = new RazorEngine.Templating.DynamicViewBag();
            viewBag.AddValue("Formatter", formatter);

#pragma warning disable CS0618
            File.WriteAllText(filePath, RazorEngine.Razor.Parse(NamespaceDocumentTemplate, nameSpace, viewBag, "NamespaceDocument"), Encoding);
#pragma warning restore CS0618
        }

        /// <summary>
        /// Gets the document output file path for the specified namespace.
        /// </summary>
        /// <param name="nameSpace">The namespace.</param>
        /// <param name="relative">A value that indicates whether to return a relative path from the root directory.</param>
        /// <returns></returns>
        private string GetNamespaceDocumentFilePath(string nameSpace, bool relative)
        {
            if (relative)
            {
                return Path.Combine(@"..\", $"{nameSpace}", "namespace.md");
            }
            else
            {
                return Path.Combine(RootDirectory, $"{nameSpace}", "namespace.md");
            }
        }

        #endregion

        #region type document

        /// <inheritdoc/>
        public void WriteTypeDocument(TypeWithComment type, IClassDocumentFormatter formatter)
        {
            string filePath = GetTypeDocumentFilePath(type, false);
            string dir = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            RazorEngine.Templating.DynamicViewBag viewBag = new RazorEngine.Templating.DynamicViewBag();
            viewBag.AddValue("Formatter", formatter);

#pragma warning disable CS0618
            File.WriteAllText(filePath, RazorEngine.Razor.Parse(TypeDocumentTemplate, type, viewBag, "TypeDocument"), Encoding);
#pragma warning restore CS0618
        }

        /// <summary>
        /// Gets the document output file path for the specified type.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="relative">A value that indicates whether to return a relative path from the root directory.</param>
        /// <returns></returns>
        private string GetTypeDocumentFilePath(TypeWithComment type, bool relative)
        {
            if (relative)
            {
                return Path.Combine(@"..\", $"{type.Namespace}", $"{type.Name}.md");
            }
            else
            {
                return Path.Combine(RootDirectory, $"{type.Namespace}", $"{type.Name}.md");
            }
        }

        #endregion

    }

}

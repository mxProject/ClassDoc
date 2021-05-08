using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using RazorEngine.Templating;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// Document writer using Razor.
    /// </summary>
    public class RazorDocumentWriter : IClassDocumentWriter, IDisposable
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="encoding"></param>
        /// <param name="namespaceDocumentTemplate"></param>
        /// <param name="typeDocumentTemplate"></param>
        protected RazorDocumentWriter(Encoding encoding, string namespaceDocumentTemplate, string typeDocumentTemplate)
        {
            Encoding = encoding;

            var config = new RazorEngine.Configuration.TemplateServiceConfiguration
            {
                EncodedStringFactory = new RazorEngine.Text.RawStringFactory()
            };

            m_Engine = RazorEngine.Templating.RazorEngineService.Create(config);

            m_NamespaceDocumentTempkateKey = new TemplateKey("NameSpaceDocument");
            m_NamespaceDocumentTempkateSource = new TemplateSource(namespaceDocumentTemplate);
            m_Engine.AddTemplate(m_NamespaceDocumentTempkateKey, m_NamespaceDocumentTempkateSource);

            m_TypeDocumentTempkateKey = new TemplateKey("TypeDocument");
            m_TypeDocumentTempkateSource = new TemplateSource(typeDocumentTemplate);
            m_Engine.AddTemplate(m_TypeDocumentTempkateKey, m_TypeDocumentTempkateSource);
        }

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="encoding">The output document encoding.</param>
        /// <param name="namespaceDocumentTemplate">The namespace document template.</param>
        /// <param name="typeDocumentTemplate">The type document template.</param>
        public static RazorDocumentWriter Create(Encoding encoding, string namespaceDocumentTemplate, string typeDocumentTemplate)
        {
            RazorDocumentWriter instance = new RazorDocumentWriter(encoding, namespaceDocumentTemplate, typeDocumentTemplate);

            instance.CompileTemplate();

            return instance;
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            m_Engine?.Dispose();
        }

        private readonly RazorEngine.Templating.IRazorEngineService m_Engine;

        #region template

        private readonly TemplateKey m_TypeDocumentTempkateKey;
        private readonly TemplateSource m_TypeDocumentTempkateSource;

        private readonly TemplateKey m_NamespaceDocumentTempkateKey;
        private readonly TemplateSource m_NamespaceDocumentTempkateSource;

        /// <summary>
        /// Compiles the templates.
        /// </summary>
        private void CompileTemplate()
        {
            m_Engine.Compile(m_NamespaceDocumentTempkateKey, typeof(NamespaceInfo));
            m_Engine.Compile(m_TypeDocumentTempkateKey, typeof(TypeWithComment));
        }

        /// <summary>
        /// Template Key.
        /// </summary>
        private readonly struct TemplateKey : RazorEngine.Templating.ITemplateKey
        {
            internal TemplateKey(string name)
            {
                Name = name;
            }

            public string Name { get; }

            public ResolveType TemplateType => ResolveType.Global;

            public ITemplateKey Context => this;

            public string GetUniqueKeyString()
            {
                return Name;
            }
        }

        /// <summary>
        /// Template Source.
        /// </summary>
        private class TemplateSource : RazorEngine.Templating.ITemplateSource
        {
            internal TemplateSource(string template)
            {
                Template = template;
            }

            public string TemplateFile => null;

            public string Template { get; set; }

            public TextReader GetTemplateReader()
            {
                return new StringReader(Template);
            }
        }

        #endregion

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        public Encoding Encoding { get; }

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

            using StreamWriter writer = new StreamWriter(filePath, false, Encoding);

            m_Engine.Run(m_NamespaceDocumentTempkateKey, writer, nameSpace.GetType(), nameSpace, viewBag: viewBag);

            writer.Flush();
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

            using StreamWriter writer = new StreamWriter(filePath, false, Encoding);

            m_Engine.Run(m_TypeDocumentTempkateKey, writer, type.GetType(), type, viewBag: viewBag);

            writer.Flush();
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

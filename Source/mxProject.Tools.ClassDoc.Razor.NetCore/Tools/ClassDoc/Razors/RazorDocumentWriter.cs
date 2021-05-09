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
        /// Create a new instance.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public RazorDocumentWriter(RazorDocumentWriterSettings settings)
        {
            Settings = settings;

            NamespaceDocumentTemplateState = Engine.CreateTemplateState("NameSpaceDocument", Settings.NamespaceDodumentSettings?.Template);
            TypeDocumentTemplateState = Engine.CreateTemplateState("TypeDocument", Settings.TypeDodumentSettings?.Template);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            m_Engine?.Dispose();
        }

        #region settings

        /// <summary>
        /// Gets the settings.
        /// </summary>
        protected RazorDocumentWriterSettings Settings { get; }

        #endregion

        #region engine

        /// <summary>
        /// Gets the Razor engine.
        /// </summary>
        protected RazorEngine.Templating.IRazorEngineService Engine
        {
            get
            {
                if (m_Engine == null)
                {
                    lock (this)
                    {
                        if (m_Engine == null)
                        {
                            m_Engine = CreateEngine();
                        }
                    }
                }
                return m_Engine;
            }
        }

        private RazorEngine.Templating.IRazorEngineService? m_Engine;

        /// <summary>
        /// Creates a Razor engine.
        /// </summary>
        /// <returns></returns>
        protected RazorEngine.Templating.IRazorEngineService CreateEngine()
        {
            var config = new RazorEngine.Configuration.TemplateServiceConfiguration
            {
                EncodedStringFactory = new RazorEngine.Text.RawStringFactory()
            };

            return RazorEngine.Templating.RazorEngineService.Create(config);
        }

        #endregion

        #region template

        /// <summary>
        /// Gets the state of the type document template.
        /// </summary>
        protected RazorTemplateState TypeDocumentTemplateState { get; }

        /// <summary>
        /// Gets the state of the namespace document template.
        /// </summary>
        protected RazorTemplateState NamespaceDocumentTemplateState { get; }

        #endregion

        #region namaspace document

        /// <summary>
        /// Outputs the information of the specified type to the document.
        /// </summary>
        /// <param name="nameSpace">The namespace information.</param>
        /// <exception cref="NullReferenceException">
        /// The document formatter is not set.
        /// </exception>
        public void WriteNamespaceDocument(NamespaceInfo nameSpace)
        {
            var formatter = Settings.NamespaceDodumentSettings?.DocumentFormatter;

            if (formatter == null)
            {
                throw new NullReferenceException("The document formatter is not set.");
            }

            WriteNamespaceDocument(nameSpace, formatter);
        }

        /// <inheritdoc/>
        public void WriteNamespaceDocument(NamespaceInfo nameSpace, IClassDocumentFormatter formatter)
        {
            string filePath = GetNamespaceDocumentFilePath(nameSpace, false);

            if (!NamespaceDocumentTemplateState.IsCompiled)
            {
                NamespaceDocumentTemplateState.Compile(typeof(NamespaceInfo));
            }

            WriteDocument(nameSpace, filePath, Settings.NamespaceDodumentSettings?.Encoding, NamespaceDocumentTemplateState.Key, formatter);
        }

        /// <summary>
        /// Gets the document output file path for the specified namespace.
        /// </summary>
        /// <param name="nameSpace">The namespace.</param>
        /// <param name="relative">A value that indicates whether to return a relative path from the root directory.</param>
        /// <returns></returns>
        private string GetNamespaceDocumentFilePath(NamespaceInfo nameSpace, bool relative)
        {
            string fileName = (Settings.NamespaceDodumentSettings?.FileNameFormatter ?? GetNamespaceDocumentFileName)(nameSpace);

            if (relative)
            {
                return Path.Combine(@"..\", $"{nameSpace.Namespace}", fileName);
            }
            else
            {
                return Path.Combine(Settings.RootDirectory, $"{nameSpace.Namespace}", fileName);
            }
        }

        /// <summary>
        /// Gets the document output file name for the specified namespace.
        /// </summary>
        /// <param name="nameSpace">The namespace.</param>
        /// <returns></returns>
        private string GetNamespaceDocumentFileName(NamespaceInfo nameSpace)
        {
            return "namespace.md";
        }

        #endregion

        #region type document

        /// <summary>
        /// Outputs the information of the specified type to the document.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <exception cref="NullReferenceException">
        /// The document formatter is not set.
        /// </exception>
        public void WriteTypeDocument(TypeWithComment type)
        {
            var formatter = Settings.TypeDodumentSettings?.DocumentFormatter;

            if (formatter == null)
            {
                throw new NullReferenceException("The document formatter is not set.");
            }

            WriteTypeDocument(type, formatter);
        }

        /// <inheritdoc/>
        public void WriteTypeDocument(TypeWithComment type, IClassDocumentFormatter formatter)
        {
            string filePath = GetTypeDocumentFilePath(type, false);

            if (!TypeDocumentTemplateState.IsCompiled)
            {
                TypeDocumentTemplateState.Compile(typeof(TypeWithComment));
            }

            WriteDocument(type, filePath, Settings.TypeDodumentSettings?.Encoding, TypeDocumentTemplateState.Key, formatter);
        }

        /// <summary>
        /// Gets the document output file path for the specified type.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="relative">A value that indicates whether to return a relative path from the root directory.</param>
        /// <returns></returns>
        private string GetTypeDocumentFilePath(TypeWithComment type, bool relative)
        {
            string fileName = (Settings.TypeDodumentSettings?.FileNameFormatter ?? GetTypeDocumentFileName)(type);

            if (relative)
            {
                return Path.Combine(@"..\", $"{type.Namespace}", fileName);
            }
            else
            {
                return Path.Combine(Settings.RootDirectory, $"{type.Namespace}", fileName);
            }
        }

        /// <summary>
        /// Gets the document output file name for the specified type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private string GetTypeDocumentFileName(TypeWithComment type)
        {
            return $"{type.Name}.md";
        }

        #endregion

        #region output document

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="filePath"></param>
        /// <param name="encoding"></param>
        /// <param name="templateKey"></param>
        /// <param name="formatter"></param>
        private void WriteDocument<T>(T model, string filePath, Encoding? encoding, ITemplateKey templateKey, IClassDocumentFormatter formatter)
        {
            string dir = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            RazorEngine.Templating.DynamicViewBag viewBag = new RazorEngine.Templating.DynamicViewBag();
            viewBag.AddValue("Formatter", formatter);

            using StreamWriter writer = new StreamWriter(filePath, false, encoding ?? Encoding.UTF8);

            Engine.Run(templateKey, writer, typeof(T), model, viewBag: viewBag);

            writer.Flush();
        }

        #endregion

    }

}

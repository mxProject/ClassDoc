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

        #region ctor

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public RazorDocumentWriter(RazorDocumentWriterSettings settings)
        {
            Settings = settings ?? CreateDefaultSettings(Encoding.UTF8);

            NamespaceDocumentTemplateState = Engine.CreateTemplateState("NameSpaceDocument", Settings.NamespaceDodumentSettings?.Template);
            TypeDocumentTemplateState = Engine.CreateTemplateState("TypeDocument", Settings.TypeDodumentSettings?.Template);
        }

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="encoding">The output document encoding.</param>
        [Obsolete]
        public RazorDocumentWriter(Encoding encoding) : this(CreateDefaultSettings(encoding))
        {
        }

        #endregion

        /// <inheritdoc/>
        public void Dispose()
        {
            Engine?.Dispose();
        }

        #region settings

        /// <summary>
        /// Gets the settings.
        /// </summary>
        protected RazorDocumentWriterSettings Settings { get; }

        /// <summary>
        /// Create a default settings.
        /// </summary>
        /// <param name="encoding">The output document encoding.</param>
        /// <returns></returns>
        private static RazorDocumentWriterSettings CreateDefaultSettings(Encoding encoding)
        {
            return new RazorDocumentWriterSettings()
            {
                NamespaceDodumentSettings = new RazorDocumentSettings<NamespaceInfo>()
                {
                    Encoding = encoding
                },
                TypeDodumentSettings = new RazorDocumentSettings<TypeWithComment>
                {
                    Encoding = encoding
                }
            };
        }

        /// <summary>
        /// Gets the encoding.
        /// </summary>
        [Obsolete]
        public Encoding Encoding { get; }

        /// <summary>
        /// Gets or sets the namespace document template.
        /// </summary>
        [Obsolete]
        public string NamespaceDocumentTemplate
        {
            get { return NamespaceDocumentTemplateState.GetTemplate(); }
            set { NamespaceDocumentTemplateState.SetTemplate(value); }
        }

        /// <summary>
        /// Gets or sets the type document template.
        /// </summary>
        [Obsolete]
        public string TypeDocumentTemplate
        {
            get { return TypeDocumentTemplateState.GetTemplate(); }
            set { TypeDocumentTemplateState.SetTemplate(value); }
        }

        /// <summary>
        /// Gets or sets the path of the root directory of the output destination.
        /// </summary>
        [Obsolete]
        public string RootDirectory
        {
            get { return Settings.RootDirectory; }
            set { Settings.RootDirectory = value; }
        }

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

        private RazorEngine.Templating.IRazorEngineService m_Engine;

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
        /// 
        /// </summary>
        protected RazorTemplateState TypeDocumentTemplateState { get; }

        /// <summary>
        /// 
        /// </summary>
        protected RazorTemplateState NamespaceDocumentTemplateState { get; }

        #endregion

        #region namaspace document

        /// <summary>
        /// Outputs the information of the specified namespace to the document.
        /// </summary>
        /// <param name="nameSpace">The namespace information.</param>
        public void WriteNamespaceDocument(NamespaceInfo nameSpace)
        {
            WriteNamespaceDocument(nameSpace, Settings.NamespaceDodumentSettings?.DocumentFormatter);
        }

        /// <inheritdoc/>
        public void WriteNamespaceDocument(NamespaceInfo nameSpace, IClassDocumentFormatter formatter)
        {
            string filePath = GetNamespaceDocumentFilePath(nameSpace, false);
            string dir = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            RazorEngine.Templating.DynamicViewBag viewBag = new RazorEngine.Templating.DynamicViewBag();
            viewBag.AddValue("Formatter", formatter);

            if (!NamespaceDocumentTemplateState.IsCompiled)
            {
                NamespaceDocumentTemplateState.Compile(typeof(NamespaceInfo));
            }

            using (StreamWriter writer = new StreamWriter(filePath, false, Settings.NamespaceDodumentSettings.Encoding))
            {
                Engine.Run(NamespaceDocumentTemplateState.Key, writer, nameSpace.GetType(), nameSpace, viewBag: viewBag);
                writer.Flush();
            }
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
        public void WriteTypeDocument(TypeWithComment type)
        {
            WriteTypeDocument(type, Settings.TypeDodumentSettings?.DocumentFormatter);
        }

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

            if (!TypeDocumentTemplateState.IsCompiled)
            {
                TypeDocumentTemplateState.Compile(typeof(TypeWithComment));
            }

            using (StreamWriter writer = new StreamWriter(filePath, false, Settings.TypeDodumentSettings.Encoding))
            {
                Engine.Run(TypeDocumentTemplateState.Key, writer, type.GetType(), type, viewBag: viewBag);
                writer.Flush();
            }
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

        private string GetTypeDocumentFileName(TypeWithComment type)
        {
            return $"{type.Name}.md";
        }

        #endregion

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine.Templating;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// Template state.
    /// </summary>
    public class RazorTemplateState
    {

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="engine">The template engine.</param>
        /// <param name="key">The template key.</param>
        /// <param name="template">The template.</param>
        public RazorTemplateState(IRazorEngineService engine, string key, string template) : this(engine, new RazorTemplateKey(key), new RazorTemplateSource(template))
        {
        }

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="engine">The template engine.</param>
        /// <param name="key">The template key.</param>
        /// <param name="source">The template source.</param>
        public RazorTemplateState(IRazorEngineService engine, RazorTemplateKey key, RazorTemplateSource source)
        {
            Engine = engine;
            Key = key;
            Source = source;
        }

        /// <summary>
        /// Gets the template engine.
        /// </summary>
        private IRazorEngineService Engine { get; }

        /// <summary>
        /// Gets the template key.
        /// </summary>
        public RazorTemplateKey Key { get; }

        /// <summary>
        /// Gets the template source.
        /// </summary>
        public RazorTemplateSource Source { get; }

        /// <summary>
        /// Gets the template.
        /// </summary>
        /// <returns></returns>
        public string GetTemplate()
        {
            return Source.Template;
        }

        /// <summary>
        /// Sets the template.
        /// </summary>
        /// <param name="template"></param>
        public void SetTemplate(string template)
        {
            Source.Template = template;
            IsCompiled = false;
        }

        /// <summary>
        /// Gets a value that indicates whether the template has been compiled.
        /// </summary>
        public bool IsCompiled { get; private set; }

        /// <summary>
        /// Compiles the template.
        /// </summary>
        /// <param name="modelType">The type of object to output to the document.</param>
        public void Compile(Type modelType)
        {
            Engine.Compile(Key, modelType);
            IsCompiled = true;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RazorEngine.Templating;

namespace mxProject.Tools.ClassDoc.Razors
{

    internal static class IRazorEngineServiceExtensions
    {

        internal static RazorTemplateState CreateTemplateState(this IRazorEngineService engine, string templateKey, string? template)
        {
            return CreateTemplateState(engine, new RazorTemplateKey(templateKey), new RazorTemplateSource(template ?? ""));
        }

        internal static RazorTemplateState CreateTemplateState(this IRazorEngineService engine, RazorTemplateKey key, RazorTemplateSource source)
        {
            engine.AddTemplate(key, source);

            return new RazorTemplateState(engine, key, source);
        }

    }

}

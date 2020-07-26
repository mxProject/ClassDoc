using System;
using System.IO;
using System.Linq;
using System.Text;
using mxProject.Tools.ClassDoc;
using mxProject.Tools.ClassDoc.Razors;
using mxProject.Tools.ClassDoc.Markdown;
using System.Collections.Generic;

namespace SampleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OutputDocument();
                Console.WriteLine("done.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        static void OutputDocument()
        {
            // Razor templates
            string typeTemplate = @".\RazorTemplates\TypeTemplate.txt";
            string namespaceTemplate = @".\RazorTemplates\NamespaceTemplate.txt";

            // Loading assemblies
            string[] dlls = new[]
            {
                @".\LoadAssemblies\mxProject.Tools.ClassDoc.dll",
                @".\LoadAssemblies\mxProject.Tools.ClassDoc.Razor.dll",
                @".\LoadAssemblies\SampleLibrary1.dll",
                @".\LoadAssemblies\SampleLibrary2.dll"
            };

            // Setup a writer.
            RazorDocumentWriter writer = new RazorDocumentWriter(Encoding.UTF8)
            {
                RootDirectory = @".\Documents\",
                TypeDocumentTemplate = File.ReadAllText(typeTemplate, Encoding.UTF8),
                NamespaceDocumentTemplate = File.ReadAllText(namespaceTemplate, Encoding.UTF8),
            };

            // Setup a context and a formatter.
            ClassDocContext context = new ClassDocContext()
            {
                // note: These values are the same as those set in the initial value of ClassDocContext.
                ConstructorFilter = ConstructorInfoExtensions.IsRecommendOutputToDocument,
                TypeFilter = TypeExtenstions.IsRecommendOutputToDocument,
                PropertyFilter = PropertyInfoExtensions.IsRecommendOutputToDocument,
                FieldFilter = FieldInfoExtensions.IsRecommendOutputToDocument,
                MethodFilter = MethodInfoExtensions.IsRecommendOutputToDocument,
                EventFilter = EventInfoExtensions.IsRecommendOutputToDocument,
            };

            MarkdownFormatter formatter = new MarkdownFormatter(context)
            {
                // note: These values are the same as those set in the initial value of MarkdownFormatter.
                ConstructorAnchorDefaultFormat = "{0} Constructor",
                PropertyAnchorDefaultFormat = "{0} Property",
                FieldAnchorDefaultFormat = "{0} Field",
                MethodAnchorDefaultFormat = "{0} Method",
                EventAnchorDefaultFormat = "{0} Event",
                ParameterNameDefaultFormat = "`{0}`",
            };

            // Load type information.
            IReadOnlyList<TypeWithComment> types = TypeLoader.LoadTypes(dlls, context, null);

            // Group by namespace.
            foreach (var group in types.GroupBy(type => type.Namespace).OrderBy(group => group.Key))
            {
                NamespaceInfo nameSpace = new NamespaceInfo(group.First()?.Namespace, group);

                // Output the document for the namespace.
                writer.WriteNamespaceDocument(nameSpace, formatter);

                // Output the document for the type.
                foreach (var type in group.OrderBy(type => type.Name))
                {
                    writer.WriteTypeDocument(type, formatter);
                }
            }

        }
    }
}

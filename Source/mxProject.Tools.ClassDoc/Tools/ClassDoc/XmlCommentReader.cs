using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.Xml.Linq;
using Cysharp.Text;
using System.Runtime.CompilerServices;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// XML comment reader.
    /// </summary>
    public static class XmlCommentReader
    {

        /// <summary>
        /// Reads XML comments from the specified XML document.
        /// </summary>
        /// <param name="xDocument">The XML document.</param>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        /// <param name="nameSpace">The namespace to read.</param>
        /// <returns>An Enumerator.</returns>
        internal static IEnumerable<XmlComment> ReadXmlComments(XDocument xDocument, ClassDocContext context, string? nameSpace = null)
        {

            string assemblyName = xDocument.Descendants("assembly").First().Elements("name").First().Value;

            IEnumerable<XmlComment?> documents = xDocument.Descendants("member")

                .Select(x =>
                {

                    // signature

                    string signatureName = x.Attribute("name").Value;

                    if (!XmlCommentSignature.TryParse(signatureName, out XmlCommentSignature signature)) { return null; }

                    string summary = FormatTextElement(x.Elements("summary"));
                    string returns = FormatTextElement(x.Elements("returns"));
                    string remarks = FormatTextElement(x.Elements("remarks"));

                    // paeameter

                    var parameters = x.Elements("param")
                        .Select(element => (name: element.Attribute("name").Value, content: FormatTextElement(element)))
                        .GroupBy(comment => comment.name)
                        .ToDictionary(group => group.Key, g => new ParameterComment(g.Key, g.Select(v => v.content).ToArray(), context))
                        ;

                    // type parameter

                    var typeParameters = x.Elements("typeparam")
                        .Select(element => (name: element.Attribute("name").Value, content: FormatTextElement(element)))
                        .GroupBy(comment => comment.name)
                        .ToDictionary(group => group.Key, g => new ParameterComment(g.Key, g.Select(v => v.content).ToArray(), context))
                        ;

                    // exception

                    var exceptions = x.Elements("exception")
                        .Select(e => (name: e.Attribute("cref").Value, content: FormatTextElement(e)))
                        .GroupBy(comment => comment.name)
                        .ToDictionary(group => group.Key, g => new ExceptionComment(g.Key, g.Select(v => v.content).ToArray(), context))
                        .Values.ToArray();

                    // inheritdoc

                    bool inheritdoc = x.Element("inheritdoc") != null;

                    return new XmlComment(context)
                    {
                        SignatureName = signatureName,
                        IsInherit = inheritdoc,
                        Signature = signature,
                        Summary = summary.Trim(),
                        Remarks = remarks.Trim(),
                        ParametersInternal = parameters,
                        TypeParametersInternal = typeParameters,
                        Returns = returns.Trim(),
                        ExceptionsInternal = exceptions,
                    };

                });

            foreach (var doc in documents)
            {
                if (doc == null) { continue; }

                if (!string.IsNullOrWhiteSpace(nameSpace) && !doc.TypeName.StartsWith(nameSpace)) { continue; }

                // System.Diagnostics.Debug.WriteLine(doc.SignatureName);

                yield return doc;
            }

        }

        /// <summary>
        /// Formats the specified text elements.
        /// </summary>
        /// <param name="elements">The elements</param>
        /// <returns></returns>
        private static string FormatTextElement(IEnumerable<XElement> elements)
        {
            if (elements == null) { return ""; }

            var sb = ZString.CreateStringBuilder();

            foreach (var e in elements)
            {
                FormatTextElement(e, ref sb);
            }

            return sb.ToString();

        }

        /// <summary>
        /// Formats the specified text element.
        /// </summary>
        /// <param name="element">The element</param>
        /// <returns></returns>
        private static string FormatTextElement(XElement element)
        {

            var sb = ZString.CreateStringBuilder();

            FormatTextElement(element, ref sb);

            return sb.ToString();

        }

        /// <summary>
        /// Formats the specified text element.
        /// </summary>
        /// <param name="element">The element</param>
        /// <param name="sb">The string buffer.</param>
        /// <returns></returns>
        private static void FormatTextElement(XElement element, ref Utf16ValueStringBuilder sb)
        {

            if (element == null) { return; }

            var lastNode = element.LastNode;
            var currentNode = element.FirstNode;

            while (true)
            {
                if (currentNode == null) { break; }

                sb.Append(FormatString(currentNode.ToString()));

                if (currentNode == lastNode) { break; }

                currentNode = currentNode.NextNode;
            }

        }

        /// <summary>
        /// Formats the specified text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        private static string FormatString(string text)
        {
            if (text == null) { return ""; }

            // newline and tab

            if (text.Contains('\r') || text.Contains('\n') || text.Contains('\t'))
            {
                text = string.Join("", text.Split(new[] { "\r", "\n", "\t" }, StringSplitOptions.RemoveEmptyEntries).Select(y => y.Trim()));
            }

            // para

            if (text.Contains("<para>"))
            {
                text = Regex.Replace(text, @"<para>", Environment.NewLine);
            }
            if (text.Contains("</para>"))
            {
                text = Regex.Replace(text, @"</para>", Environment.NewLine);
            }
            if (text.Contains("<para/>") || text.Contains("<para ") || text.Contains("<para\t"))
            {
                text = Regex.Replace(text, @"<para\s*/>", Environment.NewLine);
            }

            return text;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Cysharp.Text;

namespace mxProject.Tools.ClassDoc.Markdown
{

    /// <summary>
    /// Document formatter for Markdown.
    /// </summary>
    public class MarkdownFormatter : IClassDocumentFormatter
    {

        /// <summary>
        /// Creates a new instance.
        /// </summary>
        /// <param name="context">The context that manages the state of the output process for class documents.</param>
        public MarkdownFormatter(ClassDocContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        private ClassDocContext Context { get; }

        #region format strings

        /// <summary>
        /// Gets or sets the default format string applied to a constructor anchor.
        /// </summary>
        public string ConstructorAnchorDefaultFormat { get; set; } = "{0} Constructor";

        /// <summary>
        /// Gets or sets the default format string applied to a method anchor.
        /// </summary>
        public string MethodAnchorDefaultFormat { get; set; } = "{0} Method";

        /// <summary>
        /// Gets or sets the default format string applied to a property anchor.
        /// </summary>
        public string PropertyAnchorDefaultFormat { get; set; } = "{0} Property";

        /// <summary>
        /// Gets or sets the default format string applied to a field anchor.
        /// </summary>
        public string FieldAnchorDefaultFormat { get; set; } = "{0} Field";

        /// <summary>
        /// Gets or sets the default format string applied to an event anchor.
        /// </summary>
        public string EventAnchorDefaultFormat { get; set; } = "{0} Event";

        /// <summary>
        /// Gets or sets the default format string applied to the a parameter name.
        /// </summary>
        public string ParameterNameDefaultFormat { get; set; } = "`{0}`";

        #endregion

        #region type

        /// <inheritdoc />
        public string FormatToReadableName(TypeWithComment type, bool isFullName)
        {
            return System.Web.HttpUtility.HtmlEncode(type.Info.FormatToReadableTypeName(isFullName));
        }

        /// <inheritdoc />
        public string FormatToAnchor(TypeWithComment type, string? format = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public string FormatToLink(TypeWithComment type, bool isFullName, string? displayFormat = null, string? anchorFormat = null)
        {
            string displayText;

            if (string.IsNullOrEmpty(displayFormat))
            {
                displayText = FormatToReadableName(type, isFullName);
            }
            else
            {
                displayText = ZString.Format(displayFormat, FormatToReadableName(type, isFullName));
            }

            if (type.Comment.IsEmpty)
            {
                return displayText;
            }
            else
            {
                return ZString.Format("[{0}](../{1}/{2}.md)", displayText, type.Namespace, type.Name);
            }
        }

        #endregion

        #region constructor

        /// <inheritdoc/>
        public string FormatToReadableSignature(ConstructorInfoWithComment constructor)
        {
            return System.Web.HttpUtility.HtmlEncode(constructor.Info.FormatToReadableSignature());
        }

        /// <inheritdoc/>
        public string FormatToAnchor(ConstructorInfoWithComment constructor, string? format = null)
        {
            var fmt = format ?? ConstructorAnchorDefaultFormat;

            if (string.IsNullOrEmpty(fmt))
            {
                return FormatToReadableSignature(constructor);
            }
            else
            {
                return ZString.Format(fmt, FormatToReadableSignature(constructor));
            }
        }

        /// <inheritdoc/>
        public string FormatToLink(TypeWithComment thisType, ConstructorInfoWithComment constructor, string? displayFormat = null, string? anchorFormat = null)
        {
            string? fmt = anchorFormat ?? ConstructorAnchorDefaultFormat;

            TypeWithComment declaringType = constructor.GetDeclaringTypeInfo();

            if (object.Equals(thisType, declaringType) || constructor.Info.DeclaringType.IsAssignableFrom(thisType.Info) || declaringType.Comment.IsEmpty)
            {
                string anchor = constructor.Info.FormatToReadableSignature();

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }
            else
            {
                string anchor = ZString.Concat(declaringType.Info.FormatToReadableTypeName(false), ".", constructor.Info.FormatToReadableSignature());

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                string typeLink = ZString.Format("../{1}/{2}.md", FormatToReadableName(declaringType, false), declaringType.Namespace, declaringType.Name);

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }

        }

        #endregion

        #region method

        /// <inheritdoc/>
        public string FormatToReadableSignature(MethodInfoWithComment method)
        {
            return System.Web.HttpUtility.HtmlEncode(method.Info.FormatToReadableSignature());
        }

        /// <inheritdoc/>
        public string FormatToAnchor(MethodInfoWithComment method, string? format = null)
        {
            var fmt = format ?? MethodAnchorDefaultFormat;

            if (string.IsNullOrEmpty(fmt))
            {
                return FormatToReadableSignature(method);
            }
            else
            {
                return ZString.Format(fmt, FormatToReadableSignature(method));
            }
        }

        /// <inheritdoc/>
        public string FormatToLink(TypeWithComment thisType, MethodInfoWithComment method, string? displayFormat = null, string? anchorFormat = null)
        {

            string? fmt = anchorFormat ?? MethodAnchorDefaultFormat;

            TypeWithComment declaringType = method.GetDeclaringTypeInfo();

            if (object.Equals(thisType, declaringType) || method.Info.DeclaringType.IsAssignableFrom(thisType.Info) || declaringType.Comment.IsEmpty)
            {
                string anchor = method.Info.FormatToReadableSignature();

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }
            else
            {
                string anchor = ZString.Concat(declaringType.Info.FormatToReadableTypeName(false), ".", method.Info.FormatToReadableSignature());

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                string typeLink = ZString.Format("../{1}/{2}.md", FormatToReadableName(declaringType, false), declaringType.Namespace, declaringType.Name);

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }

        }

        #endregion

        #region property

        /// <inheritdoc/>
        public string FormatToReadableSignature(PropertyInfoWithComment property)
        {
            return System.Web.HttpUtility.HtmlEncode(property.Info.FormatToReadableSignature());
        }

        /// <inheritdoc/>
        public string FormatToAnchor(PropertyInfoWithComment property, string? format = null)
        {
            var fmt = format ?? PropertyAnchorDefaultFormat;

            if (string.IsNullOrEmpty(fmt))
            {
                return FormatToReadableSignature(property);
            }
            else
            {
                return ZString.Format(fmt, FormatToReadableSignature(property));
            }
        }

        /// <inheritdoc/>
        public string FormatToLink(TypeWithComment thisType, PropertyInfoWithComment property, string? displayFormat = null, string? anchorFormat = null)
        {

            string? fmt = anchorFormat ?? PropertyAnchorDefaultFormat;

            TypeWithComment declaringType = property.GetDeclaringTypeInfo();

            if (object.Equals(thisType, declaringType) || property.Info.DeclaringType.IsAssignableFrom(thisType.Info) || declaringType.Comment.IsEmpty)
            {
                string anchor = property.Info.FormatToReadableSignature();

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }
            else
            {
                string anchor = ZString.Concat(declaringType.Info.FormatToReadableTypeName(false), ".", property.Info.FormatToReadableSignature());

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                string typeLink = ZString.Format("../{1}/{2}.md", FormatToReadableName(declaringType, false), declaringType.Namespace, declaringType.Name);

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }

        }

        #endregion

        #region field

        /// <inheritdoc/>
        public string FormatToAnchor(FieldInfoWithComment evt, string? format = null)
        {
            var fmt = format ?? FieldAnchorDefaultFormat;

            if (string.IsNullOrEmpty(fmt))
            {
                return evt.Name;
            }
            else
            {
                return ZString.Format(fmt, evt.Name);
            }
        }

        /// <inheritdoc/>
        public string FormatToLink(TypeWithComment thisType, FieldInfoWithComment evt, string? displayFormat = null, string? anchorFormat = null)
        {

            string? fmt = anchorFormat ?? FieldAnchorDefaultFormat;

            TypeWithComment declaringType = evt.GetDeclaringTypeInfo();

            if (object.Equals(thisType, declaringType) || evt.Info.DeclaringType.IsAssignableFrom(thisType.Info) || declaringType.Comment.IsEmpty)
            {
                string anchor = evt.Info.Name;

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }
            else
            {
                string anchor = ZString.Concat(declaringType.Info.FormatToReadableTypeName(false), ".", evt.Info.Name);

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                string typeLink = ZString.Format("../{1}/{2}.md", FormatToReadableName(declaringType, false), declaringType.Namespace, declaringType.Name);

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }

        }

        #endregion

        #region event

        /// <inheritdoc/>
        public string FormatToAnchor(EventInfoWithComment evt, string? format = null)
        {
            var fmt = format ?? EventAnchorDefaultFormat;

            if (string.IsNullOrEmpty(fmt))
            {
                return evt.Name;
            }
            else
            {
                return ZString.Format(fmt, evt.Name);
            }
        }

        /// <inheritdoc/>
        public string FormatToLink(TypeWithComment thisType, EventInfoWithComment evt, string? displayFormat = null, string? anchorFormat = null)
        {

            string? fmt = anchorFormat ?? EventAnchorDefaultFormat;

            TypeWithComment declaringType = evt.GetDeclaringTypeInfo();

            if (object.Equals(thisType, declaringType) || evt.Info.DeclaringType.IsAssignableFrom(thisType.Info) || declaringType.Comment.IsEmpty)
            {
                string anchor = evt.Info.Name;

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}](#{1})", displayText, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }
            else
            {
                string anchor = ZString.Concat(declaringType.Info.FormatToReadableTypeName(false), ".", evt.Info.Name);

                string displayText;

                if (string.IsNullOrEmpty(displayFormat))
                {
                    displayText = System.Web.HttpUtility.HtmlEncode(anchor);
                }
                else
                {
                    displayText = ZString.Format(displayFormat, System.Web.HttpUtility.HtmlEncode(anchor));
                }

                string typeLink = ZString.Format("../{1}/{2}.md", FormatToReadableName(declaringType, false), declaringType.Namespace, declaringType.Name);

                if (string.IsNullOrEmpty(fmt))
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(anchor));
                }
                else
                {
                    return ZString.Format("[{0}]({1}#{2})", displayText, typeLink, ToAnchor(ZString.Format(fmt, anchor)));
                }
            }

        }

        #endregion

        #region text

        /// <inheritdoc/>
        public string ReplaceReferenceTag(TypeWithComment thisType, string text)
        {
            if (string.IsNullOrEmpty(text)) { return ""; }

            if (text.Contains("<see"))
            {
                text = Regex.Replace(text, @"<see cref=""(?<cref>([T|F|P|M|E]:[^\""]*))""\s*(/>|>(?<text>[^<]*)</see>)", m => ZString.Concat(" ", ResolveSeeElement(thisType, m), " "));
            }

            if (text.Contains("<seealso"))
            {
                text = Regex.Replace(text, @"<seealso cref=""(?<cref>([T|F|P|M|E]:[^\""]*))""\s*(/>|>(?<text>[^<]*)</seealso>)", m => ZString.Concat(" ", ResolveSeeElement(thisType, m), " "));
            }

            if (text.Contains("<paramref"))
            {
                text = Regex.Replace(text, @"<paramref name=""(?<name>([^\""]*))""\s*(/>|>(?<text>[^<]*)</paramref>)", m => ZString.Concat(" ", ResolveNameElement(thisType, m), " "));
            }

            if (text.Contains("<typeparamref"))
            {
                text = Regex.Replace(text, @"<typeparamref name=""(?<name>([^\""]*))""\s*(/>|>(?<text>[^<]*)</paramref>)", m => ZString.Concat(" ", ResolveNameElement(thisType, m), " "));
            }

            return text;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thisType"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        private string ResolveSeeElement(TypeWithComment thisType, Match match)
        {

            var cref = match.Groups["cref"]?.Value ?? "";
            var text = match.Groups["text"]?.Value ?? "";

            if (!string.IsNullOrWhiteSpace(cref) && XmlCommentSignature.TryParse(cref, out var signature))
            {
                switch (signature.Kind)
                {
                    case XmlCommentKind.Type:

                        if (Context.TryGetTypeInfo(signature, out var type))
                        {
                            return FormatToLink(type, false, displayFormat: text);
                        }
                        else
                        {
                            return signature.TypeName;
                        }

                    case XmlCommentKind.Method:

                        if (Context.TryGetMethodInfo(signature, out var method))
                        {
                            return FormatToLink(thisType, method, displayFormat: text);
                        }
                        else
                        {
                            return signature.MemberName ?? "";
                        }

                    case XmlCommentKind.Property:

                        if (Context.TryGetPropertyInfo(signature, out var prop))
                        {
                            return FormatToLink(thisType, prop, displayFormat: text);
                        }
                        else
                        {
                            return signature.MemberName ?? "";
                        }

                    case XmlCommentKind.Field:

                        if (Context.TryGetFieldInfo(signature, out var field))
                        {
                            return FormatToLink(thisType, field, displayFormat: text);
                        }
                        else
                        {
                            return signature.MemberName ?? "";
                        }

                    case XmlCommentKind.Event:
                        
                        if (Context.TryGetEventInfo(signature, out var evt))
                        {
                            return FormatToLink(thisType, evt, displayFormat: text);
                        }
                        else
                        {
                            return signature.MemberName ?? "";
                        }
                }
            }

            if (!string.IsNullOrWhiteSpace(text)) { return text; }
            if (!string.IsNullOrWhiteSpace(cref)) { return cref; }

            return "";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="thisType"></param>
        /// <param name="match"></param>
        /// <returns></returns>
        private string ResolveNameElement(TypeWithComment thisType, Match match)
        {

            var name = match.Groups["name"]?.Value ?? "";
            var text = match.Groups["text"]?.Value ?? "";

            if (!string.IsNullOrWhiteSpace(text)) { return ZString.Format(ParameterNameDefaultFormat, text); }
            if (!string.IsNullOrWhiteSpace(name)) { return ZString.Format(ParameterNameDefaultFormat, name); }

            return "";

        }

        #endregion





        #region anchor

        /// <summary>
        /// Converts the specified string to anchor format.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns>The formatted anchor.</returns>
        public static string? ToAnchor(string? text)
        {

            if (text == null || text == "") { return text; }

            var sb = ZString.CreateStringBuilder();

            foreach (var c in text.ToLower())
            {
                if (Array.IndexOf(s_AnchorIgnoreChars, c) >= 0) { continue; }

                if (c == '　') { continue; }

                if (c == ' ')
                {
                    sb.Append('-');
                }
                else
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();

        }

        /// <summary>
        /// Characters that should not be included in the anchor.
        /// </summary>
        /// <remarks>
        /// https://qiita.com/hennin/items/7ee58dd7d7c013a23be7
        /// </remarks>
        static readonly char[] s_AnchorIgnoreChars = new[] {
            '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '|', '~', '=', '\\', '`', '[', ']', '{', '}', ';', '\'', ':', '"', ',', '.', '/', '<', '>', '?'
            , '！', '＠', '＃', '＄', '％', '＾', '＆', '＊', '（', '）', '＋', '｜', '〜', '＝', '￥', '｀', '「', '」', '｛', '｝', '；', '’', '：', '”', '、', '。', '・', '＜', '＞', '？'
            , '【', '】', '『', '』', '《', '》', '〔', '〕', '［', '］', '‹', '›', '«', '»', '〘', '〙', '〚', '〛'
        };

        #endregion

        #region bullets

        /// <summary>
        /// Outputs the specified string in a bullet list.
        /// </summary>
        /// <returns></returns>
        public static string WriteBullets(IEnumerable<string> lines, string mark = "*", int indent = 0)
        {
            if (lines == null) { return ""; }

            var sb = ZString.CreateStringBuilder();

            foreach (var line in lines)
            {
                if (line == null || line == "") { continue; }

                for (int i = 0; i < indent; ++i)
                {
                    sb.Append(" ");
                }

                if (!string.IsNullOrEmpty(mark))
                {
                    sb.Append(mark);
                    sb.Append(" ");
                }

                sb.Append(line);

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        #endregion

    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Provides the functionality needed to format a class document.
    /// </summary>
    public interface IClassDocumentFormatter
    {

        /// <summary>
        /// Formats the specified type into a human-readable type name.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="isFullName">A value whether to get the full type name with namespace.</param>
        /// <returns>The formatted name.</returns>
        string FormatToReadableName(TypeWithComment type, bool isFullName);

        /// <summary>
        /// Formats the specified type into a link text.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="isFullName">A value whether to get the full type name with namespace.</param>
        /// <param name="displayFormat">The display format string.</param>
        /// <param name="anchorFormat">The anchor format string.</param>
        /// <returns>The formatted link text.</returns>
        string FormatToLink(TypeWithComment type, bool isFullName, string? displayFormat = null, string? anchorFormat = null);

        /// <summary>
        /// Formats the specified type into an anchor text.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="anchorFormat">The format string.</param>
        /// <returns>The formatted anchor text.</returns>
        string FormatToAnchor(TypeWithComment type, string? anchorFormat = null);

        #region constructor

        /// <summary>
        /// Formats the specified constructor into a human-readable signature.
        /// </summary>
        /// <param name="constructor">The constructor information.</param>
        /// <returns>The formatted signature.</returns>
        string FormatToReadableSignature(ConstructorInfoWithComment constructor);

        /// <summary>
        /// Formats the specified constructor into a link text.
        /// </summary>
        /// <param name="currentType">The type information that currently being processed.</param>
        /// <param name="constructor">The constructor information.</param>
        /// <param name="displayFormat">The display format string.</param>
        /// <param name="anchorFormat">The anchor format string.</param>
        /// <returns>リンク</returns>
        string FormatToLink(TypeWithComment currentType, ConstructorInfoWithComment constructor, string? displayFormat = null, string? anchorFormat = null);

        /// <summary>
        /// Formats the specified constructor into an anchor text.
        /// </summary>
        /// <param name="constructor">The constructor information.</param>
        /// <param name="anchorFormat">The format string.</param>
        /// <returns>The formatted anchor text.</returns>
        string FormatToAnchor(ConstructorInfoWithComment constructor, string? anchorFormat = null);

        #endregion

        #region method

        /// <summary>
        /// Formats the specified method into a human-readable signature.
        /// </summary>
        /// <param name="method">The method information.</param>
        /// <returns>The formatted signature.</returns>
        string FormatToReadableSignature(MethodInfoWithComment method);

        /// <summary>
        /// Formats the specified method into a link text.
        /// </summary>
        /// <param name="currentType">The type information that currently being processed.</param>
        /// <param name="method">The method information.</param>
        /// <param name="displayFormat">The display format string.</param>
        /// <param name="anchorFormat">The anchor format string.</param>
        /// <returns>The formatted link.</returns>
        string FormatToLink(TypeWithComment currentType, MethodInfoWithComment method, string? displayFormat = null, string? anchorFormat = null);

        /// <summary>
        /// Formats the specified method into an anchor text.
        /// </summary>
        /// <param name="method">The method information.</param>
        /// <param name="anchorFormat">The format string.</param>
        /// <returns>The formatted anchor text.</returns>
        string FormatToAnchor(MethodInfoWithComment method, string? anchorFormat = null);

        #endregion

        #region property

        /// <summary>
        /// Formats the specified property into a human-readable signature.
        /// </summary>
        /// <param name="property">The property information.</param>
        /// <returns>The formatted signature.</returns>
        string FormatToReadableSignature(PropertyInfoWithComment property);

        /// <summary>
        /// Formats the specified property into a link text.
        /// </summary>
        /// <param name="currentType">The type information that currently being processed.</param>
        /// <param name="property">The property information.</param>
        /// <param name="displayFormat">The display format string.</param>
        /// <param name="anchorFormat">The anchor format string.</param>
        /// <returns>The formatted link.</returns>
        string FormatToLink(TypeWithComment currentType, PropertyInfoWithComment property, string? displayFormat = null, string? anchorFormat = null);

        /// <summary>
        /// Formats the specified property into an anchor text.
        /// </summary>
        /// <param name="property">The property information.</param>
        /// <param name="anchorFormat">The format string.</param>
        /// <returns>The formatted anchor text.</returns>
        string FormatToAnchor(PropertyInfoWithComment property, string? anchorFormat = null);

        #endregion

        #region field

        /// <summary>
        /// Formats the specified field into a link text.
        /// </summary>
        /// <param name="currentType">The type information that currently being processed.</param>
        /// <param name="field">The field information.</param>
        /// <param name="displayFormat">The display format string.</param>
        /// <param name="anchorFormat">The anchor format string.</param>
        /// <returns>The formatted link.</returns>
        string FormatToLink(TypeWithComment currentType, FieldInfoWithComment field, string? displayFormat = null, string? anchorFormat = null);

        /// <summary>
        /// Formats the specified field into an anchor text.
        /// </summary>
        /// <param name="field">The field information.</param>
        /// <param name="anchorFormat">The format string.</param>
        /// <returns>The formatted anchor text.</returns>
        string FormatToAnchor(FieldInfoWithComment field, string? anchorFormat = null);

        #endregion

        #region event

        /// <summary>
        /// Formats the specified event into a link text.
        /// </summary>
        /// <param name="currentType">The type information that currently being processed.</param>
        /// <param name="evt">The event information.</param>
        /// <param name="displayFormat">The display format string.</param>
        /// <param name="anchorFormat">The anchor format string.</param>
        /// <returns>The formatted link.</returns>
        string FormatToLink(TypeWithComment currentType, EventInfoWithComment evt, string? displayFormat = null, string? anchorFormat = null);

        /// <summary>
        /// Formats the specified event into an anchor text.
        /// </summary>
        /// <param name="evt">The event information.</param>
        /// <param name="anchorFormat">The format string.</param>
        /// <returns>The formatted anchor text.</returns>
        string FormatToAnchor(EventInfoWithComment evt, string? anchorFormat = null);

        #endregion

        #region text

        /// <summary>
        /// Replaces the reference tag contained in the specified text with the link.
        /// </summary>
        /// <param name="currentType">The type information that currently being processed.</param>
        /// <param name="text">The text.</param>
        /// <returns>The replaced text.</returns>
        string ReplaceReferenceTag(TypeWithComment currentType, string text);

        #endregion

    }

}

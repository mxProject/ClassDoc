using System;
using System.Collections.Generic;
using System.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Provides the functionality required to output a class document.
    /// </summary>
    public interface IClassDocumentWriter
    {

        /// <summary>
        /// Outputs the information of the specified namespace to the document.
        /// </summary>
        /// <param name="nameSpace">The namespace information.</param>
        /// <param name="formatter">The formatter.</param>
        void WriteNamespaceDocument(NamespaceInfo nameSpace, IClassDocumentFormatter formatter);

        /// <summary>
        /// Outputs the information of the specified type to the document.
        /// </summary>
        /// <param name="type">The type information.</param>
        /// <param name="formatter">The formatter.</param>
        void WriteTypeDocument(TypeWithComment type, IClassDocumentFormatter formatter);

    }

}

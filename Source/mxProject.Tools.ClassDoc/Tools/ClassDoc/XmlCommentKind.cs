using System;
using System.Collections.Generic;
using System.Text;

namespace mxProject.Tools.ClassDoc
{

    /// <summary>
    /// Kind of XML comment signature.
    /// </summary>
    public enum XmlCommentKind
    {

        /// <summary>
        /// unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Type.
        /// </summary>
        Type = 'T',

        /// <summary>
        /// Field.
        /// </summary>
        Field = 'F',

        /// <summary>
        /// Property.
        /// </summary>
        Property = 'P',

        /// <summary>
        /// Method.
        /// </summary>
        Method = 'M',

        /// <summary>
        /// Event.
        /// </summary>
        Event = 'E',

    }

}

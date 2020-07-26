using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Sample flag.
    /// </summary>
    [Flags]
    public enum SampleFlag
    {

        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Left.
        /// </summary>
        Left = 1,

        /// <summary>
        /// Right.
        /// </summary>
        Right = 2,

        /// <summary>
        /// Center.
        /// </summary>
        Center = 4,

        /// <summary>
        /// Left or Right.
        /// </summary>
        LeftRight = Left | Right,

        /// <summary>
        /// Left or Right or Center.
        /// </summary>
        All = Left | Right | Center,

    }

}

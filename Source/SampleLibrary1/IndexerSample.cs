using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Indexer sample.
    /// </summary>
    public class IndexerSample
    {

        /// <summary>
        /// An indexer that takes an integer value as an argument.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public byte this[int index]
        {
            get { return default; }
            set { }
        }

        /// <summary>
        /// An indexer that takes a string value as an argument.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public byte this[string name]
        {
            get { return default; }
            set { }
        }

        /// <summary>
        /// An indexer that takes x and y coordinates as arguments
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        /// <returns></returns>
        public byte this[int x, int y]
        {
            get { return default; }
            set { }
        }

        /// <summary>
        /// An indexer that takes a tuple as arguments
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <returns></returns>
        public byte this[(int x, int y) coordinates]
        {
            get { return default; }
            set { }
        }

    }

}

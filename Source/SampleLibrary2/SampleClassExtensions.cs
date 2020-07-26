using SampleLibrary;
using System;

namespace SampleLibrary
{

    /// <summary>
    /// Extension methods for <see cref="SampleClass"/>.
    /// </summary>
    public static class SampleClassExtensions
    {

        /// <summary>
        /// An extension action.
        /// </summary>
        /// <param name="sample">The instance.</param>
        /// <param name="arg1">1st argument.</param>
        /// <param name="arg2">2nd argument.</param>
        public static void ExtensionAction(this SampleClass sample, bool arg1, DateTime arg2)
        {
        }

        /// <summary>
        /// An extension action.
        /// </summary>
        /// <param name="sample">The instance.</param>
        /// <param name="arg1">1st argument.</param>
        /// <param name="arg2">2nd argument.</param>
        /// <returns>A return value.</returns>
        public static bool ExtensionFunc(this SampleClass sample, bool arg1, DateTime arg2)
        {
            return default;
        }

    }

}

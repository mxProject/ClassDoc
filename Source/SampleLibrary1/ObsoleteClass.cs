using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Obsolete class.
    /// </summary>
    [Obsolete]
    public class ObsoleteClass
    {

        /// <summary>
        /// An obsolete constructor.
        /// </summary>
        [Obsolete]
        public ObsoleteClass()
        {
        }

        /// <summary>
        /// An obsolete property.
        /// </summary>
        [Obsolete]
        public bool ObsoleteProperty { get; set; }

        /// <summary>
        /// An obsolete field.
        /// </summary>
        [Obsolete]
        public byte ObsoleteField = 0;

        /// <summary>
        /// An obsolete method.
        /// </summary>
        [Obsolete]
        public void ObsoleteAction() { }

        /// <summary>
        /// An obsolete event.
        /// </summary>
        [Obsolete]
        public event EventHandler ObsoleteEvent;



        /// <summary>
        /// An obsolete static property.
        /// </summary>
        [Obsolete]
        public static bool ObsoleteStaticProperty { get; set; }

        /// <summary>
        /// An obsolete static field.
        /// </summary>
        [Obsolete]
        public static byte ObsoleteStaticField = 0;

        /// <summary>
        /// An obsolete static method.
        /// </summary>
        [Obsolete]
        public static void ObsoleteStaticAction() { }

        /// <summary>
        /// An obsolete static event.
        /// </summary>
        [Obsolete]
        public static event EventHandler ObsoleteStaticEvent;

    }

}

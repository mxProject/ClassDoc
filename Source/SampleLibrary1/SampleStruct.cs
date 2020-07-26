using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Sample structure.
    /// </summary>
    public struct SampleStruct : ISample
    {

        /// <summary>
        /// ctor.
        /// </summary>
        public SampleStruct(byte value)
        {
            Property = value;
            Field = default;
            ReadonlyField = default;
        }

        #region method

        /// <summary>
        /// action.
        /// </summary>
        /// <param name="arg">argument.</param>
        public void Action(byte arg) { }

        /// <summary>
        /// static action.
        /// </summary>
        /// <param name="sample">sample instance.</param>
        public static void StaticAction(SampleStruct sample) { }

        #endregion

        #region property

        /// <summary>
        /// property.
        /// </summary>
        public byte Property { get; set; }

        /// <summary>
        /// static property.
        /// </summary>
        public static int StaticProperty { get; } = 0;

        #endregion

        #region field

        /// <summary>
        /// field.
        /// </summary>
        public byte Field;

        /// <summary>
        /// readonly field.
        /// </summary>
        public readonly short ReadonlyField;

        /// <summary>
        /// static field.
        /// </summary>
        public static int StaticField = 0;

        /// <summary>
        /// static reaonly field.
        /// </summary>
        public static readonly long StaticReadonlyField = 0;

        #endregion

        #region ISample implementation

        /// <inheritdoc/>
        int ISample.InterfaceProperty
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        /// <inheritdoc/>
        void ISample.InterfaceAction(int arg)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        event EventHandler ISample.InterfaceEvent
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        #endregion

    }

}

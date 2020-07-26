using System;
using System.Collections.Generic;
using System.Text;

#pragma warning disable IDE0044
#pragma warning disable IDE0051

namespace SampleLibrary
{

    /// <summary>
    /// Sample class.
    /// </summary>
    public abstract class SampleClass : ISample
    {

        /// <summary>
        /// ctor.
        /// </summary>
        protected SampleClass()
        {
        }

        #region method

        /// <summary>
        /// A sealed action.
        /// </summary>
        /// <param name="arg">argument.</param>
        public void Action(byte arg) { }

        /// <summary>
        /// A virtual action.
        /// </summary>
        /// <param name="arg">argument.</param>
        public virtual void VirtualAction(short arg) { }

        /// <summary>
        /// An abstract action.
        /// </summary>
        /// <param name="arg">argument.</param>
        public abstract void AbstractAction(int arg);

        /// <summary>
        /// A private action.
        /// </summary>
        /// <param name="arg">argument.</param>
        private void PrivateAction(long arg) { }

        /// <summary>
        /// A static action.
        /// </summary>
        /// <param name="sample">sample instance.</param>
        public static void StaticAction(SampleClass sample) { }

        #endregion

        #region property

        /// <summary>
        /// A sealed property.
        /// </summary>
        public byte Property { get; set; }

        /// <summary>
        /// A virtual property.
        /// </summary>
        public virtual short VirtualProperty { get; set; }

        /// <summary>
        /// An abstract property.
        /// </summary>
        public abstract int AbstractProperty { get; set; }

        /// <summary>
        /// A private property.
        /// </summary>
        private long PrivateProperty { get; set; }

        /// <summary>
        /// A static property.
        /// </summary>
        public static int StaticProperty { get; } = 0;

        #endregion

        #region event

        /// <summary>
        /// A sealed event.
        /// </summary>
        public event EventHandler Event;

        /// <summary>
        /// A virtual event.
        /// </summary>
        public virtual event EventHandler VirtualEvent;

        /// <summary>
        /// An abstract event.
        /// </summary>
        public abstract event EventHandler AbstractEvent;

        /// <summary>
        /// A private event.
        /// </summary>
        private event EventHandler PrivateEvent;

        /// <summary>
        /// A static event.
        /// </summary>
        public static event EventHandler StaticEvent;

        #endregion

        #region field

        /// <summary>
        /// A field.
        /// </summary>
        public bool Field;

        /// <summary>
        /// A private field.
        /// </summary>
        private byte PrivateField;

        /// <summary>
        /// A readonly field.
        /// </summary>
        public readonly short ReadonlyField = 0;

        /// <summary>
        /// A static field.
        /// </summary>
        public static int StaticField = 0;

        /// <summary>
        /// A static reaonly field.
        /// </summary>
        public static readonly long StaticReadonlyField = 0;

        #endregion

        #region ISample implementation

        /// <inheritdoc/>
        int ISample.InterfaceProperty {
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

#pragma warning restore IDE0044
#pragma warning restore IDE0051

using System;

#pragma warning disable IDE0044
#pragma warning disable IDE0051

namespace SampleLibrary
{

    /// <summary>
    /// internal class.
    /// </summary>
    internal class InternalClass
    {

        #region ctor

        /// <summary>
        /// A private constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        private InternalClass(bool arg)
        {
        }

        /// <summary>
        /// A protected constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        protected InternalClass(byte arg)
        {
        }

        /// <summary>
        /// A protected internal constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        protected internal InternalClass(short arg)
        {
        }

        /// <summary>
        /// An internal constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        internal InternalClass(int arg)
        {
        }

        /// <summary>
        /// A public constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        public InternalClass(long arg)
        {
        }

        #endregion

        #region property

        /// <summary>
        /// A private property.
        /// </summary>
        private bool PrivateProperty { get; set; }

        /// <summary>
        /// A protected property.
        /// </summary>
        protected byte ProtectedProperty { get; set; }

        /// <summary>
        /// A protected internal property.
        /// </summary>
        protected internal short ProtectedInternalProperty { get; set; }

        /// <summary>
        /// An internal property.
        /// </summary>
        internal int InternalProperty { get; set; }

        /// <summary>
        /// A public property.
        /// </summary>
        public long PublicProperty { get; set; }

        #endregion

        #region field

        /// <summary>
        /// A private field.
        /// </summary>
        private bool PrivateField;

        /// <summary>
        /// A protected field.
        /// </summary>
        protected byte ProtectedField;

        /// <summary>
        /// A protected internal field.
        /// </summary>
        protected internal short ProtectedInternalField;

        /// <summary>
        /// An internal field.
        /// </summary>
        internal int InternalField;

        /// <summary>
        /// A public field.
        /// </summary>
        public long PublicField;

        #endregion

        #region event

        /// <summary>
        /// A private event.
        /// </summary>
        private event EventHandler PrivateEvent;

        /// <summary>
        /// A protected event.
        /// </summary>
        protected event EventHandler ProtectedEvent;

        /// <summary>
        /// A protected internal event.
        /// </summary>
        protected internal event EventHandler ProtectedInternalEvent;

        /// <summary>
        /// An internal event.
        /// </summary>
        internal event EventHandler InternalEvent;

        /// <summary>
        /// A public event.
        /// </summary>
        public event EventHandler PublicEvent;

        #endregion

        #region method

        /// <summary>
        /// A private method.
        /// </summary>
        /// <param name="arg">arguments.</param>
        private void PrivateMethod(bool arg) { }

        /// <summary>
        /// A protected method.
        /// </summary>
        /// <param name="arg">arguments.</param>
        protected void ProtectedMethod(byte arg) { }

        /// <summary>
        /// A protected internal method.
        /// </summary>
        /// <param name="arg">arguments.</param>
        protected internal void ProtectedInternalMethod(short arg) { }

        /// <summary>
        /// An internal method.
        /// </summary>
        /// <param name="arg">arguments.</param>
        internal void InternalMethod(int arg) { }

        /// <summary>
        /// A public method.
        /// </summary>
        /// <param name="arg">arguments.</param>
        public void PublicMethod(long arg) { }

        #endregion

        #region nested type

        /// <summary>
        /// A private nested class.
        /// </summary>
        private class PrivateNestedClass
        {
            /// <summary>
            /// ctor.
            /// </summary>
            public PrivateNestedClass() { }
        }

        /// <summary>
        /// A protected nested class.
        /// </summary>
        protected class ProtectedNestedClass
        {
            /// <summary>
            /// ctor.
            /// </summary>
            public ProtectedNestedClass() { }
        }

        /// <summary>
        /// A protected internal nested class.
        /// </summary>
        protected internal class ProtectedInternalNestedClass
        {
            /// <summary>
            /// ctor.
            /// </summary>
            public ProtectedInternalNestedClass() { }
        }

        /// <summary>
        /// An internal nested class.
        /// </summary>
        internal class InternalNestedClass
        {
            /// <summary>
            /// ctor.
            /// </summary>
            public InternalNestedClass() { }
        }

        /// <summary>
        /// A public nested class.
        /// </summary>
        public class PublicNestedClass
        {
            /// <summary>
            /// ctor.
            /// </summary>
            public PublicNestedClass() { }
        }

        #endregion

    }

}

#pragma warning restore IDE0044
#pragma warning restore IDE0051

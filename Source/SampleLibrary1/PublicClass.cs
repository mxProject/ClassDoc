using System;

namespace SampleLibrary
{

    /// <summary>
    /// public class.
    /// </summary>
    public class PublicClass
    {

        #region ctor

        /// <summary>
        /// private constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        private PublicClass(bool arg)
        {
        }

        /// <summary>
        /// protected constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        protected PublicClass(byte arg)
        {
        }

        /// <summary>
        /// protected internal constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        protected internal PublicClass(short arg)
        {
        }

        /// <summary>
        /// internal constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        internal PublicClass(int arg)
        {
        }

        /// <summary>
        /// public constructor.
        /// </summary>
        /// <param name="arg">argument.</param>
        public PublicClass(long arg)
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

        /// <summary>
        /// A property whose setter scope is private.
        /// </summary>
        public float PrivateSetterProperty { get; private set; }

        /// <summary>
        /// A property whose getter scope is private.
        /// </summary>
        public float PrivateGetterProperty { private get; set; }

        /// <summary>
        /// A property whose setter scope is protected.
        /// </summary>
        public float ProtectedSetterProperty { get; protected set; }

        /// <summary>
        /// A property whose getter scope is protected.
        /// </summary>
        public float ProtectedGetterProperty { protected get; set; }

        /// <summary>
        /// A property whose setter scope is internal.
        /// </summary>
        public float InternalSetterProperty { get; internal set; }

        /// <summary>
        /// A property whose getter scope is internal.
        /// </summary>
        public float InternalGetterProperty { internal get; set; }

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

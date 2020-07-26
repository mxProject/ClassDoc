using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Sub class of <see cref="SampleClass"/>.
    /// </summary>
    public class SampleSubClass : SampleClass
    {

        /// <summary>
        /// ctor.
        /// </summary>
        public SampleSubClass() : base()
        {
        }

        #region method

        /// <summary>
        /// A new action.
        /// </summary>
        /// <param name="arg">argument.</param>
        public new void Action(byte arg) { }

        /// <inheritdoc/>
        public override void VirtualAction(short arg) { }

        /// <summary>
        /// An override action.
        /// </summary>
        /// <param name="arg">argument.</param>
        public override void AbstractAction(int arg) { }

        /// <summary>
        /// An action declared in <see cref="SampleSubClass"/>.
        /// </summary>
        /// <param name="arg">argument.</param>
        public void SubClassAction(long arg) { }

        #endregion

        #region property

        /// <summary>
        /// A new property.
        /// </summary>
        public new byte Property { get; set; }

        /// <inheritdoc/>
        public override short VirtualProperty { get; set; }

        /// <summary>
        /// An override property.
        /// </summary>
        public override int AbstractProperty { get; set; }

        /// <summary>
        /// A property declared in <see cref="SampleSubClass"/>.
        /// </summary>
        public long SubClassProperty { get; set; }

        #endregion

        #region event

        /// <summary>
        /// A new event.
        /// </summary>
        public new event EventHandler Event;

        /// <inheritdoc/>
        public override event EventHandler VirtualEvent;

        /// <summary>
        /// An override event.
        /// </summary>
        public override event EventHandler AbstractEvent;

        /// <summary>
        /// An event declared in <see cref="SampleSubClass"/>.
        /// </summary>
        public event EventHandler SubClassEvent;

        #endregion

        #region field

        /// <summary>
        /// A field declared in <see cref="SampleSubClass"/>.
        /// </summary>
        public string SubClassField;

        #endregion

    }

}

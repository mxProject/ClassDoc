using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Sub class of <see cref="SampleSubClass"/>.
    /// </summary>
    public class SampleSubSubClass : SampleSubClass
    {

        /// <summary>
        /// ctor.
        /// </summary>
        public SampleSubSubClass() : base()
        {
        }

        #region method

        /// <summary>
        /// An action declared in <see cref="SampleSubSubClass"/>.
        /// </summary>
        /// <param name="arg">argument.</param>
        public void SubSubClassAction(long arg) { }

        #endregion

        #region property

        /// <summary>
        /// A property declared in <see cref="SampleSubSubClass"/>.
        /// </summary>
        public long SubSubClassProperty { get; set; }

        #endregion

        #region event

        /// <summary>
        /// An event declared in <see cref="SampleSubSubClass"/>.
        /// </summary>
        public event EventHandler SubSubClassEvent;

        #endregion

        #region field

        /// <summary>
        /// A field declared in <see cref="SampleSubSubClass"/>.
        /// </summary>
        public string SubSubClassField;

        #endregion

    }

}

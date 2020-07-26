using System;
using System.Collections.Generic;
using System.Text;

namespace SampleLibrary
{

    /// <summary>
    /// Sample interface.
    /// </summary>
    public interface ISample
    {

        /// <summary>
        /// An interface property.
        /// </summary>
        int InterfaceProperty { get; set; }

        /// <summary>
        /// An interface action.
        /// </summary>
        /// <param name="arg"></param>
        void InterfaceAction(int arg);

        /// <summary>
        /// An interface event.
        /// </summary>
        event EventHandler InterfaceEvent;

    }

}

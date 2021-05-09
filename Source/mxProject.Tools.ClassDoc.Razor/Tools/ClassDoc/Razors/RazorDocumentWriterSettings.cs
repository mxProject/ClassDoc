using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mxProject.Tools.ClassDoc.Razors
{

    /// <summary>
    /// 
    /// </summary>
    public class RazorDocumentWriterSettings
    {

        /// <summary>
        /// Gets or sets the path of the root directory of the output destination.
        /// </summary>
        public string RootDirectory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RazorDocumentSettings<NamespaceInfo> NamespaceDodumentSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RazorDocumentSettings<TypeWithComment> TypeDodumentSettings { get; set; }

    }

}

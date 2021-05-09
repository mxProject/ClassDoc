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
    /// <typeparam name="T"></typeparam>
    public class RazorDocumentSettings<T>
    {

        /// <summary>
        /// 
        /// </summary>
        public Encoding Encoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public IClassDocumentFormatter DocumentFormatter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Func<T, string> FileNameFormatter { get; set; }

    }

}

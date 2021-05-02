using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Dtos
{
    /// <summary>
    /// Represent the data transfer object of document.
    /// </summary>
    public class DocumentDto
    {
        /// <summary>
        /// Document title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Document description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Document string.
        /// </summary>
        public string DocumentString { get; set; }
        /// <summary>
        /// Document status to know is avalible.
        /// </summary>
        public bool Status { get; set; }
    }
}

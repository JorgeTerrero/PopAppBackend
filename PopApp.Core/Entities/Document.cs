using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent document entity.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Document primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }
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

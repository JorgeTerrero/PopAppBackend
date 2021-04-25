using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent freight entity.
    /// </summary>
    public class Freight
    {
        /// <summary>
        /// Freight primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Freight code.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Freight description .
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Freight type.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Freight weight.
        /// </summary>
        public decimal? Weight { get; set; }
        /// <summary>
        /// Freight status to know is avalible.
        /// </summary>
        public bool Status { get; set; }
    }
}

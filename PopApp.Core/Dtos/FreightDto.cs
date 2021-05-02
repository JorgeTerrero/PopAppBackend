using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Dtos
{
    /// <summary>
    /// Represent the data transfer object of freight.
    /// </summary>
    public class FreightDto
    {
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

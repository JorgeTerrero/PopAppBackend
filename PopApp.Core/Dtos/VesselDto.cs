using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Dtos
{
    /// <summary>
    /// Represent the data transfer object of vessel.
    /// </summary>
    public class VesselDto
    {
        /// <summary>
        /// Vessel's name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Vessel Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Vessel Imo
        /// </summary>
        public string Imo { get; set; }
        /// <summary>
        /// Vessel Flag.
        /// </summary>
        public string Flag { get; set; }
        /// <summary>
        /// Vessel slora.
        /// </summary>
        public string Slora { get; set; }
        /// <summary>
        /// Vessel arrival.
        /// </summary>
        public string Arrival { get; set; }
        /// <summary>
        /// Vessel status to know is avalible.
        /// </summary>
        public bool Status { get; set; }
    }
}

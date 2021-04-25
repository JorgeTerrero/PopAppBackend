using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities
{
    public class Vessel
    {
        /// <summary>
        /// // Primary key of Vessel.
        /// </summary>
        [Key]
        public int Id { get; set; }
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
        /// Vessel Arrival.
        /// </summary>
        public string Arrival { get; set; }
        /// <summary>
        /// Vessel Status
        /// </summary>
        public bool Status { get; set; }
    }
}

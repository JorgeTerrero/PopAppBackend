using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent Vessel entity.
    /// </summary>
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
        public decimal? Slora { get; set; }
        /// <summary>
        /// Vessel arrival.
        /// </summary>
        public string Arrival { get; set; }
        /// <summary>
        /// Is Active to know is avalible.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

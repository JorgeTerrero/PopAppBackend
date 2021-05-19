using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of freight.
    /// </summary>
    [Table("Schedule_freight")]
    public class ScheduleFreight
    {
        /// <summary>
        /// schedule freight id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set freight id.
        /// </summary>
        public int FreightId { get; set; }
        /// <summary>
        /// Get or set schedule container id
        /// </summary>
        public int ContainerId { get; set; }
        /// <summary>
        /// Get or set quantity.
        /// </summary>
        public decimal? Quantity { get; set; }
        /// <summary>
        /// Get or set createdAt date.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}

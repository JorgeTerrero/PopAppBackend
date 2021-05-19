using PopApp.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of vessel.
    /// </summary>
    [Table("Schedule_vessel")]
    public class ScheduleVessel
    {
        /// <summary>
        /// Schedule vessel id
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set schedule id.
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// Get or set vessel id.
        /// </summary>
        public int VesselId { get; set; }
        /// <summary>
        /// Get or set vessel status
        /// </summary>
        public VesselStatus VesselStatus { get; set; }
        /// <summary>
        /// Get or set createdAt date.
        /// </summary>
        public DateTime CreateAt { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of freight.
    /// </summary>
    public class ScheduleFreight
    {
        /// <summary>
        /// schedule freight id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set schedule id.
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// Get or set schedule container id
        /// </summary>
        public int ContainerId { get; set; }
        /// <summary>
        /// Get or set createdAt date.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}

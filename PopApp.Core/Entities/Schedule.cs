using System;
using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent schedule entity.
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Schedule id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set schedule date.
        /// </summary>
        public DateTime ScheduleDate { get; set; }
        /// <summary>
        /// Is active to know is avalible.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

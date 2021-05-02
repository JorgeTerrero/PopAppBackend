using PopApp.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of container.
    /// </summary>
    public class ScheduleContainer
    {
        /// <summary>
        /// schedule container id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set schedule id.
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// Get or set schedule company id.
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// Get or set schedule freight id.
        /// </summary>
        public int FreightId { get; set; }
        /// <summary>
        /// Get or set  container status.
        /// </summary>
        public ContainerStatus Status { get; set; }
        /// <summary>
        /// Get or set createdAt date.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}

using PopApp.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of container.
    /// </summary>
    [Table("Schedule_container")]
    public class ScheduleContainer
    {
        /// <summary>
        /// schedule container id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set vessel id.
        /// </summary>
        public int VesselId { get; set; }
        /// <summary>
        /// Get or set container id.
        /// </summary>
        public int ContainerId { get; set; }
        /// <summary>
        /// Get or set schedule company id.
        /// </summary>
        public int CompanyId { get; set; }
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

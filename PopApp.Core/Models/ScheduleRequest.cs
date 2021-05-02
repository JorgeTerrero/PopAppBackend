using System.Collections.Generic;

namespace PopApp.Core.Models
{
    public sealed class ScheduleRequest
    {
        /// <summary>
        /// Get or set vessel id.
        /// </summary>
        public int VesselId { get; set; }
        /// <summary>
        /// Get or set container id.
        /// </summary>
        public int ContainerId { get; set; }
        /// <summary>
        /// Get or set freight id.
        /// </summary>
        public int FreightId { get; set; }
        /// <summary>
        /// Get or set company id.
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// Get or set a List of product schedule model.
        /// </summary>
        public IList<ProductScheduleModel> Products { get; set; }
    }
}

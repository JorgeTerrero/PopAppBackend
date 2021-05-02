using System;
using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of product.
    /// </summary>
    public class ScheduleProduct
    {
        /// <summary>
        /// Schedule product id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set schedule id.
        /// </summary>
        public int ScheduleId { get; set; }
        /// <summary>
        /// Get or set product schedule id.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Get or set freight schedule id.
        /// </summary>
        public int freightId { get; set; }
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

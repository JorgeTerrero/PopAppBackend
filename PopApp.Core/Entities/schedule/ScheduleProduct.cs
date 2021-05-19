using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PopApp.Core.Entities.schedule
{
    /// <summary>
    /// Represen the schedule of product.
    /// </summary>
    [Table("Schedule_product")]
    public class ScheduleProduct
    {
        /// <summary>
        /// Schedule product id.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Get or set product schedule id.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Get or set freight schedule id.
        /// </summary>
        public int freightId { get; set; }
        /// <summary>
        /// Get or set createdAt date.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}

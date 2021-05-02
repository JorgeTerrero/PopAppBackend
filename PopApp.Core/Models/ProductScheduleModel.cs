using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Models
{
    /// <summary>
    /// Represent product schedule model.
    /// </summary>
    public class ProductScheduleModel
    {
        /// <summary>
        /// Get or set product id.
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Get or set quantity.
        /// </summary>
        public decimal? Quantity { get; set; }
    }
}

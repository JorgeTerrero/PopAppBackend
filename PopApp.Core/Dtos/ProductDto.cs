using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Dtos
{
    /// <summary>
    /// Represent the data transfer object of product.
    /// </summary>
    public class ProductDto
    {
        /// <summary>
        /// Product name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Product Description
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Product category.
        /// </summary>
        public string Category { get; set; }
        /// <summary>
        /// Type of container where the product can go 
        /// </summary>
        public string ContainerType { get; set; }
        /// <summary>
        /// Product status to know is avalible.
        /// </summary>
        public bool Status { get; set; }
    }
}

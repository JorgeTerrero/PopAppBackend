using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent product entity.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }
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
        public int ContainerType { get; set; }
        /// <summary>
        /// Is active to know is avalible.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

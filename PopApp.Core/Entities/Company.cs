using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent Company Entity.
    /// </summary>
    public class Company
    {
        /// <summary>
        /// Company primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Company name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Company code.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Company Adress.
        /// </summary>
        public string Adress { get; set; }
        /// <summary>
        /// Company Phone.
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// Company status to know is avalible.
        /// </summary>
        public bool Status { get; set; }
    }
}

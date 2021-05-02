using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Dtos
{
    /// <summary>
    /// Represent the data transfer object of company.
    /// </summary>
    public class CompanyDto
    {
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

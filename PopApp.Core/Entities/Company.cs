using System.ComponentModel.DataAnnotations;

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
        /// Is active to know is avalible.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

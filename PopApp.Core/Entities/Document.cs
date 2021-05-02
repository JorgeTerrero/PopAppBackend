using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent document entity.
    /// </summary>
    public class Document
    {
        /// <summary>
        /// Document primary key.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Document title.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Document description.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Document string.
        /// </summary>
        public string DocumentString { get; set; }
        /// <summary>
        /// Is active to know is avalible.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

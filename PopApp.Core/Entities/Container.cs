using System.ComponentModel.DataAnnotations;

namespace PopApp.Core.Entities
{
    /// <summary>
    /// Represent container entity.
    /// </summary>
    public class Container
    {
        /// <summary>
        /// Container primary Key.
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Container type.
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Container payload.
        /// </summary>
        public decimal? Payload { get; set; }
        /// <summary>
        /// Container capacity.
        /// </summary>
        public decimal? Capacity { get; set; }
        /// <summary>
        /// Container lenght.
        /// </summary>
        public decimal? Lenght { get; set; }
        /// <summary>
        /// Container width.
        /// </summary>
        public decimal? Width { get; set; }
        /// <summary>
        /// Container height.
        /// </summary>
        public decimal? Height { get; set; }
        /// <summary>
        /// Is active to know is avalible.
        /// </summary>
        public bool IsActive { get; set; }
    }
}

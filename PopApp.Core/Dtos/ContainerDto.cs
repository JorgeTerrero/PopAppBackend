using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Core.Dtos
{
    /// <summary>
    /// Represent the data transfer object of container.
    /// </summary>
    public class ContainerDto
    {
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
        /// Container status to know is avalible.
        /// </summary>
        public bool Status { get; set; }
    }
}

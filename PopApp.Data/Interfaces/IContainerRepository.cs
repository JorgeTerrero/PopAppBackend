using PopApp.Core.Entities;
using System.Collections.Generic;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent container repository.
    /// </summary>
    public interface IContainerRepository
    {
        /// <summary>
        /// Get all container of container entity.
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List of container</returns>
        IEnumerable<Container> GetAllContainer(bool trackChange);
        /// <summary>
        /// Get container of container entity.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns>a container</returns>
        Container GetContainer(int id, bool trackChange);
        /// <summary>
        /// Create a container.
        /// </summary>
        /// <param name="container"></param>
        void CreateContainer(Container container);
        /// <summary>
        /// Update container.
        /// </summary>
        /// <param name="container"></param>
        void UpdateContainer(Container container);
    }
}

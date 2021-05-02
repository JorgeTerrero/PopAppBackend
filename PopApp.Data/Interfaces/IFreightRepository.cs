using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent freight repository.
    /// </summary>
    public interface IFreightRepository
    {
        /// <summary>
        /// Get all freights of freight entity.
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List of freight</returns>
        IEnumerable<Freight> GetAllFreights(bool trackChange);
        /// <summary>
        /// Get freight of freight entity.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns>A freight</returns>
        Freight GetFreight(int id, bool trackChange);
        /// <summary>
        /// Create a freight.
        /// </summary>
        /// <param name="freight"></param>
        void CreateFreight(Freight freight);
        /// <summary>
        /// Update a freight.
        /// </summary>
        /// <param name="freight"></param>
        void UpdateFreight(Freight freight);
    }
}

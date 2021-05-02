using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent vessel repository.
    /// </summary>
    public interface IVesselRepository
    {
        /// <summary>
        /// Get all vessels.
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List of vessels</returns>
        IEnumerable<Vessel> GetAllVessel(bool trackChange);
        /// <summary>
        /// Get vessel.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns>A vessel</returns>
        Vessel GetVessel(int id, bool trackChange);
        /// <summary>
        /// Create vessel.
        /// </summary>
        /// <param name="vessel"></param>
        void CreateVessel(Vessel vessel);
        /// <summary>
        /// Update vessel.
        /// </summary>
        /// <param name="vessel"></param>
        void UpdateVessel(Vessel vessel);
    }
}

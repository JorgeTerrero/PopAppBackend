using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent vessel repository.
    /// </summary>
    public class VesselRepository : PopAppRepositoryBase<Vessel> , IVesselRepository
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public VesselRepository(PopAppContext popAppContext) : base(popAppContext) { }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateVessel(Vessel vessel)
        {
            if (vessel is null) throw new Exception("_vessel was'nt setting");
            Create(vessel);
        }

        ///<inheritdoc/>
        public IEnumerable<Vessel> GetAllVessel(bool trackChange)
        {
            var vessels = FindByCondition(vessels => vessels.IsActive == true , trackChange).ToList();
            if (vessels is null) throw new Exception("there no are any vessel avalible");
            return vessels;
        }

        ///<inheritdoc/>
        public Vessel GetVessel(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("Indentifier Invalid");
            var vessel = FindByCondition(vessel => vessel.Id == id, trackChange).FirstOrDefault();
            if (vessel is null) throw new Exception("_vessel Invalid");
            return vessel;
        }

        ///<inheritdoc/>
        public void UpdateVessel(Vessel vessel)
        {
            if (vessel is null) throw new Exception("_vessel was'nt setting");
            Update(vessel);
        }
        #endregion
    }
}

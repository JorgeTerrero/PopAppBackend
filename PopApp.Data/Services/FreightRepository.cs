using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent freight repository.
    /// </summary>
    public class FreightRepository : PopAppRepositoryBase<Freight> , IFreightRepository
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public FreightRepository(PopAppContext popAppContext) : base(popAppContext) { }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateFreight(Freight freight)
        {
            if (freight is null) throw new Exception("_freight wasn't setting");
            Create(freight);
        }

        ///<inheritdoc/>
        public IEnumerable<Freight> GetAllFreights(bool trackChange)
        {
            var freights = FindByCondition(freight => freight.IsActive == true, trackChange).ToList();
            if (freights is null) throw new Exception("There no are Freights active");
            return freights;
        }

        ///<inheritdoc/>
        public Freight GetFreight(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("_freight identifier invalid");
            var freight = FindByCondition(f => f.Id == id , trackChange).FirstOrDefault();
            if (freight is null) throw new Exception("_freight invalid");
            return freight;
        }

        ///<inheritdoc/>
        public void UpdateFreight(Freight freight)
        {
            if (freight is null) throw new Exception("_freight wasn't setting");
            Update(freight);
        }
        #endregion
    }
}

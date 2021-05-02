using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent container repository.
    /// </summary>
    public class ContainerRepository : PopAppRepositoryBase<Container> , IContainerRepository
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public ContainerRepository(PopAppContext popAppContext) : base(popAppContext) { }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateContainer(Container container)
        {
            if (container is null) throw new Exception("_container wasn't setting");
            Create(container);
        }

        ///<inheritdoc/>
        public IEnumerable<Container> GetAllContainer(bool trackChange)
        {
            var containers = FindByCondition(container => container.IsActive == true, trackChange).ToList();
            if (containers is null) throw new Exception("There no are container active");
            return containers;
        }

        ///<inheritdoc/>
        public Container GetContainer(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("_container identifier invalid");
            var container = FindByCondition(c => c.Id == id, trackChange).FirstOrDefault();
            if (container is null) throw new Exception("_container invalid");
            return container;
        }

        ///<inheritdoc/>
        public void UpdateContainer(Container container)
        {
            if (container is null) throw new Exception("_container wasn't setting");
            Update(container);
        }
        #endregion
    }
}

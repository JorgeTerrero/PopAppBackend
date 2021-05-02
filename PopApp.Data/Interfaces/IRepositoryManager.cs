using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent  repository manager.
    /// </summary>
    public interface IRepositoryManager
    {
        ICompanyRepository Company { get; }
        IContainerRepository Container { get; }
        IDocumentRepository Document { get; }
        IFreightRepository Freight { get; }
        IProductRepository Product { get; }
        IVesselRepository Vessel { get; }
        IScheduleRepository Schedule { get; }
        void Save();
    }
}

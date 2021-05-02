using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Services
{
    public class RepositoryManager : IRepositoryManager
    {
        #region Fields
        private PopAppContext _popAppContext;
        private ICompanyRepository _company;
        private IContainerRepository _container;
        private IDocumentRepository _document;
        private IFreightRepository _freight;
        private IProductRepository _product;
        private IVesselRepository _vessel;
        private IScheduleRepository _schedule;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public RepositoryManager(PopAppContext popAppContext)
        {
            _popAppContext = popAppContext;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public ICompanyRepository Company
        {
            get
            {
                if (_company is null)
                    _company = new CompanyRepository(_popAppContext);
                return _company;
            }
        }

        ///<inheritdoc/>
        public IContainerRepository Container
        {
            get
            {
                if (_container is null)
                    _container = new ContainerRepository(_popAppContext);
                return _container;
            }
        }

        ///<inheritdoc/>
        public IDocumentRepository Document
        {
            get
            {
                if (_document is null)
                    _document = new DocumentRepository(_popAppContext);
                return _document;
            }
        }

        ///<inheritdoc/>
        public IFreightRepository Freight
        {
            get
            {
                if (_freight is null)
                    _freight = new FreightRepository(_popAppContext);
                return _freight;
            }
        }

        ///<inheritdoc/>
        public IProductRepository Product
        {
            get
            {
                if (_product is null)
                    _product = new ProductRepository(_popAppContext);
                return _product;
            }
        }

        ///<inheritdoc/>
        public IVesselRepository Vessel
        {
            get
            {
                if (_vessel is null)
                    _vessel = new VesselRepository(_popAppContext);
                return _vessel;
            }
        }

        ///<inheritdoc/>
        public IScheduleRepository Schedule 
        {
            get
            {
                if (_schedule is null)
                    _schedule = new ScheduleRepository(_popAppContext);
                return _schedule;
            }
        }

        ///<inheritdoc/>
        public void Save() => _popAppContext.SaveChanges();
        #endregion

    }
}

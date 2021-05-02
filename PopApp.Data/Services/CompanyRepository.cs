using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent company repository.
    /// </summary>
    public class CompanyRepository : PopAppRepositoryBase<Company> , ICompanyRepository
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public CompanyRepository(PopAppContext popAppContext) : base(popAppContext) { }
        #endregion

        #region Methods

        ///<inheritdoc/>
        public void CreateCompany(Company company)
        {
            if (company is null) throw new Exception("Company wasn't setting");
            Create(company);
        }

        ///<inheritdoc/>
        public IEnumerable<Company> GetAllCompanies(bool trackChange)
        {
            var companies = FindByCondition(company => company.IsActive == true, trackChange).ToList();
            if (companies is null) throw new Exception("There no are companies actives");
            return companies;
        }

        ///<inheritdoc/>
        public Company GetCompany(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("Company identifier invalid");
            var company = FindByCondition(c => c.Id == id, trackChange).FirstOrDefault();
            if (company is null) throw new Exception("Company invalid");
            return company;
        }

        ///<inheritdoc/>
        public void UpdateCompany(Company company)
        {
            if (company is null) throw new Exception("Company wasn't setting");
            Update(company);

        }
        #endregion
    }
}

using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent company repository.
    /// </summary>
    public interface ICompanyRepository
    {
        /// <summary>
        /// Get all companies of company entity
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List of company</returns>
        IEnumerable<Company> GetAllCompanies(bool trackChange);
        /// <summary>
        /// Get a company of company entity.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns></returns>
        Company GetCompany(int id, bool trackChange);
        /// <summary>
        /// Create a company.
        /// </summary>
        /// <param name="company"></param>
        void CreateCompany(Company company);
        /// <summary>
        /// Update a company.
        /// </summary>
        /// <param name="company"></param>
        void UpdateCompany(Company company);
    }
}

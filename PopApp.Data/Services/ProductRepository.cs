using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent product repository
    /// </summary>
    public class ProductRepository : PopAppRepositoryBase<Product> , IProductRepository
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public ProductRepository(PopAppContext popAppContext) : base(popAppContext) { }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateProduct(Product product)
        {
            if (product is null) throw new Exception("_product wasn't setting");
            Create(product);
        }

        ///<inheritdoc/>
        public IEnumerable<Product> GetAllProducts(bool trackChange)
        {
            var products = FindByCondition(product => product.IsActive == true, trackChange).ToList();
            if (products is null) throw new Exception("there no are products active");
            return products;
        }

        ///<inheritdoc/>
        public Product GetProduct(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("_product identifier invalid");
            var product = FindByCondition(product => product.Id == id , trackChange).FirstOrDefault();
            if (product is null) throw new Exception("_product invalid");
            return product;
        }

        ///<inheritdoc/>
        public void UpdateProduct(Product product)
        {
            if (product is null) throw new Exception("_product wasn't setting");
            Update(product);
        }
        #endregion
    }
}

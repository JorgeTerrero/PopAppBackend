using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent product repository.
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Get all product of product entity.
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List a products</returns>
        IEnumerable<Product> GetAllProducts(bool trackChange);
        /// <summary>
        /// Get a product of product entity.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns>A product</returns>
        Product GetProduct(int id, bool trackChange);
        /// <summary>
        /// Create a product.
        /// </summary>
        /// <param name="product"></param>
        void CreateProduct(Product product);
        /// <summary>
        /// Update a product.
        /// </summary>
        /// <param name="product"></param>
        void UpdateProduct(Product product);
    }
}

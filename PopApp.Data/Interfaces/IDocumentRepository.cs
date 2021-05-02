using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent document repository.
    /// </summary>
    public interface IDocumentRepository
    {
        /// <summary>
        /// Get all documents of document entity.
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List of documents</returns>
        IEnumerable<Document> GetAllDocuments(bool trackChange);
        /// <summary>
        /// Get document of documento entity.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns></returns>
        Document GetDocument(int id, bool trackChange);
        /// <summary>
        /// Create document.
        /// </summary>
        /// <param name="document"></param>
        void CreateDocument(Document document);
        /// <summary>
        /// Update document.
        /// </summary>
        /// <param name="document"></param>
        void UpdateDocument(Document document);
    }
}

using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent document repository.
    /// </summary>
    public class DocumentRepository : PopAppRepositoryBase<Document>  , IDocumentRepository
    {
        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public DocumentRepository(PopAppContext popAppContext) : base(popAppContext) { }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateDocument(Document document)
        {
            if (document is null) throw new Exception("_document wasn't setting");
            Create(document);
        }

        ///<inheritdoc/>
        public IEnumerable<Document> GetAllDocuments(bool trackChange)
        {
            var documents = FindByCondition(document => document.IsActive == true, trackChange).ToList();
            if (documents is null) throw new Exception("There no are document active");
            return documents;
        }

        ///<inheritdoc/>
        public Document GetDocument(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("_document identifier invalid");
            var document = FindByCondition(d => d.IsActive == true, trackChange).FirstOrDefault();
            if (document is null) throw new Exception("_document invalid");
            return document;
        }

        ///<inheritdoc/>
        public void UpdateDocument(Document document)
        {
            if (document is null) throw new Exception("_document wasn't setting");
            Update(document);
        }
        #endregion
    }
}

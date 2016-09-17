using DynamicDoc2.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.Service
{
    public class DocumentService : IDocumentService
    {
        IDocumentDataAccess DocumentDataAccess;

        public DocumentService(IDocumentDataAccess DocumentDataAccess)
        {
            this.DocumentDataAccess = DocumentDataAccess;
        }

        public void CreateDocument(string documentName)
        {
            Document document = new Document();
            document.Name = documentName;
            DocumentDataAccess.SaveDocument(document);
        }

        public void UpdateDocument(int documentId, string documentName)
        {
            var document = DocumentDataAccess.GetdocumentById(documentId);
            if (document != null)
            {
                document.Name = documentName;
                DocumentDataAccess.SaveDocument(document);
            }                
        }

        public List<Document> GetAllDocuments()
        {
            return DocumentDataAccess.GetAllDocuments();
        }

        public Document GetdocumentById(int id)
        {
            return DocumentDataAccess.GetdocumentById(id);
        }
    }
}
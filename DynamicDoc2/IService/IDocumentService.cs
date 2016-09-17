using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IService
{
    public interface IDocumentService
    {
        List<Document> GetAllDocuments();

        Document GetdocumentById(int id);

        void CreateDocument(string documentName);

        void UpdateDocument(int documentId, string documentName);
    }
}

using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.IService
{
    public interface IDocumentFieldService
    {
        DocumentField GetDocumentFieldById(int id);

        List<DocumentField> GetAllDocumentFieldsByDocument(int documentId);

        List<DocumentField> GetAllDocumentFieldsByField(int fieldId);

        List<DocumentField> GetAllDocumentFieldsByDocumentAndField(int documentId, int fieldId);

        List<DocumentField> GetAllDocumentFields();

        void CreateDocumentField(int documentId, int fieldId);
    }
}
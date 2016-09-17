using DynamicDoc2.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.Service
{
    public class DocumentFieldService : IDocumentFieldService
    {
        IDocumentFieldDataAccess DocumentFieldDataAccess;
        IDocumentService DocumentService;
        IFieldService FieldService;

        public DocumentFieldService(IDocumentFieldDataAccess DocumentFieldDataAccess, IDocumentService DocumentService, IFieldService FieldService)
        {
            this.DocumentFieldDataAccess = DocumentFieldDataAccess;
            this.DocumentService = DocumentService;
            this.FieldService = FieldService;
        }

        public void CreateDocumentField(int documentId, int fieldId)
        {
            var document = DocumentService.GetdocumentById(documentId);
            var field = FieldService.GetFieldById(fieldId);

            DocumentField documentField = new DocumentField();
            documentField.Document = document;
            documentField.Field = field;

            DocumentFieldDataAccess.SaveDocumentField(documentField);
        }

        public List<DocumentField> GetAllDocumentFields()
        {
            return DocumentFieldDataAccess.GetAllDocumentFields();
        }

        public List<DocumentField> GetAllDocumentFieldsByDocument(int documentId)
        {
            return DocumentFieldDataAccess.GetAllDocumentFieldsByDocument(
                DocumentService.GetdocumentById(documentId));
        }

        public List<DocumentField> GetAllDocumentFieldsByDocumentAndField(int documentId, int fieldId)
        {
            return DocumentFieldDataAccess.GetAllDocumentFieldsByDocumentAndField(
                DocumentService.GetdocumentById(documentId), FieldService.GetFieldById(fieldId));
        }

        public List<DocumentField> GetAllDocumentFieldsByField(int fieldId)
        {
            return DocumentFieldDataAccess.GetAllDocumentFieldsByField(FieldService.GetFieldById(fieldId));
        }

        public DocumentField GetDocumentFieldById(int id)
        {
            return DocumentFieldDataAccess.GetDocumentFieldById(id);
        }
    }
}
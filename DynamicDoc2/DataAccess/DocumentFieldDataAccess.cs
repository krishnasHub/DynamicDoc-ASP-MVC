using DynamicDoc2.IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;

namespace DynamicDoc2.DataAccess
{
    public class DocumentFieldDataAccess : NhibernateDataProvider, IDocumentFieldDataAccess
    {
        public List<DocumentField> GetAllDocumentFields()
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<DocumentField>();
            var l = criteria.List<DocumentField>().Where<DocumentField>(u => u.Document != null && u.Field != null).ToList();

            return l;
        }

        public List<DocumentField> GetAllDocumentFieldsByDocument(Document document)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<DocumentField>();
            var l = criteria.List<DocumentField>().Where<DocumentField>(u => u.Document != null
                                && u.Field != null
                                && u.Document.Id == document.Id).ToList();

            return l;
        }

        public List<DocumentField> GetAllDocumentFieldsByDocumentAndField(Document document, Field field)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<DocumentField>();
            var l = criteria.List<DocumentField>().Where<DocumentField>(u => u.Document != null
                                && u.Field != null
                                && u.Document.Id == document.Id
                                && u.Field.Id == field.Id).ToList();

            return l;
        }

        public List<DocumentField> GetAllDocumentFieldsByField(Field field)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<DocumentField>();
            var l = criteria.List<DocumentField>().Where<DocumentField>(u => u.Document != null
                                && u.Field != null
                                && u.Field.Id == field.Id).ToList();

            return l;
        }

        public DocumentField GetDocumentFieldById(int id)
        {
            return GetSession().Get<DocumentField>(id);
        }

        public void SaveDocumentField(DocumentField documentField)
        {
            var session = GetSession();
            session.BeginTransaction();
            session.SaveOrUpdate(documentField);
            session.Transaction.Commit();
        }
    }
}
using DynamicDoc2.IDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;

namespace DynamicDoc2.DataAccess
{
    public class DocumentDataAccess : NhibernateDataProvider, IDocumentDataAccess
    {
        public void SaveDocument(Document document)
        {
            var session = GetSession();
            session.BeginTransaction();
            session.SaveOrUpdate(document);
            session.Transaction.Commit();
        }

        public List<Document> GetAllDocuments()
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<Document>();
            var l = criteria.List<Document>().Where<Document>(u => u.Name != null).ToList();

            return l;
        }

        public Document GetdocumentById(int id)
        {
            return GetSession().Get<Document>(id);
        }
    }
}
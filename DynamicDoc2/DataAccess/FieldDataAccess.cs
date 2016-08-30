using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.DataAccess
{
    public class FieldDataAccess : NhibernateDataProvider, IFieldDataAccess
    {
        public List<Field> GetallFields()
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<Field>();
            var l = criteria.List<Field>().Where<Field>(u => u.Name != null).ToList();

            return l;
        }

        public Field GetFieldById(int id)
        {
            return GetSession().Get<Field>(id);
        }

        public void SaveField(Field field)
        {
            var session = GetSession();
            session.BeginTransaction();
            session.SaveOrUpdate(field);
            session.Transaction.Commit();
            
        }
    }
}
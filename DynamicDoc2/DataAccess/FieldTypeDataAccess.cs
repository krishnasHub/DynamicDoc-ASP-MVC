using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.DataAccess
{
    public class FieldTypeDataAccess : NhibernateDataProvider, IFieldTypeDataAccess
    {
        public List<FieldType> GetAllFieldTypes()
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<FieldType>();
            var l = criteria.List<FieldType>().Where<FieldType>(u => u.Name != null).ToList();

            return l;
        }

        public FieldType GetFieldTypeById(int id)
        {
            return GetSession().Get<FieldType>(id);
        }

        public FieldType GetFieldTypeByName(string name)
        {
            var session = GetSession();
            var criteria = session.CreateCriteria<FieldType>();

            return criteria.List<FieldType>().FirstOrDefault(f => f.Name.Equals(name));
        }
    }
}
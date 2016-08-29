using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DynamicDoc2.Models;
using DynamicDoc2.IService;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.Service
{
    public class FieldService : IFieldService
    {
        IFieldDataAccess FieldDataAccess;

        public FieldService(IFieldDataAccess FieldDataAccess)
        {
            this.FieldDataAccess = FieldDataAccess;
        }

        public List<Field> GetallFields()
        {
            return FieldDataAccess.GetallFields();
        }

        public Field GetFieldById(int id)
        {
            return FieldDataAccess.GetFieldById(id);
        }
    }
}
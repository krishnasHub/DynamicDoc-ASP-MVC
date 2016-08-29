using System.Collections.Generic;
using DynamicDoc2.Models;
using DynamicDoc2.IService;
using DynamicDoc2.IDataAccess;

namespace DynamicDoc2.Service
{
    public class FieldTypeService : IFieldTypeService
    {
        private IFieldTypeDataAccess FieldTypeDataAccess;

        public FieldTypeService(IFieldTypeDataAccess FieldTypeDataAccess)
        {
            this.FieldTypeDataAccess = FieldTypeDataAccess;
        }

        public List<FieldType> GetAllFieldTypes()
        {
            return FieldTypeDataAccess.GetAllFieldTypes();
        }

        public FieldType GetFieldTypeById(int id)
        {
            return FieldTypeDataAccess.GetFieldTypeById(id);
        }

        public FieldType GetFieldTypeByName(string name)
        {
            return FieldTypeDataAccess.GetFieldTypeByName(name);
        }
    }
}
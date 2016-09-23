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
        IFieldTypeService FieldTypeService;

        public FieldService(IFieldDataAccess FieldDataAccess, IFieldTypeService FieldTypeService)
        {
            this.FieldDataAccess = FieldDataAccess;
            this.FieldTypeService = FieldTypeService;
        }

        public void CreateField(string fieldName, int fieldTypeId)
        {

            FieldType fieleType = FieldTypeService.GetFieldTypeById(fieldTypeId);
            Field field = new Field();
            field.Name = fieldName;
            field.FieldType = fieleType;
            FieldDataAccess.SaveField(field);
        }

        public List<Field> GetallFields()
        {
            return FieldDataAccess.GetallFields();
        }

        public List<Field> GetAllFieldsByName(string name)
        {
            return FieldDataAccess.GetAllFieldsByName(name);
        }

        public Field GetFieldById(int id)
        {
            return FieldDataAccess.GetFieldById(id);
        }


    }
}
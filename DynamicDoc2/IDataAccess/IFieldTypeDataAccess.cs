using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IDataAccess
{
    public interface IFieldTypeDataAccess
    {
        FieldType GetFieldTypeById(int id);
        List<FieldType> GetAllFieldTypes();
        FieldType GetFieldTypeByName(string name);
    }
}

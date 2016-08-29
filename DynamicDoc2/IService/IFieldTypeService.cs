using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IService
{
    public interface IFieldTypeService
    {
        List<FieldType> GetAllFieldTypes();
        FieldType GetFieldTypeById(int id);
        FieldType GetFieldTypeByName(string name);

    }
}

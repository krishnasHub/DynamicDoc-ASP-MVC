using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IService
{
    public interface IFieldService
    {
        List<Field> GetallFields();
        Field GetFieldById(int id);
        void CreateField(string fieldName, int fieldTypeId);
    }
}

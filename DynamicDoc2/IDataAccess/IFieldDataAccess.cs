using DynamicDoc2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDoc2.IDataAccess
{
    public interface IFieldDataAccess
    {
        Field GetFieldById(int id);
        List<Field> GetallFields();
    }
}

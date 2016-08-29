using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.Models
{
    public class Field
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FieldType FieldType { get; set; }
    }
}
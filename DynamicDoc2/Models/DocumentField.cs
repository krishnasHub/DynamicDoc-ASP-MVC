using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.Models
{
    public class DocumentField
    {
        public int Id { get; set; }
        public Field Field { get; set; }
        public Document Document { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicDoc2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public int LoggedIn { get; set; }

    }
}
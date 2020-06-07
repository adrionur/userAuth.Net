using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Principal;

namespace LoginApp.Entity
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdminUser { get; set; }
    }
}

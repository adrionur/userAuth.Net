using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LoginApp.Web.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool IsAdminUser { get; set; }
        public List<string> Groups { get; set; }

        //[ScriptIgnore]
        public GenericPrincipal Principal
        {
            get
            {
                var principal = new GenericPrincipal(
                    new GenericIdentity(ID.ToString(CultureInfo.InvariantCulture), "Forms"),
                    new List<String>().ToArray()
                    );

                return principal;
            }
        }
    }
}
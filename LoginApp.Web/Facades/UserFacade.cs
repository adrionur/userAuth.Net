using LoginApp.Web.Facades.Interfaces;
using LoginApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.Web.Facades
{
    public class UserFacade : IUserFacade
    {
        public UserModel Authenticate(string userName, string password)
        {
            //repository işleri
            return new UserModel() { UserName = userName, Password = password, ID = 3};
        }
    }
}
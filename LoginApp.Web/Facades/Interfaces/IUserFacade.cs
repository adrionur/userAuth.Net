using LoginApp.Web.Models;

namespace LoginApp.Web.Facades.Interfaces
{
    public interface IUserFacade
    {
         UserModel Authenticate(string userName, string password);
    }
}

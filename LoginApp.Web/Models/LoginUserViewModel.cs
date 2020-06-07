using System.ComponentModel.DataAnnotations;

namespace LoginApp.Web.Models
{
    public class LoginUserViewModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
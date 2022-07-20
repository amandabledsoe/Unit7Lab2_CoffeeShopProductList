using System.ComponentModel.DataAnnotations;

namespace U7L2.Models
{
    public class CoffeeUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Password")]
        public string Password { get; set; }

        public CoffeeUser()
        {

        }
    }
}

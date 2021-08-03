using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Areas.ViewModels.Account
{
    public class LoginViewModel
    {
        
        [Required(ErrorMessage = "The Email field is required")]
        [EmailAddress(ErrorMessage = "The Email foeld is not a valid email address.")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        
        [Required(ErrorMessage = "The {0} field is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

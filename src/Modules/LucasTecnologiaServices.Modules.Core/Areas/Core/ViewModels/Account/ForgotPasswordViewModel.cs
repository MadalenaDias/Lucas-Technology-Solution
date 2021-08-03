using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Core.Areas.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {

        
        [Required(ErrorMessage = "The {0} is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}

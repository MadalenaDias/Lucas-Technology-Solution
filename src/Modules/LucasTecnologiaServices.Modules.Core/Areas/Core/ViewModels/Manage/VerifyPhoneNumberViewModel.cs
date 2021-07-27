﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LucasTecnologiaServices.Modules.Core.Areas.ViewModels.Manage
{
    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessage = "The {0} field is required.")]
        public string Code { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}

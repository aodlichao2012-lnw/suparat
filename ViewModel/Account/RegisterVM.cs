using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecom.ViewModel.Account
{
    public class RegisterVM
    {
      
        public string UserName { get; set; }

        [Required, DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&)])[A-Za-z\d$@$!%*?&]{8,}", ErrorMessage = "Password must upper case (A-Z) lower case (a-z) number (0-9) and speccial character(!@#$%^&*)")]
        public string Password { get; set; }

        [Required, DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [EmailAddress]
        public string Email { get; set; }

    }
}

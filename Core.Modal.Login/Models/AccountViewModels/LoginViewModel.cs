using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Modal.Login.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string Pin { get; set; }

        
        [EmailAddress]
        public string Email { get; set; }

        
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}

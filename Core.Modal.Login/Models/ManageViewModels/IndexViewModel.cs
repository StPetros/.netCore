using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Modal.Login.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Username { get; set; }
        public string Pin { get; set; }

        public bool IsEmailConfirmed { get; set; }
        public DateTime LoginTime { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }

        public string StatusMessage { get; set; }
    }
}

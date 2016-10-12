using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Utvecklarkollektivet.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "Om du har angett ett lösnenord så måste det vara mellan {2} och {1} tecken långt.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "Lösenord (ej obligatorisk)")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Bekräfta lösenord (ej obligatorisk)")]
        [Compare("Password", ErrorMessage = "Lösenordet och bekräftelsen stämmer inte överrens.")]
        public string ConfirmPassword { get; set; }
    }
}

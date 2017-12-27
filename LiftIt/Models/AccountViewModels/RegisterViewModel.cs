using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        //[Required]
        //[Display(Name = "Imie")]
        //public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi zawierać przynajmniej {2} i maksymalnie {1} znaków", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare("Password", ErrorMessage = "Hasła do siebie nie pasują!")]
        public string ConfirmPassword { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RegistrationDemoMvc.WebApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "The Name field is required.")]
        public string Name { get; set; }

        [Required]
        [Range(1, 110)]
        [Display(Name = "Age")]
        public string Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

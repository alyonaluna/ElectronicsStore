using System.ComponentModel.DataAnnotations;

namespace ElectronicsStore.Web.Models
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(100, MinimumLength = 1)]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }
    }
}

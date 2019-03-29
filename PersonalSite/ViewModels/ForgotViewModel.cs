using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}

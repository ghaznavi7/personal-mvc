using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Skill
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [Display(Name = "میزان")]
        public byte Amount { get; set; }
    }
}
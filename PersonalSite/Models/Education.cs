using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Education
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "مدرک دریافتی")]
        public string EarnedCertificate { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "مکان")]
        public string Location { get; set; }

        [Display(Name = "توضیح")]
        public string Description { get; set; }

        [StringLength(255)]
        [Display(Name = "تاریخ پایان")]
        public string EndDate { get; set; }
    }
}
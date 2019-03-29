using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Exprience
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "موقعیت")]
        public string Position { get; set; }

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
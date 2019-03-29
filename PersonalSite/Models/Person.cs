using System.ComponentModel.DataAnnotations;

namespace PersonalSite.Models
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Display(Name = "نام")]
        public string Name { get; set; }

        [StringLength(255)]
        [Display(Name = "عکس پروفایل")]
        public string AvatarLink { get; set; }

        [StringLength(255)]
        [Display(Name = "حرفه")]
        public string Profession { get; set; }

        [StringLength(255)]
        [Display(Name = "موقعیت")]
        public string Location { get; set; }

        [Display(Name = "درباره ما")]
        public string AboutUs { get; set; }

        [StringLength(25)]
        [Display(Name = "شماره تلفن")]
        public string Phone { get; set; }

        [StringLength(255)]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }

        [StringLength(255)]
        [Display(Name = "آیدی تلگرام")]
        public string TelegramId { get; set; }

        [StringLength(255)]
        [Display(Name = "آیدی توییتر")]
        public string TwitterId { get; set; }

        [StringLength(255)]
        [Display(Name = "آیدی اینستاگرام")]
        public string InstagramId { get; set; }

        [StringLength(255)]
        [Display(Name = "آیدی سروش")]
        public string SoroushId { get; set; }

        [StringLength(255)]
        [Display(Name = "آیدی لینکداین")]
        public string LinkedinId { get; set; }
    }
}
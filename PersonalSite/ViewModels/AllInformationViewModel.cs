using PersonalSite.Models;
using System.Collections.Generic;

namespace PersonalSite.ViewModels
{
    public class AllInformationViewModel
    {
        public Person Person { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Education> Educations { get; set; }
        public List<Exprience> Expriences { get; set; }
    }
}
using PersonalSite.Models;
using PersonalSite.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace PersonalSite.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Main
        public ActionResult Index()
        {

            var viewModel = new AllInformationViewModel
            {
                Person = db.People.First(),
                Skills = db.Skills.ToList(),
                Expriences = db.Expriences.ToList(),
                Educations = db.Educations.ToList()
            };

            return View(viewModel);
        }
    }
}

using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using PersonalSite.Models;

namespace PersonalSite.Controllers
{
    public class ExpriencesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Expriences
        public ActionResult Index()
        {
            return View(db.Expriences.ToList());
        }

        // GET: Expriences/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exprience exprience = db.Expriences.Find(id);
            if (exprience == null)
            {
                return HttpNotFound();
            }
            return View(exprience);
        }

        // GET: Expriences/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Expriences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Position,Location,Description,EndDate")] Exprience exprience)
        {
            if (ModelState.IsValid)
            {
                db.Expriences.Add(exprience);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(exprience);
        }

        // GET: Expriences/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exprience exprience = db.Expriences.Find(id);
            if (exprience == null)
            {
                return HttpNotFound();
            }
            return View(exprience);
        }

        // POST: Expriences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Position,Location,Description,EndDate")] Exprience exprience)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exprience).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(exprience);
        }

        // GET: Expriences/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exprience exprience = db.Expriences.Find(id);
            if (exprience == null)
            {
                return HttpNotFound();
            }
            return View(exprience);
        }

        // POST: Expriences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exprience exprience = db.Expriences.Find(id);
            db.Expriences.Remove(exprience);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

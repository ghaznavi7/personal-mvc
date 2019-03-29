using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PersonalSite.Models;

namespace PersonalSite.Controllers
{
    public class PeopleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: People
        public ActionResult Index()
        {
            return View(db.People.First());
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (HttpPostedFileBaseExtensions.IsImage(file))
            {
                var person = db.People.First();

                string previousAvatarPath = Request.MapPath("~" + person.AvatarLink);

                if (System.IO.File.Exists(previousAvatarPath))
                    System.IO.File.Delete(previousAvatarPath);

                // extract only the filename
                var fileName = Path.GetFileName(file.FileName);
                // store the file inside ~/Content/uploads folder
                var path = Path.Combine(Server.MapPath("~/Content/uploads"), fileName);
                file.SaveAs(path);



                person.AvatarLink = "/Content/uploads/" + fileName;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: People/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,AvatarLink,Profession,Location,AboutUs,Phone,Email,TelegramId,TwitterId,InstagramId,SoroushId,LinkedinId")] Person person)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person);
        }

        // GET: People/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Person person = db.People.Find(id);
            if (person == null)
            {
                return HttpNotFound();
            }
            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Person person = db.People.Find(id);
            db.People.Remove(person);
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

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Library.Models;
using Microsoft.AspNet.Identity;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        AppDbContext db = new AppDbContext();
        
        public ActionResult Index()
        {
            return View(db.Books.ToList());
        }

        // GET: Books/Details/5
        public ActionResult Details(int? id)
        {
            return View(db.Books.Find(id));
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Book book = db.Books.Find(id);
            book.Holder = User.Identity.GetUserId();
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges(); 
            }
            return RedirectToAction("Index");
        }

        public ActionResult ReturnBook(int? id)
        {
            Book book = db.Books.Find(id);
            book.Holder = null;
            if (ModelState.IsValid)
            {
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
            }
            return Redirect("/Account/Personal");
        }

        public ActionResult Statistics()
        {
            var result = db.Books.Select(x => new Statistic() { Genre = x.Genre, Count = db.Books.Count(y => y.Genre.Equals(x.Genre)).ToString() }).GroupBy(p => p.Genre).ToList();
            return View(result);
        }

        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                var fileName = db.Books.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
                book.ImagePath = "/Content/img/" + fileName + ".jpg";
                db.Books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(book);
        }

        [HttpPost]
        public JsonResult Upload()
        {
            var newId = db.Books.OrderByDescending(x => x.Id).FirstOrDefault().Id + 1;
            string path = "";
            foreach (string file in Request.Files)
            {
                var upload = Request.Files[file];
                if (upload != null)
                {
                    path = "/Content/img/" + newId + ".jpg";
                    upload.SaveAs(Server.MapPath(path));
                }
            }
            return Json(path);
        }

        public ActionResult Delete(int? id)
        {
            db.Books.Remove(db.Books.Find(id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

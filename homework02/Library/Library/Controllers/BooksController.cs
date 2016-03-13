using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
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
            //var result = db.Books.SqlQuery("Select Books.Genre, Count(Books.Genre) As GenreCount from Books group by (Books.Genre)");
            //не знаю, как работать с результатом запроса, поэтому так 
            int[] Count = new int[3];
            foreach (var item in db.Books)
            {
                if (item.Genre == "Фэнтези") Count[0]++;
                else if (item.Genre == "Учебник") Count[1]++;
                else if (item.Genre == "Философский роман") Count[2]++;
            }
            return View(Count);
        }
  
    }
}

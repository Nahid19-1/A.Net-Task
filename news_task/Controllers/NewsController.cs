using news_task.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace news_task.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            TaskNewsEntities db = new TaskNewsEntities();
            var data = db.News.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(News n)
        {
            if(ModelState.IsValid)
            {
                TaskNewsEntities db = new TaskNewsEntities();
                db.News.Add(n);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(n);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            TaskNewsEntities db = new TaskNewsEntities();
            var data = (from n in db.News
                        where n.Id == id
                        select n).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(News new_Edit)
        {
            if (ModelState.IsValid)
            {
                TaskNewsEntities db = new TaskNewsEntities();
                var data = (from n in db.News
                            where n.Id == new_Edit.Id
                            select n).FirstOrDefault();
                db.Entry(data).CurrentValues.SetValues(new_Edit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            TaskNewsEntities db = new TaskNewsEntities();
            var data = (from n in db.News
                        where n.Id == id
                        select n).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(News new_delete)
        {
            TaskNewsEntities db = new TaskNewsEntities();
            var data = (from n in db.News
                        where n.Id == new_delete.Id
                        select n).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(new_delete);
            db.News.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
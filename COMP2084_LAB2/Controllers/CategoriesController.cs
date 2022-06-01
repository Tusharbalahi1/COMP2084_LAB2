using COMP2084_LAB2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace COMP2084_LAB2.Controllers
{
    public class CategoriesController : Controller
    {
        static List<CategoriesModel> categoriesList = new List<CategoriesModel>()
        {
            new CategoriesModel{ Id = "a.", Cat = "Food"},
            new CategoriesModel{ Id = "b.", Cat = "Tech"},
            new CategoriesModel{ Id = "c.", Cat = "Sport"}

        };
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View(categoriesList);
        }

        // GET: CategoriesController/Details/Food
        public ActionResult Details(string cat)
        {
            var selected = categoriesList.First<CategoriesModel>(x => x.Cat == cat);
            ViewBag.MyMessage = "You Selected Category: " + selected.Cat;
            return View(selected);
        }

        // GET: CategoriesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoriesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoriesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

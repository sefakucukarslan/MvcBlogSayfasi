using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList();
            return View(categoryvalues);
        }

        //Sayfa yüklendiğinde HttpGet ile işaretli metot devreye girecek.
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        //Sayfada butona tıklanıldığı zaman,sayfada bir şey post edildiği zaman HttpPost çalışır.
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            return RedirectToAction("GetCategoryList");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListsMobileApp.Models;

namespace ListsMobileApp.Controllers
{
    public class HomeController : Controller
    {
        private IncomeListContext db = new IncomeListContext();
        //private ExpensesListsContext db1 = new ExpensesListsContext();
        public ActionResult Index()
        {
            return View(db.tblIncome.ToList());
            //return View(db1.tblExpenses.ToList());
        } 

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    



    }
}
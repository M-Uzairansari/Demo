using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_F.Models;

namespace Project_F.Controllers
{
    public class HomeController : Controller
    {
        travels_tours_dtEntities1 db = new travels_tours_dtEntities1();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult pakpackage()
        {
            return View();
        }
        public ActionResult parispackage()
        {
            return View();
        }

        public ActionResult swipackage() 
        {
            return View();
        }

        public ActionResult destinations() 
        {
            return View();
        }

        public ActionResult Booking()
        {
            return View();
        }
        public ActionResult pb1()
        {
            return View();
        }

        public ActionResult pb2()
        {
            return View();
        }

        public ActionResult pb3()
        {
            return View();
        }

        public ActionResult pb4()
        {
            return View();
        }
        public ActionResult pb5()
        {
            return View();
        }
        public ActionResult prb1()
        {
            return View();
        }

        public ActionResult prb2()
        {
            return View();
        }

        public ActionResult prb3()
        {
            return View();
        }

        public ActionResult prb4()
        {
            return View();
        }
        public ActionResult prb5()
        {
            return View();
        }

        public ActionResult swb1()
        {
            return View();
        }

        public ActionResult swb2()
        {
            return View();
        }

        public ActionResult swb3()
        {
            return View();
        }

        public ActionResult swb4()
        {
            return View();
        }
        public ActionResult swb5()
        {
            return View();
        }

        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Booking mdl)
        {

            Booking usr = new Booking();
            usr.B_Name = mdl.B_Name;
            usr.B_Person = mdl.B_Person;
            usr.B_Rooms = mdl.B_Rooms;
            usr.B_Days = mdl.B_Days;
            usr.B_Price = mdl.B_Price;
            usr.B_CarRent = mdl.B_CarRent;
            //usr.AddUser(usr.B_Name, usr.B_Person, usr.B_Rooms, usr.B_Days);
            return RedirectToAction("Index", "Home");

        }  
       
    
        
    }
}
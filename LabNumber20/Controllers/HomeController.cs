using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabNumber20.Models;

namespace LabNumber20.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Register() //this action shows the registration form
        {
            return View();
        }

        public ActionResult ProcessRegistration(RegisterModel userinput) //this processes the form 
        {
            ViewBag.FirstName = userinput.Firstname;

            return View("Confirm");
        }

        public ActionResult AdminPage()
        {
            CoffeeShopDBEntities gccoffeedb = new CoffeeShopDBEntities();

            List<Item> ItemList = gccoffeedb.Items.ToList();

            ViewBag.Details = ItemList;

            return View();
        }

        public ActionResult NewItem()
        {
            return View();
        }

        public ActionResult AddNewItem(Item AddedItem)
        {
            CoffeeShopDBEntities gccoffeedb = new CoffeeShopDBEntities();

            gccoffeedb.Items.Add(AddedItem);

            gccoffeedb.SaveChanges();

            return RedirectToAction("AdminPage");
        }

        public ActionResult DeleteItem(string ItemName)
        {
            CoffeeShopDBEntities gccoffeedb = new CoffeeShopDBEntities();
            Item Locate = gccoffeedb.Items.Find(ItemName);

            gccoffeedb.Items.Remove(Locate);

            gccoffeedb.SaveChanges();

            return RedirectToAction("AdminPage");

        }
            
    }
}
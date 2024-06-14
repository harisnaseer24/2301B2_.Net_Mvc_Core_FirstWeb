using Microsoft.AspNetCore.Mvc;

namespace _2301b2firstWeb.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AllProducts()
        {
            TempData.Keep("pname");
            TempData.Keep("description");
            TempData.Keep("price");
            return View();
        }

        //[HttpGet]
        public IActionResult Add()
        {
            return View("AddProductForm");
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(string email, string password)
        {
            if(email != string.Empty && password != string.Empty)
            {
                //passing data from controller to view from same action to same view using ViewData and ViewBag
                ViewData["Email"] = email;
                ViewBag.Password = password;
            }


            return View("AddProductForm");
        }

        //cross action and cross controller data transfer using TempData.
        [HttpGet]
        public IActionResult AddProd()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddProd(string pname, string desc, string price)
        {
            if (pname != string.Empty && desc != string.Empty && price != string.Empty)
            {
                TempData["pname"] = pname;
                TempData["desc"] = desc;
                TempData["price"] = price;
            }


            return RedirectToAction("AllProducts");
        }
    }
}

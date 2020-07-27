using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebKeyBoardShop.Models;

namespace WebKeyBoardShop.Controllers
{
    public class HomeController : Controller
    {
        SellContext db;
        public HomeController(SellContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.KeyBoards.ToList());
        }
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PhoneId = id;
            return View();
        }
        [HttpPost]
        public string Buy(ShoppingCart cart)
        {
            db.ShoppingCarts.Add(cart);
            // сохраняем в бд все изменения
            return "Благодарим за покупку!";
        }
    }
}

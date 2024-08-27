using InAndOut.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Data;
using System.Collections.Generic;
using InAndOut.Models;

namespace InAndOut.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDBContext _db;

      
        public ItemController(ApplicationDBContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Items> objList = _db.Items;
            return View(objList);
        }

       //GET-Create
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Items obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Idex");
        }
    }
}

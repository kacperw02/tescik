using System;
using Microsoft.AspNetCore.Mvc;
using Projekt_bazy.Models;

namespace Projekt_bazy.Controllers
{
    public class SprzetController : Controller
    {
        private readonly AppDbContext _context;

        public SprzetController(AppDbContext context)
        {
            _context = context;
        }

        // Akcja Index - wyświetlenie wszystkich sprzętów
        public IActionResult Index()
        {
            var sprzety = _context.Sprzety.ToList();
            return View(sprzety);
        }

        // Akcja Create - formularz do dodania sprzętu
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Sprzet sprzet)
        {
            if (ModelState.IsValid)
            {
                _context.Sprzety.Add(sprzet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sprzet);
        }

        // Akcja Edit - edycja sprzętu
        public IActionResult Edit(int id)
        {
            var sprzet = _context.Sprzety.Find(id);
            if (sprzet == null)
            {
                return NotFound();
            }
            return View(sprzet);
        }

        [HttpPost]
        public IActionResult Edit(Sprzet sprzet)
        {
            if (ModelState.IsValid)
            {
                _context.Sprzety.Update(sprzet);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sprzet);
        }

        // Akcja Delete - usunięcie sprzętu
        public IActionResult Delete(int id)
        {
            var sprzet = _context.Sprzety.Find(id);
            if (sprzet == null)
            {
                return NotFound();
            }
            _context.Sprzety.Remove(sprzet);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

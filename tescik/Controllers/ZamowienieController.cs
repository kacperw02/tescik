using Microsoft.AspNetCore.Mvc;
using Projekt_bazy.Models;

namespace Projekt_bazy.Controllers
{
    public class ZamowienieController : Controller
    {
        private readonly AppDbContext _context;

        public ZamowienieController(AppDbContext context)
        {
            _context = context;
        }

        // Akcja Index - wyświetlenie wszystkich zamówień
        public IActionResult Index()
        {
            var zamowienia = _context.Zamowienia.ToList();
            return View(zamowienia);
        }

        // Akcja Create - formularz do dodania zamówienia
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Zamowienie zamowienie)
        {
            if (ModelState.IsValid)
            {
                _context.Zamowienia.Add(zamowienie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zamowienie);
        }

        // Akcja Edit - edycja zamówienia
        public IActionResult Edit(int id)
        {
            var zamowienie = _context.Zamowienia.Find(id);
            if (zamowienie == null)
            {
                return NotFound();
            }
            return View(zamowienie);
        }

        [HttpPost]
        public IActionResult Edit(Zamowienie zamowienie)
        {
            if (ModelState.IsValid)
            {
                _context.Zamowienia.Update(zamowienie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zamowienie);
        }

        // Akcja Delete - usunięcie zamówienia
        public IActionResult Delete(int id)
        {
            var zamowienie = _context.Zamowienia.Find(id);
            if (zamowienie == null)
            {
                return NotFound();
            }
            _context.Zamowienia.Remove(zamowienie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

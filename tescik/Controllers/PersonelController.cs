using Microsoft.AspNetCore.Mvc;
using Projekt_bazy.Models;

namespace Projekt_bazy.Controllers
{
    public class PersonelController : Controller
    {
        private readonly AppDbContext _context;

        public PersonelController(AppDbContext context)
        {
            _context = context;
        }

        // Akcja Index - wyświetlenie personelu
        public IActionResult Index()
        {
            var personel = _context.Personel.ToList();
            return View(personel);
        }

        // Akcja Create - formularz do dodania pracownika
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Personel personel)
        {
            if (ModelState.IsValid)
            {
                _context.Personel.Add(personel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personel);
        }

        // Akcja Edit - edycja pracownika
        public IActionResult Edit(int id)
        {
            var personel = _context.Personel.Find(id);
            if (personel == null)
            {
                return NotFound();
            }
            return View(personel);
        }

        [HttpPost]
        public IActionResult Edit(Personel personel)
        {
            if (ModelState.IsValid)
            {
                _context.Personel.Update(personel);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personel);
        }

        // Akcja Delete - usunięcie pracownika
        public IActionResult Delete(int id)
        {
            var personel = _context.Personel.Find(id);
            if (personel == null)
            {
                return NotFound();
            }
            _context.Personel.Remove(personel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

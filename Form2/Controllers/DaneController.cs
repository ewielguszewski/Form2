using Form2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Form2.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form(Dane dane)
        {
            var registeredAccount = new Dane
            {
                Imie = dane.Imie,
                Nazwisko = dane.Nazwisko,
                Email = dane.Email,
                Haslo = dane.Haslo,
                Telefon = dane.Telefon,
                Wiek = dane.Wiek,
                Miasto = dane.Miasto
            };

            // implementacja przekazania danych do bazy danych

            if (ModelState.IsValid)
            {
                TempData["SuccessMessage"] = "Rejestracja zakończona pomyślnie!";
                return View("Wynik", dane);
            }

            else return View();
        }

        public ActionResult Wynik(Dane dane)
        {
            if (ModelState.IsValid)
            {
                return View(dane);
            }

            return View("Form", dane);
        }
    }
}

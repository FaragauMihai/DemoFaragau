using DemoPentruFaragau.Services;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DemoPentruFaragau.Controllers
{
    //Aici se face legatura cu browser in functie de url, si controlleru are acces la cod, si poate trimite un view la browser
    public class MasinaController : Controller
    {
        private MasinaService service;

        public MasinaController()
        {
            service = new MasinaService();
        }

        // GET: Masina
        public ActionResult Index()
        {
            List<Masina> masini = service.GetAllCars();

            return View(masini);
        }

        public ActionResult AddNewCar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewCar(Masina masina)
        {
            service.AddNewCar(masina);

            return RedirectToAction("Index");
        }
    }
}
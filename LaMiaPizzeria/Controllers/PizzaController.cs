using LaMiaPizzeria.Models;
using LaMiaPizzeria.Utilis;
using Microsoft.AspNetCore.Mvc;

namespace LaMiaPizzeria.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pizza> pizze = PizzaData.GetPizze();
            return View("HomePage", pizze);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            Pizza pizzaFound = null;

            foreach (Pizza pizza in PizzaData.GetPizze())
            {
                if (pizza.Id == id)
                {
                    pizzaFound = pizza;
                    break;
                }
            }

            if (pizzaFound != null)
            {
                return View("Details", pizzaFound);
            }
            else
            {
                return NotFound("Il post con id " + id + " non e' stato trovato!");
            }
        }
    }
}

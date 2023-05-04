using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public static List<Pizza> pizze = new List<Pizza>
        {
            new Pizza(
                    1, 
                    "Pizza Margherita", 
                    "Best pizza Margherita", 
                    "img/Margherita.jpg", 
                    6
                ),
            new Pizza(
                    2, 
                    "Pizza Marinara", 
                    "Best pizza Marinara", 
                    "img/Marinara.jpeg", 
                    6
                ),
            new Pizza(
                    3, 
                    "Pizza Wurstel e patatine", 
                    "Best pizza Wurstel e patatine", 
                    "img/pizzaWurstel.png", 
                    8
                ),
            new Pizza(
                    4, 
                    "Pizza Mimosa", 
                    "Best pizza Mimosa", 
                    "img/Mimosa.jpg", 
                    8
                ),
            new Pizza(
                 5, 
                 "Pizza Porchetta", 
                 "Best pizza Porchetta e patatine", 
                 "img/pizza-la-porchetta.jpg", 
                 8
                ),
            new Pizza(
                    6, 
                    "Pizza Salsicca e friarielli", 
                    "Best pizza Salsiccia e friarielli",
                    "img/friarielli.jpg", 
                    8
                ),

        };
        public IActionResult Index()
        {
            return View(pizze);
        }

        public IActionResult Details(int Id)
        {
            var pizza = pizze.FirstOrDefault(x => x.Id == Id);
            return View(pizza);


            if (pizza == null || Id < 1 || Id > pizze.Count)
            {
                return View("ErrorPizza");
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pizza data)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", data);
            }

            pizze.Add(data);

            return RedirectToAction("Index");
        }

    }
}

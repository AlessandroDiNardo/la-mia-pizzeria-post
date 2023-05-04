using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        List<Pizza> pizze = new List<Pizza>
        {
            new Pizza(
                    1, 
                    "Pizza Margherita", 
                    "Best pizza Margherita", 
                    "https://giorgiacastioni.files.wordpress.com/2015/01/pizza-margherita-1.jpg", 
                    6
                ),
            new Pizza(
                    2, 
                    "Pizza Marinara", 
                    "Best pizza Marinara", 
                    "https://www.anticogatoleto.com/shop/wp-content/uploads/2021/02/marinara-min-scaled.jpeg", 
                    6
                ),
            new Pizza(
                    3, 
                    "Pizza Wurstel e patatine", 
                    "Best pizza Wurstel e patatine", 
                    "https://i0.wp.com/www.piccolericette.net/piccolericette/wp-content/uploads/2017/11/3244_Pizza.jpg?resize=895%2C616&ssl=1", 
                    8
                ),
            new Pizza(
                    4, 
                    "Pizza Mimosa", 
                    "Best pizza Mimosa", 
                    "https://nizza.ro/wp-content/uploads/2021/02/mimosa.jpg", 
                    8
                ),
            new Pizza(
                 5, 
                 "Pizza Porchetta", 
                 "Best pizza Porchetta e patatine", 
                 "https://www.borgotto.it/wp-content/uploads/2020/11/pizza-la-porchetta.jpeg", 
                 8
                ),
            new Pizza(
                    6, 
                    "Pizza Salsicca e friarielli", 
                    "Best pizza Salsiccia e friarielli", 
                    "https://www.pizzaontheroad.eu/wp-content/uploads/2020/01/cover-irevolino.jpg", 
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
    }
}

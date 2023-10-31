using ASPTask1.Entities;
using ASPTask1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASPTask1.Controllers
{
    public class HomeController : Controller
    {
		List<Drink> drinks = new List<Drink>
		{
			new Drink {ID = 1, Name = "Coca-Cola", Price = 1.0},
			new Drink {ID = 2, Name = "Pepsi", Price = 0.9},
			new Drink {ID = 3, Name = "Fanta", Price = 1.1},
		};

		List<FastFood> fastFoods = new List<FastFood>
		{
			new FastFood {ID = 1, Name = "Burger", Price = 5.0},
			new FastFood {ID = 2, Name = "French Fries", Price = 2.5},
			new FastFood {ID = 3, Name = "Nugget", Price = 3.2},
		};

		List<HotMeal> hotMeals = new List<HotMeal>
		{
			new HotMeal {ID = 1, Name = "Burger", Price = 5.0},
			new HotMeal {ID = 2, Name = "French Fries", Price = 2.5},
			new HotMeal {ID = 3, Name = "Nugget", Price = 3.2},
		};

		public IActionResult Index()
        {
			var viewModel = new MainViewModel
			{
				Drinks = drinks,
				FastFoods = fastFoods,
				HotMeals = hotMeals,
			};

			return View(viewModel);
		}

        public ViewResult Drinks()
        {
            var viewModel = new MainViewModel
            {
                Drinks = drinks
            };

            return View(viewModel);
        }

		public ViewResult FastFoods()
		{
			var viewModel = new MainViewModel
            {
				FastFoods = fastFoods
			};

			return View(viewModel);
		}

		public ViewResult HotMeals()
		{
			var viewModel = new MainViewModel
            {
				HotMeals = hotMeals
			};

			return View(viewModel);
		}
	}
}

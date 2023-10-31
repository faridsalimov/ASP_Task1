using ASPTask1.Entities;
using System.Collections.Generic;

namespace ASPTask1.Models
{
    public class MainViewModel
    {
        public List<Drink> Drinks { get; set; }
		public List<FastFood> FastFoods { get; set; }
		public List<HotMeal> HotMeals { get; set; }

	}
}

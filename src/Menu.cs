using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Ucu.Poo.Restaurant
{

    public class Menu
    {
        private List<Dish> dishes = new List<Dish>();

        public void AddDish(Dish Dish)
        {
            if (!this.dishes.Contains(Dish))
            {
                this.dishes.Add(Dish);
            }
            else
            {
                Console.WriteLine("El platillo ya esta en el menu");
            }
        }

        public void RemoveDish(Dish Dish)
        {
            if (this.dishes.Contains(Dish))
            {
                this.dishes.Remove(Dish);
            }
            else
            {
                Console.WriteLine("El platillo no esta en el menu");
            }
        }

        public Dish GetDishByName(string DishName)
        {
            foreach (Dish Dish in this.dishes)
            {
                if (Dish.Name == DishName)
                {
                    return Dish;
                }
            }
            return null;
        }
    }

}
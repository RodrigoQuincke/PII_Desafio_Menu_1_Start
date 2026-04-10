using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Numerics;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> dishes = new List<Dish>();
        public List<Dish> Dishes
        {
            get { return dishes; } set { dishes = value; }
        }

        private bool takeAway;
        public bool TakeAway
        {
            get { return takeAway; } set { takeAway = value; }
        }

        public Order(bool takeAway)
        {
            this.Dishes = new List<Dish>();
            this.TakeAway = takeAway;
        }

        public void ClearOrder()
        {
            this.dishes.Clear();
        }

        public void AddToOrder(Dish Dish)
        {
            this.dishes.Add(Dish);
        }

        public double GetTotal()
        {
            double totalPrice = 0;
            foreach (Dish orderedDish in this.dishes)
            {
                totalPrice += orderedDish.Price;
            }
            return totalPrice;
        }

    }

}
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{

    public class Table
    {
        private int number;
        public int Number
        {
            get { return number; } set { number = value; }
        }

        private bool isOccupied;
        public bool IsOccupied
        {
            get { return isOccupied; } set { isOccupied = value; }
        }

        private List<Dish> order = new List<Dish>();
        public List<Dish> Order
        {
            get { return order; } set { order = value; }
        }

        public Table(int number){
            this.Number = number;
            this.IsOccupied = false;
            this.Order = new List<Dish>();
        }

        public void Occupy()
        {
            this.isOccupied = true;
        }

        public void Free()
        {
            this.isOccupied = false;
            this.order.Clear();
        }

        public void AddToOrder(Dish Dish)
        {
            this.order.Add(Dish);
        }

        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }

}
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{

    public class Table
    {
        private int id;
        public int Id
        {
            get { return id; } set { id = value; }
        }

        private bool isOccupied;
        private bool IsOccupied
        {
            get { return isOccupied; } set { isOccupied = value; }
        }

        private List<Dish> order = new List<Dish>();
        public List<Dish> Order
        {
            get { return order; } set { order = value; }
        }

        public Table(int id, bool isOccupied){
            this.Id = id;
            this.IsOccupied = isOccupied;
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
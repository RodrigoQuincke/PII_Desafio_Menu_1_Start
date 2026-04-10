using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

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

        private Order order;
        public Order Order
        {
            get { return order; } set { order = value; }
        }

        public Table(int number, bool takeAway){
            this.Number = number;
            this.IsOccupied = false;
            this.Order = new Order(takeAway);
        }

        public void Occupy()
        {
            this.isOccupied = true;
        }

        public void Free()
        {
            this.isOccupied = false;
            this.order.ClearOrder();
        }

        public void AddToOrder(Dish Dish)
        {
            this.order.AddToOrder(Dish);
        }

        public bool HasOrders()
        {
            if ( this.order.Dishes.Count() > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
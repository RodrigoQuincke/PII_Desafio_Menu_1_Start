using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{

    public class Waiter
    {
        private string name;
        public string Name
        {
            get { return name; } set { name = value; }
        }

        private List<Table> assignedTables = new List<Table>();
    
        public Waiter(string name)
        {
            this.Name = name;
            this.assignedTables = new List<Table>();
        }

        public void AssignTable(Table table)
        {
            this.assignedTables.Add(table);
        }

        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }
    }

}
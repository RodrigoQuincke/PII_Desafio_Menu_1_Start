using System;

namespace Ucu.Poo.Restaurant
{
    public static class Program
    {
        public static void Main()
        {
            Dish burger = new Dish("Burger", 5.99, false);
            Dish salad = new Dish("Salad", 4.99, true);
            Menu menu = new Menu();
            menu.AddDish(burger);
            menu.AddDish(salad);
            Table oneTable = new Table(1, false);
            Waiter waiter = new Waiter("John");
            waiter.AssignTable(oneTable);
            oneTable.Occupy();
            waiter.TakeOrder(oneTable, burger);
            waiter.TakeOrder(oneTable, salad);
            Console.WriteLine(
                $"Probando GetTotal: {oneTable.Order.GetTotal()}. *Deberia dar 10,98.\n");
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
                $"y la atiende: {waiter.Name}");
            oneTable.Free();
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
        }
    }
}
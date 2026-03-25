namespace Ucu.Poo.Restaurant
{

    public class Dish
    {
        private string name;
        public string Name
        {
            get { return name; } set { name = value; }
        }

        private string price;
        public string Price
        {
            get { return price; } set { price = value; }
        }

        private bool isVegetarian;
        public bool IsVegetarian
        {
            get { return IsVegetarian; } set { isVegetarian = value; }
        }

        public Dish(string name, string price, bool isVegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = isVegetarian;
        }
    }

}
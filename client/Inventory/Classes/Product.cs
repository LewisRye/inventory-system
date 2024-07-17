namespace Inventory.Classes
{
    internal class Product(int id, string name, string category, int stock, decimal price, char discontinued)
    {
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public string GetCategory()
        {
            return category;
        }

        public int GetStock()
        {
            return stock;
        }

        public decimal GetPrice()
        {
            return price;
        }

        public char GetDiscontinued()
        {
            return discontinued;
        }
    }
}

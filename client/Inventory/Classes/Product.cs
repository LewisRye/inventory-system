namespace Inventory.Classes
{
    internal class Product
    {
        private int _id;
        private string _name;
        private string _category;
        private int _stock;
        private decimal _price;
        private char _discontinued;

        public Product(int id, string name, string category, int stock, decimal price, char discontinued)
        {
            _id = id;
            _name = name;
            _category = category;
            _stock = stock;
            _price = price;
            _discontinued = discontinued;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetCategory()
        {
            return _category;
        }

        public int GetStock()
        {
            return _stock;
        }

        public decimal GetPrice()
        {
            return _price;
        }

        public char GetDiscontinued()
        {
            return _discontinued;
        }
    }
}

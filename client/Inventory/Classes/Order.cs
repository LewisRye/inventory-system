namespace Inventory.Classes
{
    internal class Order
    {
        private int _id;
        private string _productName;
        private string _firstname;
        private string _lastname;
        private int _quantity;
        private DateTime _dateOrdered;
        private decimal _price;

        public Order(int id, string productname, string firstname, string lastname, int quantity, DateTime dateordered, decimal price)
        {
            _id = id;
            _productName = productname;
            _firstname = firstname;
            _lastname = lastname;
            _quantity = quantity;
            _dateOrdered = dateordered;
            _price = price;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetProductName()
        {
            return _productName;
        }

        public string GetFullName()
        {
            return _firstname + " " + _lastname;
        }

        public int GetQuantity()
        {
            return _quantity;
        }

        public DateTime GetDate()
        {
            return _dateOrdered;
        }

        public decimal GetPrice()
        {
            return _price;
        }
    }
}

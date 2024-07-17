namespace Inventory.Classes
{
    internal class Order(
        int id,
        string product_name,
        string firstname,
        string lastname,
        int quantity,
        DateTime date_ordered,
        decimal price)
    {
        public int GetId()
        {
            return id;
        }

        public string GetProductName()
        {
            return product_name;
        }

        public string GetFullName()
        {
            return firstname + " " + lastname;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public DateTime GetDate()
        {
            return date_ordered;
        }

        public decimal GetPrice()
        {
            return price;
        }
    }
}

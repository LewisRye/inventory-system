namespace Inventory.Classes
{
    internal class Category
    {
        private int _id;
        private string _name;

        public Category(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetName()
        {
            return _name;
        }
    }
}

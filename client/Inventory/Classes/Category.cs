namespace Inventory.Classes
{
    internal class Category(int id, string name)
    {
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }
    }
}

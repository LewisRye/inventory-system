using Inventory.JsonResponses;

namespace Inventory.Classes
{
    internal static class Logon
    {
        /*
         *  Contents
         */

        // stores variables useful for the log on screen

        public static string CurrentUser = ""; // shows info about currently logged in user
        public static string AccessLevel = "";
        public static bool PasswordChanged = false;
        public static bool AccountCreated = false;
        public static int NotificationTime = 0;
        public static int NotificationStock = 5;
        public static string RecipientEmailAddress = "";
        public static string ColourScheme = "";
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["Database"].ConnectionString;
        public static readonly string UriPath = ConfigurationManager.ConnectionStrings["Uri"].ConnectionString;
        public static readonly string FilePath = ConfigurationManager.ConnectionStrings["Settings"].ConnectionString;

        // stores lists of products and categories to avoid unnecessary API calls

        public static List<Category> AllCategories = new List<Category>();
        public static List<Product> AllProducts = new List<Product>();
        public static List<Order> AllOrders = new List<Order>();
    }
}

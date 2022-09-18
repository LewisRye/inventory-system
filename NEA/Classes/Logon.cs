namespace NEA
{
    internal static class Logon
    {
        /*
         *  Contents
         */

        //  -stores variables useful for the log on screen

        public static string CurrentUser { get; set; }              // shows info about currently logged in user
        public static string AccessLevel { get; set; } 
        public static bool PasswordChanged { get; set; } 
        public static bool AccountCreated { get; set; }
        public static int NotificationTime { get; set; }
        public static int NotificationStock { get; set; }
        public static string RecipientEmailAddress { get; set; }
        public static string ColourScheme { get; set; }
    }
}

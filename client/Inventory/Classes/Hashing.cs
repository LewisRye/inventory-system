namespace Inventory
{
    internal class Hashing
    {
        /*
         *  Contents
         */

        //  -takes a user input and returns it as a hash

        public static string GenerateHash(string StringToHash, string Username)
        {
            string salt = Username; // individual salt per account
            string hashedValue = "";

            var inputWithSalt = new StringBuilder("", 2);

            inputWithSalt.Append(StringToHash);
            inputWithSalt.Append(salt);

            byte[] inputInBytes = Encoding.UTF8.GetBytes(inputWithSalt.ToString());
            inputInBytes.Reverse(); // first character in input = last character in array

            foreach (byte value in inputInBytes) // adds the new hashed value into a string
            {
                hashedValue += (value * 5); // multiplies the byte by 5 (prime number) so it is harder to crack
            }

            return hashedValue; // returns the new hashed value
        }

        public static bool ValidPassword(string Password)
        {
            var contains8Characters = new Regex(@".{8,}");                                                        // checks if a string has 8 characters
            var containsUpperCase = new Regex(@"[A-Z]+");                                                         // checks if a string has an upper case char
            var containsLowerCase = new Regex(@"[a-z]+");                                                         // checks if a string has a lower case char
            var containsNumber = new Regex(@"[0-9]+");                                                            // checks if a string has a number
            var containsLegalChars = new Regex(@"^[a-zA-Z0-9- _ = + ! @ # $ % ^ & * ( )]*$");                     // checks if a string has all legal characters (unlike emojis)

            if (contains8Characters.IsMatch(Password)
                && containsUpperCase.IsMatch(Password)
                && containsLowerCase.IsMatch(Password)
                && containsNumber.IsMatch(Password))
            {
                if (!containsLegalChars.IsMatch(Password))
                {
                    MessageBox.Show("Invalid characters detected...", "Error");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Password does not meet criteria...", "Error");
                return false;
            }
        }
    }
}

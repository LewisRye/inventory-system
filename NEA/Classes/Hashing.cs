using System.Text;
using System.Linq;

namespace NEA
{
    internal class Hashing
    {
        /*
         *  Contents
         */

        //  -takes a user input and returns it as a hash

        private protected string salt;
        private protected string hashedValue;

        public string GenerateHash(string StringToHash, string Username)
        {
            salt = Username; // individual salt per account
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
    }
}

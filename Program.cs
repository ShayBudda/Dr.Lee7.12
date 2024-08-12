using System;
namespace Dr.Lee7._12
{

    public class CaptainCrunch
    {
        // This method encodes a given string by shifting each letter by a specified amount.
        public static string EncodeWithShift(string input, int shift)
        {
            // Convert the input string into a character array.
            char[] buffer = input.ToCharArray();

            // Iterate through each character in the array.
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                // Check if the character is a letter.
                if (char.IsLetter(letter))
                {
                    // Determine the offset based on whether the letter is uppercase or lowercase.
                    char offset = char.IsUpper(letter) ? 'A' : 'a';

                    // Calculate the new letter by shifting it and wrapping around using modulo 26.
                    // Adding 26 ensures the result is always positive before applying modulo.
                    letter = (char)(((letter + shift - offset + 26) % 26) + offset);
                }

                // Update the character in the buffer.
                buffer[i] = letter;
            }

            // Convert the character array back into a string and return it.
            return new string(buffer);
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Define the input string to be encoded.
            string input = "Hello World";

            // Define the shift amount for encoding.
            int shift = 13;

            // Encode the input string using the specified shift amount.
            string encoded = CaptainCrunch.EncodeWithShift(input, shift);

            // Output the encoded string.
            Console.WriteLine("Encoded: " + encoded);

            // Decode the encoded string by shifting in the opposite direction.
            string decoded = CaptainCrunch.EncodeWithShift(encoded, -shift);

            // Output the decoded string.
            Console.WriteLine("Decoded: " + decoded);
        }
    }

}

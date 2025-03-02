/* 
A palindrome is a word, phrase, number, or any sequence that 
reads the same forward and backward. For instance, 
“madam” and “121” are palindromes.

Write a program to check if a string is a palindrome.
*/


namespace PalindromProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string: ");
            string inputString = Console.ReadLine();        // Read user input

            //Console.WriteLine(inputString);


            Console.WriteLine("");


            string backwardString = "";     // Create a new string to store the reversed version of the input.

            // Loop through the input string in reverse order
            // and build the reversed string character by character.
            for (int k = inputString.Length - 1; k >= 0; k--)
            {
                backwardString += inputString[k];   // Append each character in reverse order

            }

            Console.WriteLine(backwardString); // To print the reversed string.


            /*
            foreach (var character in inputString)
            {

                Console.Write(character);

            } */


            // Compare the original string with the reversed string. If they are the same, it is a palindrome.
            if (inputString.Equals(backwardString))
            {

                // string interpolation
                Console.WriteLine($"the word '{inputString}' is a palindrom.");     // Output a message if the word is a palindrome.

            }
            else 
            {

                Console.WriteLine($"the word '{inputString}' is NOT a palindrom.");     // Output a message if the word is not a palindrome.

            }

        }
    }


}

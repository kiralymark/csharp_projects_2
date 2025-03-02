/*
This program checks if a given input string contains any banned words. 
If the input matches a banned word exactly, it triggers a censorship warning.

*/


namespace StringCheckProgram 
{
    class Program 
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string to check: ");
            string inputString = Console.ReadLine();            // Read user input.


            // List of banned words that require censorship.
            string[] listOfBannedWords = {"beer", "wine", "kvass", "cider", "vodka", "gin", "tequila", "rum", "whisky", "whiskey", "brandy", "sake", "rum", "cognac"};

            // A boolean to determine if censorship is needed.
            bool isCensorshipNeeded = false;


            // Loop through each word in the banned list to check if the input string matches any.
            foreach (var word in inputString)
            {

                if (isCensorshipNeeded == false)    // Only check further if censorship is not already triggered.
                {

                    for (int i = 0; i < listOfBannedWords.Length; i++)
                    {

                        //Console.WriteLine(listOfBannedWords.Length);

                        // Compare the input string with each banned word.
                        if (inputString.Equals(listOfBannedWords[i]))
                        {

                            isCensorshipNeeded = true;

                        }

                    }

                }
                else 
                {
                    break;  // Exit the loop if censorship is already determined.
                }
                
            }

            Console.WriteLine("");

            // Display the appropriate message based on censorship status.
            if (isCensorshipNeeded) 
            {

                Console.WriteLine("Censorship_is_needed!");
            
            }
            else 
            {

                Console.WriteLine(inputString);  // Print the original string if no banned words are found.

            }

        }

    }

}

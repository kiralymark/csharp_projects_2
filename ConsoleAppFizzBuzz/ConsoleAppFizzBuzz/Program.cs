//   FizzBuzz Task
// The task is to take an input 'n' and output the odd numbers from 1 to 'n'.
// For each multiple of 3, print "Fizz" instead 
// of the number. 
// For each multiple of 5, print "Buzz" instead 
// of the number. 
// For numbers which are multiples of both 3 and 5, 
// output "FizzBuzz".
// 
// Example Input:
// 16 
// 
// Expected Output:
// 1
// Fizz
// Buzz
// 7
// Fizz
// 11
// 13
// FizzBuzz


namespace FizzBuzzProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            int inputMaxNumber = Convert.ToInt32(Console.ReadLine());   // Convert the user input to an integer


            // Loop through odd numbers from 1 up to the given input number
            for (int iterateNumber = 1; iterateNumber < inputMaxNumber; iterateNumber += 2)
            {

                if (iterateNumber % 3 == 0 && iterateNumber % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz" + " " + Convert.ToString(iterateNumber));

                }
                else if (iterateNumber % 3 == 0)
                {

                    Console.WriteLine("Fizz" + " " + iterateNumber);

                }
                else if (iterateNumber % 5 == 0)
                {

                    Console.WriteLine("Buzz" + " " + iterateNumber);

                }
                else 
                {
                    Console.WriteLine(iterateNumber);

                }

            }

        }

    }


}

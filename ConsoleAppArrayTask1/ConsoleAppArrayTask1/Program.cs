// (Task 1/3)
// Intermediate Challenges
// 1. Array Rotation (modified task description)
//
// Example:
//
// Input list: [1, 2, 3, 4, 5]
// Shifts: 2
//
// Output list: [4, 5, 1, 2, 3]
//
//
// * The task:
//      -- select a current location index from Array and select a target index
//      -- swap the current index value with the target index value


using System.Collections;       // Required for using ArrayList

namespace MyArrayProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the inputIndexOfNumber: ");
            int inputIndexOfNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the inputGoalIndexOfNumber: ");
            int inputGoalIndexOfNumber = Convert.ToInt32(Console.ReadLine());


            // Initialize an ArrayList with values.
            Console.WriteLine("");
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(1);
            myArrayList.Add(2);
            myArrayList.Add(3);
            myArrayList.Add(4);
            myArrayList.Add(5);

            //Console.WriteLine(myArrayList.ToString());


            // Display the original list before swapping.
            for (int i = 0; i < myArrayList.Count; i++)
            {

                Console.WriteLine(myArrayList[i]);

            }

            Console.WriteLine("");
            //Console.WriteLine(myArrayList.IndexOf(5));


            // Store values at the selected indexes for swapping.
            int tempIndexValue = Convert.ToInt32(myArrayList[inputIndexOfNumber]);

            int tempGoalIndexValue = Convert.ToInt32(myArrayList[inputGoalIndexOfNumber]);


            // Swap the values at the specified indexes.
            myArrayList[inputGoalIndexOfNumber] = tempIndexValue;

            myArrayList[inputIndexOfNumber] = tempGoalIndexValue;


            // Display the modified list after swapping.
            for (int i = 0; i < myArrayList.Count; i++)
            {

                Console.WriteLine(myArrayList[i]);

            }




            Console.WriteLine("\n---");
            // (Task 2/3)
            // 2. Two Sum Problem (modified task description)
            //
            // Example:
            //
            // array: [2, 5, 7, 9]
            // target: 11
            // 
            // output: [0, 2] 
            //
            // Because array[0] + array[3] equals 11
            //
            //
            // * The task:
            //      -- select a current location index from Array and select a target index
            //      -- add the current index value to the target index value


            Console.WriteLine("Enter the inputIndexOfNumber: ");
            int inputIndexOfNumber2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the inputGoalIndexOfNumber: ");
            int inputGoalIndexOfNumber2 = Convert.ToInt32(Console.ReadLine());


            // Initialize an ArrayList with values.
            Console.WriteLine("");
            ArrayList myArrayList2 = new ArrayList 
            { 
                2,
                5,
                7,
                9
            };

            //Console.WriteLine(myArrayList2.ToString());


            // Display the original list.
            for (int k = 0; k < myArrayList2.Count; k++)
            {

                Console.WriteLine(myArrayList2[k]);

            }


            // Retrieve values at the specified indexes.
            int tempIndexValue2 = Convert.ToInt32(myArrayList2[inputIndexOfNumber2]);

            int tempGoalIndexValue2 = Convert.ToInt32(myArrayList2[inputGoalIndexOfNumber2]);


            // Compute the sum of the selected values.
            int sumOfValues = tempIndexValue2 + tempGoalIndexValue2;
           

            Console.WriteLine("");
            Console.WriteLine(tempIndexValue2 + " " + tempGoalIndexValue2);
            Console.WriteLine(sumOfValues);




            Console.WriteLine("\n---");
            // (Task 3/3)
            // 3. Task
            //
            // * The task
            //
            //      -- put the ordered list into a new list
            //      -- the new list should be in the reverse order
            //      -- print out the new list


            Console.WriteLine("");

            // Initialize an ArrayList with ordered numbers.
            ArrayList newArrayList = new ArrayList() 
            {
                11,
                12,
                13,
                14,
                15
            };


            // Display the original list.
            for (int j = 0; j < newArrayList.Count; j++)
            {

                Console.WriteLine(newArrayList[j]);

            }


            // Create a new ArrayList to store the reversed values.
            ArrayList newNewArrayList = new ArrayList();


            // Copy elements from the original list to the new list in reverse order.
            for (int i = newArrayList.Count - 1; i >= 0; i--)
            {

                //Console.WriteLine(newArrayList[i]);

                newNewArrayList.Add(newArrayList[i]);


            }


            Console.WriteLine("");

            // Display the new list.
            for (int k = 0; k < newNewArrayList.Count; k++)
            {

                Console.WriteLine(newNewArrayList[k]);

                
            }


        }

    }


}

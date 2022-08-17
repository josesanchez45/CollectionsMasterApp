using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //Done: Create an integer Array of size 50
            var fiftyArray = new int[50];

            ////done: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(fiftyArray);

            ////done: Print the first number of the array
            Console.WriteLine($"{fiftyArray[0]}");
            ////done: Print the last number of the array            
            Console.WriteLine($"{fiftyArray[fiftyArray.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            ////UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(fiftyArray);
            Console.WriteLine("-------------------");

            ////done: Reverse the contents of the array and then print the array out to the console.
            ////Try for 2 different ways
            ///*  1) First way, using a custom method => Hint: Array._____(); 
            //    2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            //*/
            Array.Reverse(fiftyArray);

            //Console.WriteLine("All Numbers Reversed:");
            NumberPrinter(fiftyArray);
            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine();

            ////Done: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");

            ThreeKiller(fiftyArray);

            NumberPrinter(fiftyArray);


            ////TODO: Sort the array in order now
            ///*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(fiftyArray);

            NumberPrinter(fiftyArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Done: Create an integer List
            var numberList = new List<int>();

            //done: Print the capacity of the list to the console

            //foreach ( int number in numberList)
            //{
            //    Console.WriteLine($"{number}");
            //}
            Console.WriteLine("Capacity of list: ");
            Console.WriteLine(numberList.Capacity);
            //done: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numberList);

            //Done: Print the new capacity
            Console.WriteLine("Capacity of list populated: ");

            Console.WriteLine(numberList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            bool validNumber = int.TryParse(Console.ReadLine(), out int userGuess);

            NumberChecker(numberList, userGuess);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists


            NumberPrinter(numberList);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numberList);

            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            numberList.Sort();
            NumberPrinter(numberList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            
            NumberPrinter(numberList.ToArray());    

            //TODO: Clear the list
            numberList.Clear();
            Console.WriteLine("There are no numbers in my list: ");
            NumberPrinter(numberList);

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }

            }
        }

        private static void OddKiller(List<int> numberList)
        {
            for( int i = numberList.Count-1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.RemoveAt(i);
                }

            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool guess = false;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (searchNumber == numberList[i])
                {
                    Console.WriteLine("That number is present");
                    guess = true;
                    break;
                }

            }
            if (guess == false)
            {
                Console.WriteLine("The number is not in this list");
            }
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 51; i++)
            {
                numberList.Add(rng.Next(0, 51));
            }


        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(0, 51);
            }


        }

        private static void ReverseArray(int[] array)
        {

        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}

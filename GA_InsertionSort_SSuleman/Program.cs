using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_InsertionSort_SSuleman
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int size = 12; // Change the size of the array as needed
            int minValue = 1; // Change the minimum value as needed
            int maxValue = 200; // Change the maximum value as needed

            // Generate a random integer array of the specified size and range
            int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

            Console.WriteLine("Unsorted: " + String.Join(" ", randomArray));

            // Sort the randomArray using the Insertion Sort algorithm
            InsertionSort(randomArray);

            Console.WriteLine("Sorted: " + String.Join(" ", randomArray));
        }
       // Generates a random integer array of the specified size and range
        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            if (size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }

            int[] arr = new int[size];
            for (int currentIndex = 0; currentIndex < size; currentIndex++)
            {
                // Fill the array with random integers within the specified range
                arr[currentIndex] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }
     
        // A method that takes an array of integers as input and returns a sorted array as output
        public static int[] InsertionSort(int[] array)
        {
            // Loop through the array from the second element to the last element
            for (int currentIndex = 1; currentIndex < array.Length; currentIndex++)
            {
                // Store the current element in a temporary variable
                int currentValue = array[currentIndex];
                // Initialize a variable to store the index of the previous element
                int previousIndex = currentIndex - 1;
                // Loop through the sorted sublist from right to left
                // until the correct position for the current element is found or
                // the beginning of the sublist is reached using while loop
                while (previousIndex >= 0 && array[previousIndex] > currentValue)
                {
                    // Shift the larger element to the right by one position
                    array[previousIndex + 1] = array[previousIndex];
                    // Decrement the index of the previous element
                    previousIndex--;
                }
                // Insert the current element in the correct position
                array[previousIndex + 1] = currentValue;
            }
            // Return the sorted array
            return array;
        }  

    }
}

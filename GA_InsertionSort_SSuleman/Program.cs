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
            // One way to reduce the maximum nesting level inside a method is to invert an “if” statement.
            // This not only makes the code more readable but also reduces the number of unnecessary comparisons and shifts.
            // Another way to optimize the algorithm logic is to use pattern matching expressions to implement behavior based on types and property values.

            //Optimization can be achieved by replacing non-generic variants of container classes by their generic counterparts,
            // cutting down on boxing/unboxing, using generics.
            //Optimization is a crucial aspect of sorting algorithms in C#.
            //It can help reduce the time and space complexity of the algorithm, making it more efficient and faster.
            //The importance of optimization is particularly evident when dealing with large data sets.
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
        //The Insertion Sort algorithm is used to sort a list of elements by taking each element,
        //and adding it to the correct position in the list. 
        //The algorithm iterates through the list until the array is sorted.
        // A method that takes an array of integers as input and returns a sorted array as output
        public static int[] InsertionSort(int[] array)
        {
            // A main loop in C# is used to execute a block of code repeatedly until a certain condition is met.
            //A nested loop is a loop inside another loop. It is used to execute a block of code repeatedly
            //for each iteration of the outer loop.
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
                    //The comparisons and shifts are the core operations of the algorithm that ensure the sorted order of the elements.
                    //The comparisons determine the relative order of the elements, and
                    //the shifts move the elements to their appropriate positions in the sorted sublist.
                    //The comparison is used to determine the relative order of two elements in the collection.
                    //The comparison is used to determine whether one element is greater than, less than, or equal to another element.

                    // Shift the larger element to the right by one position
                    array[previousIndex + 1] = array[previousIndex];
                    //There are several sorting algorithms available, such as
                    //1.Selection Sort, the algorithm repeatedly selects the smallest (or largest) element from the unsorted portion of the list
                    //and swaps it with the first element of the unsorted part.
                    //This process is repeated for the remaining unsorted portion until the entire list is sorted.
                    //2. Merge Sort, the algorithm divides the input array into two halves, calls itself for the two halves, and then merges the two sorted halves. 
                    //The merge operation is the key process that ensures sorted order at each step.
                    //3.Quick Sort, the algorithm picks an element as a pivot and partitions the given array around the picked pivot.
                    //Quick Sort rpeatedly putting pivots in their actual position makes the array sorted.
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

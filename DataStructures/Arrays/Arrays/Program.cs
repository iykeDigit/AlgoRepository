using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = TwoNumberSum(new int[] { 5,4,9,12,11 }, 20);
            Console.WriteLine();
        }


        /// <summary>
        /// Delete even numbers from an array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static int[] DeleteEven(int[] arr, int size)
        {
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0) 
                {
                    arr[counter] = arr[i];
                    counter++;
                }

            }

            var temp = new int[counter];
            for (int j = 0; j < counter; j++)
            {
                temp[j] = arr[j];
            }

            arr = temp;

            return arr;
        }


        public static int[] mergeArrays(int[] arr1, int[] arr2, int arr1Size, int arr2Size)
        {
            int[] arr3 = new int[arr1Size + arr2Size];  // creating a new array
                                                        // Write your code here
            return arr3; // returning array
        }

        /// <summary>
        /// two number sum with hashset
        /// </summary>
        /// <param name="array"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public static int[] TwoNumberSum(int[] array, int targetSum) 
        {
            HashSet<int> nums = new HashSet<int>();
            foreach(int num in array) 
            {
                int potentialMatch = targetSum - num;
                if (nums.Contains(potentialMatch)) 
                {
                    return new int[] { potentialMatch, num };
                }
                else
                {
                    nums.Add(num);
                }

                }
            return new int[0];
        }

        public static int[] TwoNumberSums(int[] array, int targetSum) 
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right) 
            {
                int currentSum = array[left] + array[right];
                if(currentSum == targetSum) 
                {
                    return new int[] { array[left], array[right] };
                }
                else if(currentSum < targetSum) 
                {
                    left++;
                }
                else if(currentSum > targetSum) 
                {
                    right--;
                }
            }
            return new int[0];
        }
    }
}

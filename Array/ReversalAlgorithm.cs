using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class ReversalAlgorithm
    {
        //Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.
        //Custom Method.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;
            int d = 2;

            leftRotate(arr, d); // Rotate array by 2
            printArray(arr);
        }

        /* Function to left rotate arr[]
    of size n by d */
        static void leftRotate(int[] arr, int d)
        {
            if (d == 0)
                return;
            int n = arr.Length;
            //If in case d is greater than n
            d = d % n;
            ReversalArray(arr, 0, d-1);
            ReversalArray(arr, d, n-1);
            ReversalArray(arr, 0, n-1);
        }

        /* Function to reverse arr[] from
    index start to end*/
        static void ReversalArray(int[] arr,int start,int end)
        {
            int temp;
            while(start<end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        /*UTILITY FUNCTIONS*/
        /* function to print an array */
        static void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }

    }
}

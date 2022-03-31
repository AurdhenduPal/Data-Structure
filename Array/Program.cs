using System;

namespace Array
{
    class Program
    {
        //Write a function rotate(ar[], d, n) that rotates arr[] of size n by d elements.
        //Custom Method.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int size = arr.Length;
            int rotateElement = 5;

            int[] temp = new int[size];
            int nIndex = 0;

            for(int i=rotateElement;i<arr.Length;i++)
            {
                temp[nIndex] = arr[i];
                nIndex = nIndex + 1;
            }

            //Filling ignored element
            for(int i=0;i<rotateElement;i++)
            {
                temp[nIndex] = arr[i];
                nIndex = nIndex + 1;
            }

            Console.WriteLine("Old Array : "+ string.Join(",", arr));
            Console.WriteLine("New Array : "+ string.Join(",", temp));
            Console.ReadKey();
        }


    }
}

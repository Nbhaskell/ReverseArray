using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        // program that takes input 10 elements in the array and reverse the elements in the array without using any other array.

        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the array elements[" + i + "]:");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(arr);

            for(int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}

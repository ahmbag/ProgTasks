using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[10];

            for (int i = 0; i < array1.Length; i++) 
            { 
                array1[i] = i+1;
            }
            Console.WriteLine("array1");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = 10 - i;
            }
            Console.WriteLine("\narray2");
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }

            Random rnd = new Random();
            for (int i = 0; i < array3.Length; i++)
            {                
                array3[i] = rnd.Next(0, 10);
            }
            Console.WriteLine("\narray3");
            foreach (var item in array3)
            {
                Console.Write(item + " ");
            }

            return;
        }
    }
}

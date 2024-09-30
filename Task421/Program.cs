using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task421
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int biggest = 0;
            int smallest = 20;

            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(0, 10);
                if(biggest < array1[i])
                    biggest = array1[i];
                if(smallest > array1[i])
                    smallest = array1[i];
            }
            Console.WriteLine("\narray1");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nGrößte Zahl: " + biggest);
            Console.WriteLine("\nKleinste Zahl: " + smallest);
            int a = array1 [0];
            int b = array1 [9];

            array1 [0] = b;
            array1 [9] = a;
            Console.WriteLine("\narray1 changed");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }

            return;
        }
    }
}

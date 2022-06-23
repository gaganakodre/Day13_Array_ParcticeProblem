using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Array
{
    public class ArrayListWithGenerics
    {
        public void ToprintGeneric<T>(T[] inputArray)  //Generic Method
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-----------------------------------");
        }
    }
    //class program
    //{

    //    static void Main(string[] args)
    //    {
    //        int[] intArray = { 1, 2, 3, 4, 5 };
    //        double[] doubleArray = { 1.2, 2.1, 3.1, 4.5 };
    //        char[] charArray = { 'A', 'E', 'I', 'O' };
    //        program.toPrint<int>(intArray);
    //        program.toPrint<double>(doubleArray);
    //        program.toPrint<char>(charArray);


    //    }
    //    public static void toPrint<T>(T[] inputArray)
    //    {
    //        foreach (var elements in inputArray)
    //        {
    //            Console.WriteLine(elements);
    //        }
    //        Console.WriteLine("********************************");
    //    }

    //}
}

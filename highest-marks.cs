using System;

namespace callmethod
{
    public class Callmethod
    {
        public static void staticMethod(int[] integer)
        {
            int total=0;
            for (int i = 0; i < integer.Length; i++)
                total += integer[i];
            Console.WriteLine("Sum of all integers {0}", total);
        }
        public static void Main(string[] args)
        {
            int[] integer = new int[5];
            for (int i = 0; i < integer.Length; i++)
                integer[i] = Convert.ToInt32(Console.ReadLine());
            staticMethod(integer);
        }
    }
}
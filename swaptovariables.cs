using System;

namespace swappingtovars
{
    public class swap
    {
        public static void Swap(int l,int k)
        {
            int i;
            i = l;
            l = k;
            k = i;
            Console.WriteLine("L: {0}\n K: {1}",l,k);
        }
        public static void Main(string[] args)
        {
            int l,k;
            Console.WriteLine("L: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K: ");
            k = Convert.ToInt32(Console.ReadLine());
            Swap(l, k);
        }
    }
}
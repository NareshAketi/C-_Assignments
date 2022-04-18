
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace  GenericCollection
{
    class Crud
    {
        public void printarray(int[] integeraaray)
        {
            foreach (var item in integeraaray)
            {
                Console.Write("{0} ",item);
            }
        }
        public void printarray(string[] stringarray)
        {
            foreach (var item in stringarray)
            {
                Console.Write("{0} ", item);
            }
        }
        public void Display()
        {

        }
    }
    class Crud_Program
    {       
       static void Main(string[] args)
        {
            int[] integerarray = new int[10];
            int[] integerarray1 = new int[10];
            string[] stringarray = new string[10];
            string[] stringarray1 = new string[10];
            Console.WriteLine("Enter the 10 array elements");
            for (int i = 0; i < integerarray.Length; i++)
            {
                integerarray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the 10 String elements");
            for (int i = 0; i < stringarray.Length; i++)
            {
               stringarray[i] = Console.ReadLine();
            }
            Crud c1 = new Crud();
            Console.WriteLine("Array List are : ");
            c1.printarray(integerarray);
            Console.WriteLine();

            Console.WriteLine("\nString elements are :");
            c1.printarray(stringarray);
            Console.WriteLine();

            
            Array.Reverse(integerarray);
            Console.WriteLine("\nAfter Reversing the Array :");
            c1.printarray(integerarray);
            Console.WriteLine();


            Array.Sort(integerarray);
            Console.WriteLine("\nAfter Sorting the Array :");
            c1.printarray(integerarray);
            Console.WriteLine();

            
            Array.Clear(integerarray,1,5);
            Console.WriteLine("\nAfter Clearing the Array :");
            c1.printarray(integerarray);
            Console.WriteLine();

            
            Array.Copy(integerarray,integerarray1,10);
            Console.WriteLine("\nAfter Copying the Array :");
            c1.printarray(integerarray);
            Console.WriteLine();

           
            Array.Reverse(stringarray);
            Console.WriteLine("\nAfter Reversing the Array :");
            c1.printarray(stringarray);
            Console.WriteLine();

          
            Array.Sort(stringarray);
            Console.WriteLine("\nAfter Sorting the Array :");
            c1.printarray(stringarray);
            Console.WriteLine();

            
            Array.Clear(stringarray,1,5);
            Console.WriteLine("\nAfter Clearing the Array : ");
            c1.printarray(stringarray);
            Console.WriteLine();

            Array.Copy(stringarray,stringarray1,10);
            Console.WriteLine("\nAfter Copying the Array :");
            c1.printarray(stringarray);
            Console.WriteLine();


            Console.ReadKey();
        }
    }

    
}


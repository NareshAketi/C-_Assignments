
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GenericCollection
{
    class employeedetails
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSal { get; set; }

    }
    internal class arrayList
    {
        public static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            employeedetails ed1 = new employeedetails();
            Console.WriteLine("Enter employee Id");
            ed1.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee Name");
            ed1.EmpName = Console.ReadLine();
            Console.WriteLine("Enter employee salary");
            ed1.EmpSal = Convert.ToInt32(Console.ReadLine());
            al.Add(ed1);
            foreach (employeedetails ed in al)
            {
                Console.WriteLine(ed.EmpId + " " + ed.EmpName + "" + ed.EmpSal);
            }
            Console.ReadKey();
        }
    }
}
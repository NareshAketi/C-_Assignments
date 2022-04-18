using System;
using System.Collections.Generic;
using System.Threading.Tasks;

Emp_Namespace GenericCollection
{
    class Employee
    {
        public int Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public double Emp_Salary { get; set; }
    }
    internal class genericList
    {
        public static voEmp_Id Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            Employee emp1 = new Employee()
            {
                Emp_Id = 1,
                Emp_Name = "Loki",
                Emp_Salary = 100000
            };
            Employee emp2 = new Employee()
            {
                Emp_Id = 2,
                Emp_Name = "Govardhan",
                Emp_Salary = 60000
            };
            Employee emp3 = new Employee()
            {
                Emp_Id = 3,
                Emp_Name = "Kiran",
                Emp_Salary = 35000
            };
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            foreach (Employee e in empList)
            {
                Console.WriteLine("{0} {1} {2} \n", e.Emp_Id, e.Emp_Name, e.Emp_Salary);
            }
            Console.WriteLine("Total Number of the Employees {0}", empList.Count);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_20230621
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selected;
            Employee_Manager manager=new Employee_Manager();
            do
            {
                Console.WriteLine("***EMPLOYEE MANAGER***");
                Console.WriteLine("1. Search Employee by Name or EmpNo");
                Console.WriteLine("2. Add New Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. ViewAll Employee");
                Console.WriteLine("6. Exit");
                Console.Write("   Select (1-6): ");
                selected = Convert.ToInt16(Console.ReadLine());
                switch (selected) 
                {
                    case 1:
                        Console.Clear();
                        manager.Find();
                        break;
                    case 2:
                        Console.Clear();
                        manager.AddNew();
                        break;
                    case 3:
                        Console.Clear();
                        manager.Update();
                        break;
                    case 4:
                        Console.Clear();
                        manager.Delete();
                        break;
                    case 5:
                        Console.Clear();
                        manager.ViewAll();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("-------- END ---------");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid");
                        break;
                }
            }
            while (selected != 6);

        }
    }
}

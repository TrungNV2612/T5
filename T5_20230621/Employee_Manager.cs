using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace T5_20230621
{
    internal class Employee_Manager:Manager
    {
        private string Version = "2.00";
        private string name = "Employee_Manager";
        public int MAX = 10;
        private Employee[] employees;

        public Employee_Manager() :base()
        {
            Console.WriteLine(this.name + " " + this.Version);
            this.employees = new Employee[]{
                new Employee("E001", "hoangnm", "hoangnm@gmail.com"),
                new Employee("E002", "namph", "namph@gmail.com"),
                new Employee("E003", "minhnv", "minhnv@gmail.com"),
            };
                
        }
        public override void AddNew()
        {
            int indexmax=employees.Length;            
            Employee employeeenter = EnterArr();
            Employee[] ArrTrunggian = employees;
            employees = new Employee[indexmax + 1];
            for(int i = 0; i <= indexmax; i++)
            {
                if ( i<indexmax) 
                {
                    employees[i] = ArrTrunggian[i];    
                }
                else
                {
                    employees[i] = employeeenter;
                }                
            }         
            
        }
        public override void Delete()
        {
            Console.WriteLine("Enter EmpNo or Name: ");
            string searchkey = Console.ReadLine();
            for (int i = 0;i < employees.Length;i++) 
            {
                if (employees[i].GetNo().Equals(searchkey) || employees[i].GetName().Equals(searchkey))
                {
                    Employee[] arr_trunggian = employees;
                    int indexmax = employees.Length;
                    employees = new Employee[indexmax - 1];
                    for (int j = 0; j < indexmax-1; j++)
                    {
                        if (j<i)
                        {
                            employees[j] = arr_trunggian[j];
                        }
                        else
                        {
                            employees[j] = arr_trunggian[j + 1];
                        }
                    }
                }               

            }


        }
        public override void Update()
        {
            Console.WriteLine("Enter EmpNo or Name: ");
            String searchkey=Console.ReadLine();
            Employee employeeenter = EnterArr();
            foreach (Employee emp in employees) 
            {
                if ( emp.GetNo().Equals(searchkey) || emp.GetName().Equals(searchkey) )
                {
                    emp.SetObj(employeeenter);
                }
            }
        }
        public override void Find() 
        {
            Console.Write("Enter EmpNo or Name: ");
            String searchKey = Console.ReadLine();            

            // search
            Employee[] result = new Employee[MAX];
            int count = 0;
            foreach (Employee emp in employees)
            {
                if (emp.GetNo().Equals(searchKey) || emp.GetName().Equals(searchKey))
                {
                    result[count++] = emp;
                    //count++;
                }
            }

            // print
            if (count > 0)
            {
                PrintList(result);
            }
            else
            {
                Console.WriteLine("Not Found!");
            }
                        
        }


        private void PrintList(Employee[] arr)
        {
            foreach (Employee item in arr)
            {
                if (item != null)
                {
                    Console.WriteLine(item);
                }
            }
        }
        private Employee EnterArr()
        {
            Console.WriteLine("Moi ban nhap Record ");
            string[] record = Console.ReadLine().Split(',');
            string no = record[0];
            string name= record[1];
            string  email= record[2];
            Employee EmployeeEnter = new Employee(no, name, email);
            return EmployeeEnter;
        }
        public override void ViewAll()
        {
            PrintList(this.employees);
        }
    }
}

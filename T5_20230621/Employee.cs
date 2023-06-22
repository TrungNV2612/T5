using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_20230621
{
    internal class Employee
    {
        public String no;
        public String name;
        public String email;

        //geter and constructor
        public String GetNo()
        {
            return this.no;
        }

        public String GetName()
        {
            return this.name;
        }

        public String GetEmail()
        {
            return (this.email);
        }

        public void SetObj(Employee Enter)
        {
            this.no = Enter.no;
            this.name = Enter.name;
            this.email = Enter.email;
        }

        public Employee(string no, string name, string email)
        {
            this.no = no;
            this.name = name;
            this.email = email;
        }

        public override string ToString()
        {
            return no + ", " + name + ", " + email;
        }

    }
}

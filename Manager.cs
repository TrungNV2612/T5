using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5_20230621
{
    internal class Manager
    {
        private string Version = "1.00";
        private string name = "Class Manager";
        public Manager() 
        { 
            Console.WriteLine(this.name + " " + this.Version); 
        }
        public virtual void AddNew()
        { 
            Console.WriteLine("AddNew"); 
        }
        public virtual void Update()
        {
            Console.WriteLine("Update");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Delete");
        }
        public virtual void Find()
        {
            Console.WriteLine("Find");
        }
        public virtual void ViewAll()
        {
            Console.WriteLine("ViewAll");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    internal class Person
    {
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }
        public Person(int age,int salary,string name) 
        {
            Age= age;
            Salary= salary;
            Name= name;
        }
    }
}

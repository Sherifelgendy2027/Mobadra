using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask
{
    delegate int Comparison<in T>(T x, T y);
    internal class Sorter<T>
    {


        //public int CompareByName(Person name1, Person name2)
        //{
        //    int res;
        //    res = String.Compare(name2.Name, name1.Name, StringComparison.OrdinalIgnoreCase);
        //    return res;
        //}
        //public int CompareBySalary(Person salary1, Person salary2)
        //{
        //    if (salary1.Salary < salary2.Salary) return 2;
        //    else if (salary1.Salary > salary2.Salary) return 1;
        //    else return 0;
        //}
        //public int CompareByAge(Person age1, Person age2)
        //{
        //    if (age1.Age < age2.Age) return 2;
        //    else if (age1.Age > age2.Age) return 1;
        //    else return 0;
        //}
        //public void Conmpare (T x,T y, Comparison<T> comparison)
        //{
        //    Console.WriteLine(comparison(x,y));
        //}
        public int Compare(T x, T y, Comparison<T> comparison)
        {
            return comparison(x, y);
        }
    }
    class Comparisons
    {
        public static int CompareByName(Person person1, Person person2)
        {
            return String.Compare(person1.Name, person2.Name, StringComparison.OrdinalIgnoreCase);
        }

        public static int CompareBySalary(Person person1, Person person2)
        {
            if (person1.Salary < person2.Salary) return -1;
            else if (person1.Salary > person2.Salary) return 1;
            else return 0;
        }
        public static int CompareByAge(Person person1, Person person2)
        {
            if (person1.Age < person2.Age) return -1;
            else if (person1.Age > person2.Age) return 1;
            else return 0;
        }
    }
}

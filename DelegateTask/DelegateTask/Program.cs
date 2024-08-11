namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Calculator
            //while (true)
            //{
            //    int operation, x, y;
            //    Console.WriteLine("Choose the operation you want to perform");
            //    Console.WriteLine("1- Add  2- multiply  3- subtract  4- devision  5- for EXIT");
            //    if (!int.TryParse(Console.ReadLine(), out operation))
            //    {

            //    }
            //    if (operation == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("enter the frist num");

            //    if (!int.TryParse(Console.ReadLine(), out x))
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //    Console.WriteLine("enter the second num ");
            //    if (!int.TryParse(Console.ReadLine(), out y))
            //    {
            //        Console.WriteLine("Invalid input");
            //    }
            //    Calculator calculator = new Calculator();
            //    switch(operation)
            //    {

            //        case 0:
            //            Console.WriteLine("invalid operation");
            //            break;
            //        case 1:
            //            calculator.PerformOperation(x, y, calculator.Sum); 
            //            break;
            //        case 2:
            //            calculator.PerformOperation(x, y, calculator.Multiply);
            //            break;
            //        case 3:
            //            calculator.PerformOperation(x, y, calculator.Subtract);
            //            break;
            //        case 4:
            //            calculator.PerformOperation(x, y, calculator.Divide);
            //            break;


            //    }               
            //} 
            #endregion
            //Person person = new Person(20, 9000, "ahmed");
            //Person person1 = new Person(21, 8000, "Ahmed");
            //Sorter<Person> sorter = new Sorter<Person>();
            //sorter.Compare(person, person1, sorter.CompareByName);
            Person person = new Person(20, 9000, "ahmed");
            Person person1 = new Person(21, 8000, "Ahmed");

            Sorter<Person> sorter = new Sorter<Person>();

            // Compare by Name
            int nameComparison = sorter.Compare(person, person1, Comparisons.CompareByName);
            Console.WriteLine("Name Comparison: " + nameComparison);

            // Compare by Salary
            int salaryComparison = sorter.Compare(person, person1, Comparisons.CompareBySalary);
            Console.WriteLine("Salary Comparison: " + salaryComparison);

            // Compare by Age
            int ageComparison = sorter.Compare(person, person1, Comparisons.CompareByAge);
            Console.WriteLine("Age Comparison: " + ageComparison);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            
            Console.WriteLine("Sum:");
            var sum = numbers.Sum();
            Console.WriteLine(sum);
            
            //TODO: Print the Average of numbers
            
            Console.WriteLine("Average:");
            var average = numbers.Average();
            Console.WriteLine(average);
            
            //TODO: Order numbers in ascending order and print to the console
            
            Console.WriteLine("Ascending:");
            var ascendingNumbers = numbers.OrderBy(num => num);
            ascendingNumbers.ToList().ForEach(num => Console.WriteLine(num));
            
            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("Descending:");
            var descendingNumbers = numbers.OrderByDescending(num => num);
            descendingNumbers.ToList().ForEach(num => Console.WriteLine(num));
            
            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Greater than 6:");
            var greaterThan6 = numbers.Where(num => num > 6);
            greaterThan6.ToList().ForEach(num => Console.WriteLine(num));
            
            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("Only 4:");
            var only4 = numbers.OrderBy(num => num).Take(4);
            only4.ToList().ForEach(num => Console.WriteLine(num));
            
            //TODO: Change the value at index 4 to your age, then print the numbers in descending order
    
            Console.WriteLine("Age at index 4:");
            var ageIndex4 = numbers;
            ageIndex4[4] = 21;
            ageIndex4.OrderByDescending(num => num).ToList().ForEach(num => Console.WriteLine(num));
            
            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            
            Console.WriteLine("Name starts with C or S:");
            var nameStartsWithCOrS = employees.Where(emp => emp.FirstName[0] == 'C' || emp.FirstName[0] == 'S');
            nameStartsWithCOrS.ToList().ForEach(emp => Console.WriteLine(emp.FullName));
            
            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            
            Console.WriteLine("Age over 26:");
            var ageOver26 = employees.Where(emp => emp.Age > 26).OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);
            ageOver26.ToList().ForEach(emp => Console.WriteLine(emp.FullName + " " + emp.Age));
            
            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            
            Console.WriteLine("Sum of experience:");
            var sumOfExperience = employees.Where(emp => emp.YearsOfExperience <= 10).Where(x => x.Age > 26);
            Console.WriteLine(sumOfExperience.Sum(emp => emp.YearsOfExperience));
            
            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.

            Console.WriteLine("Sum of experience:");
            var averageExperience = employees.Where(emp => emp.YearsOfExperience <= 10).Where(x => x.Age > 26);
            Console.WriteLine(averageExperience.Average(emp => emp.YearsOfExperience));
            
            //TODO: Add an employee to the end of the list without using employees.Add()
            
            employees.Append(new Employee { FirstName = "Jack", LastName = "Raiden", Age = 32, YearsOfExperience = 26 });

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}

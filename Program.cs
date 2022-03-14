using System.Text.RegularExpressions;
using ClassLibrary;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static List<Person> GetEmployees()
        {
            List<Person> employees = new List<Person>()
            {
                new Person(new DateTime(1990, 2, 2), "Bill", "Wick"),
                new Person(new DateTime(1995, 6, 3), "John", "Wick"),
                new Person(new DateTime(1996, 4, 3), "Bob", "Wick"),
                new Person(new DateTime(2001, 2, 2), "Bill", "Smith"),
                new Person(new DateTime(2000, 2, 2), "John", "Smith"),
                new Person(new DateTime(2005, 2, 2), "Bob", "Smith"),
                new Person(new DateTime(2003, 2, 2), "Ed", "Smith")
            };
            return employees;
        }
        #region
        //static void DisplayElements(List<int> list)
        //{
        //    Console.WriteLine("** List **");
        //    foreach (int element in list)
        //    {
        //        Console.Write($"{ element}, ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        static void Main(string[] args)
        {
            #region
            //    ExcelFile excelFile = new ExcelFile();

            //    excelFile.CreatedOn = DateTime.Now;
            //    excelFile.FileName = "excel-file";

            //    excelFile.GenerateReport();

            //    WordDocumentFile wordDocumentFile = new WordDocumentFile();
            //    wordDocumentFile.CreatedOn = DateTime.Now;
            //    wordDocumentFile.FileName = "word-file";

            //    wordDocumentFile.Present();

            //Shape[] shapes = { new Circle(), new Rectangle(), new Triangle(), };

            //foreach(Shape shape in shapes)
            //{
            //    shape.Draw();
            //}

            //List<int> intList = new List<int>() { 6, 1, 20, 3, 45, 60, 100, 2};
            //DisplayElements(intList);

            //Console.WriteLine("New element: ");
            //string userInput = Console.ReadLine();
            //int intValue = int.Parse(userInput);
            //intList.Add(intValue);
            //DisplayElements(intList);

            //Console.WriteLine("Remove range");
            //intList.RemoveRange(1, 2);
            //DisplayElements(intList);

            //Console.WriteLine("Sort");
            //intList.Sort();
            //DisplayElements(intList);
            #endregion

            List<Person> employees = GetEmployees();
            List<Person> youngEmployees = new List<Person>();
            foreach (Person employee in employees)
            {
                if (employee.GetDateOfBirth() > new DateTime(2000, 1, 1))
                {
                    youngEmployees.Add(employee);
                }
            }
            Console.WriteLine($"Young employees count: {youngEmployees.Count}");
            
            Person Bob = null;
            foreach (Person youngEmployee in youngEmployees)
            {
                if (youngEmployee.FirstName == "Bob")
                {
                    Bob = youngEmployee;
                    break;
                }
                if (Bob != null)
                {
                    Bob.SayHi();
                }
                else
                {
                    Console.WriteLine("Bob not found.");
                }
            }
        }
    }
}

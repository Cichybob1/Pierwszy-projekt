using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Person
    {
        public string FirstName;
        public string LastName;

        private DateTime dateofBirth;
        private string contactnumber;

        public static int Count = 0;

        public DateTime DateofBirth
        {
            get { return dateofBirth; }
            set { dateofBirth = value; }
        }
        public string ContactNumber
        {
            get { return contactnumber; }
            set
            {   
                if (value.Length < 9)
                {
                    Console.WriteLine("Invalid contact number");
                }
                else
                {
                    contactnumber = value;
                }
            }
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Count++;
        }

        public Person(DateTime dateofBirth, string firstName, string lastName) : this(firstName, lastName)
        {
            SetDateoOfBirth(dateofBirth);
        }

        public void SetDateoOfBirth(DateTime date) // w nawiasie przekazanie argumentu - typ DateTime i jego nazwę.
        {
            if (date > DateTime.Now)
            {
                Console.WriteLine("Invalid date of birth");
            }
            else
            {
                dateofBirth = date;
            }
        }
        public DateTime GetDateOfBirth() => dateofBirth;
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {FirstName}, {GetDateOfBirth()}");
        }
    }
}

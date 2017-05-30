using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello GIT!");

            var person = new Person()
            {
                FirstName = "Amitava",
                LastName = "Karan"
            };

            var company = new Company
            {
                CompanyId = 1,
                CompanyName = "Test Company"
            };

            Console.ReadKey(true);
        }
    }

    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Country { get; set; }

        public IEnumerable<string> LanguageKnown { get; set; }
        
        public string PinCode { get; set; }
    }

    class Company
    {
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string Website { get; set; }
    }
}

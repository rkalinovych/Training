using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Training_.Net
{
    class Program
    {

        static void Main()
        {
            /*
            int[] numbers = { 2, 3, 4, 5 };
            var query = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", query));
            */

            Random rnd = new Random();


            var person1 = new Person()
            {
                Id = Guid.NewGuid(),
                Age = rnd.Next(18, 25),
                Sex = "Male",
                Status = "Student",
                Name = "person1"
            };
            var person2 = new Person()
            {
                Id = Guid.NewGuid(),
                Age = rnd.Next(20, 60),
                Sex = "Male",
                Status = "Worker",
                Name = "person2"
            };
            var person3 = new Person()
            {
                Id = Guid.NewGuid(),
                Age = rnd.Next(1, 60),
                Sex = "Female",
                Status = "Jobless",
                Name = "person3"
            };
            var person4 = new Person()
            {
                Id = Guid.NewGuid(),
                Age = rnd.Next(18, 25),
                Sex = "Female",
                Status = "Student",
                Name = "person4"
            };
            var person5 = new Person() 
            {
                Id = Guid.NewGuid(),
                Age = rnd.Next(60, 80),
                Sex = "Male",
                Status = "Pensioner",
                Name = "person5"
            };

            List<Person> people = new List<Person>() { person1, person2, person3, person4, person5 };
            IEnumerable<Person> IEnumerableList = people;


            IEnumerable<Person> Query1 = IEnumerableList.Where(x => x.Age < 40);
            IEnumerable<Person> Query2 = IEnumerableList.Where(x => x.Sex == "Male");
            IEnumerable<Person> Query3 = IEnumerableList.Where(x => x.Sex == "Female");
            IEnumerable<Person> Query4 = IEnumerableList.Where(x => x.Status == "Student");
            IEnumerable<Person> Query5 = IEnumerableList.Where(x => x.Age > 24 && x.Sex == "Male");
            IEnumerable<Person> Query6 = IEnumerableList.Where(x => x.Name == "person1" && x.Name == "person2");
            IEnumerable<Person> Query7 = (IEnumerable<Person>)IEnumerableList.Select(x => x.Id);
            IEnumerable<Person> Query8 = (IEnumerable<Person>)IEnumerableList.Select(x => x.Name == "person1" && x.Sex == "Female" );
            IEnumerable<Person> Query9 = (IEnumerable<Person>)IEnumerableList.Select(x => x.Status == "Jobless" && x.Sex == "Female");
            IEnumerable<Person> Query10 = (IEnumerable<Person>)IEnumerableList.Select(x => x.Name == "person1" && x.Sex == "Female");


        }

    }
}

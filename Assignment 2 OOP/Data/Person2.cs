using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP.Data
{
    internal class Person2
    {
        public string Name;
        public int Age;

     
        public Person2(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public  Person FindOldest(Person[] persons)
        {
            Person oldestPerson = persons[0];

            for (int i = 1; i < persons.Length; i++)
            {
                if (persons[i].age > oldestPerson.age)
                {
                    oldestPerson = persons[i];
                }
            }

            return oldestPerson;
        }
    }
    }
}

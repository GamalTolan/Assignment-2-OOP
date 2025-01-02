using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP.Data
{
    public struct Person
    {
        public string name;
        public int age;

        public Person(string _name, int _age)
        {
            name = _name;
            age = _age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}

using Assignment_2_OOP.Data;
using System.Xml.Linq;

namespace Assignment_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Define a struct "Person" with properties "Name" and "Age"

            //Person[] members = new Person[3];
            //members[0] = new Person("Gamal", 20);
            //members[1] = new Person("Mona", 25);
            //members[2] = new Person("Ali", 30);

            //Console.WriteLine("Persons details");
            //foreach (var person in members)
            //{
            //    person.Display();
            //}

            #endregion

            #region Create a struct called "Point" to represent a 2D point with properties "X" and "Y".

            //Console.WriteLine("Enter the first point (X1 , Y1)");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter the second point (X2 , Y2)");
            //double x2 = Convert.ToDouble(Console.ReadLine());
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = Point.Distance(point1, point2);
            //Console.WriteLine($"The distance between ({x1},{y1}) , ({x2},{y2}) = {distance}");

            #endregion

            #region Create a struct called "Person" with properties "Name" and "Age".

            Person2[] person2 = new Person2[3];

            Console.Write("Enter the name of person 1: ");
            person2[0].Name = Console.ReadLine();
            Console.Write("Enter the age of person 1: ");
            person2[0].Age = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of person 2: ");
            person2[1].Name = Console.ReadLine();
            Console.Write("Enter the age of person 2: ");
            person2[1].Age = int.Parse(Console.ReadLine());

            Console.Write("Enter the name of person 3: ");
            person2[2].Name = Console.ReadLine();
            Console.Write("Enter the age of person 3: ");
            person2[2].Age = int.Parse(Console.ReadLine());

            Person2 oldestPerson = Person2.FindOldest(person2);

            Console.WriteLine($"Oldest Person is : {oldestPerson.Name} , Age :{oldestPerson.Age}");
        }
        // ايه المشكله ؟
        #endregion

    }
    }
}
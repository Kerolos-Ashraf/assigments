using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace assigment1_oop
{
    internal class Program
    {
        #region Q1
        //Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

        //enum WeekDays
        //{
        //    Monday,
        //    Tuesday,
        //    Wednesday,
        //    Thursday,
        //    Friday,
        //    Saturday,
        //    Sunday
        //}
        #endregion
        #region Q2
        ////Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

        //internal struct person
        //{
        //    public string Name { get; set; }
        //    public int Age { get; set; }
        //    public person(string _name , int _age) 
        //    {
        //        Name = _name;
        //        Age = _age;
        //    }
        //    public void Display()
        //    {
        //        Console.WriteLine($"Name: {Name}, Age: {Age}");
        //    }
        //}

        #endregion
        #region Q3
        //Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        //enum Season
        //{
        //    Spring,
        //    Summer,
        //    Autumn,
        //    Winter
        //}
        #endregion
        #region Q4
        /*4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
*/
        //[Flags]
        //enum Permissions
        //{
        //    None = 0,
        //    Read = 1,
        //    Write = 2,
        //    Delete = 4,
        //    Execute = 8
        //}

        #endregion
        #region Q5
        //5. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //enum Colors
        //{
        //    Red,
        //    Green,
        //    Blue
        //}

        #endregion
        #region Q6
        //Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

        //internal struct Point
        //{
        //  public double X { get; set; }
        //  public double Y { get; set; }

        //}
        #endregion
        #region Q7
        //Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        //struct Person
        //{
        //    public string Name;
        //    public int Age;

        //    public Person(string name, int age)
        //    {
        //        Name = name;
        //        Age = age;
        //    }
        //}
        #endregion

        /* PART 2 */

        #region Q1
        //Design and implement a Class for the employees in a company:
        //Employee is identified by an ID, Name, security level, salary, hire date and Gender

        //class Employee()
        //{
        //    public int ID;
        //    public string Name;
        //    public int SecurityLevel;
        //    public double Salary;
        //    public DateTime HireDate;
        //public override string ToString()
        //{
        //    return $"ID: {ID}\n" +
        //           $"Name: {Name}\n" +
        //           $"Salary: {String.Format("{0:C}", Salary)}\n" +  // C for currency
        //           $"Hire Date: {HireDate}\n" +
        //           $"Security Level: {SecurityLevel}";
        //}
        //}
        #endregion
        #region Q2
        //Develop a Class to represent the Hiring Date Data:
        //consisting of fields to hold the day, month and Years.
        //class HireDate
        //{

        //    public int Day { get; set; }
        //    public int Month { get; set; }
        //    public int Year { get; set; }

        //}
        #endregion
        #region Q3
        //We need to restrict the Gender field to be only M or F [Male or Female] 
        //public enum Gender
        //{
        //    Male,   // M
        //    Female  // F
        //}
        #endregion
        #region Q4
        // Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
        //public enum SecurityLevel
        //{
        //    Guest,
        //    Developer,
        //    Secretary,
        //    DBA
        //}
        #endregion
        #region Q5
        // We want to provide the Employee Class to represent Employee data in a string Form (override ToString ()), display employee salary in a currency format. [ use String.Format Function]
        //public override string ToString()
        //{
        //    return $"ID: {ID}\n" +
        //           $"Name: {Name}\n" +
        //           $"Gender: {Gender}\n" +
        //           $"Salary: {String.Format("{0:C}", Salary)}\n" +  // C for currency
        //           $"Hire Date: {HireDate}\n" +
        //           $"Security Level: {SecurityLevel}";
        //}
        #endregion
        #region Q6
        //Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
        // IN MAIN
        #endregion












        static void Main(string[] args)
        {
            #region Q1
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))      
            //{
            //    Console.WriteLine(day);
            //}
            #endregion

            #region Q2
            //person[] p = new person[3];
            //p[0] = new person("Kerlos" , 25);
            //p[1] = new person("Mena", 23);
            //p[2] = new person("Robert", 26);

            //foreach (person person in p)
            //{
            //    person.Display();
            //}
            #endregion

            #region Q3
            //Console.WriteLine("Enter a season");
            //string input = Console.ReadLine();

            //bool isValid = Enum.TryParse(input, true, out Season season);

            //if (isValid)
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring lasts from March to May.");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer lasts from June to August.");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn lasts from September to November.");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter lasts from December to February.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}

            #endregion

            #region Q4
            //Permissions userPermissions = Permissions.Read | Permissions.Write;
            //userPermissions |= Permissions.Execute;


            //userPermissions &= ~Permissions.Write;


            //Console.WriteLine("Current Permissions: " + userPermissions);

            //Console.WriteLine("Has Read? " + userPermissions.HasFlag(Permissions.Read));
            //Console.WriteLine("Has Write? " + userPermissions.HasFlag(Permissions.Write));
            //Console.WriteLine("Has Execute? " + userPermissions.HasFlag(Permissions.Execute));

            #endregion

            #region Q5
            //Console.Write("Enter a color name: ");
            //string userInput = Console.ReadLine();


            //bool isParsed = Enum.TryParse(userInput, true, out Colors color);

            //if (isParsed)
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput} is NOT a primary color.");
            //}
            #endregion

            #region Q6
            //Point p1 = new ();
            //Console.WriteLine("Enter coordinates for the first point: ");
            //Console.Write("x1: ");
            //p1.X =double.Parse(Console.ReadLine());
            //Console.Write("y1: ");
            //p1.Y = double.Parse(Console.ReadLine());

            //Point p2 = new();
            //Console.WriteLine("Enter coordinates for the first point: ");
            //Console.Write("x2: ");
            //p2.X = double.Parse(Console.ReadLine());
            //Console.Write("y2: ");
            //p1.Y = double.Parse(Console.ReadLine());

            //double Distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            //Console.WriteLine($"Distance between the two points: {Distance}");

            #endregion

            #region Q7
            //Person[] people = new Person[3];


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    people[i] = new Person(name, age);
            //}


            //Person oldest = people[0];
            //for (int i = 1; i < people.Length; i++)
            //{
            //    if (people[i].Age > oldest.Age)
            //    {
            //        oldest = people[i];
            //    }
            //}


            //Console.WriteLine($"The oldest person is: {oldest.Name}, Age: {oldest.Age}");
            #endregion

            /* PART 2 */

            #region Q1
            // IN namespace
            #endregion

            #region Q2
            // in namespace
            #endregion

            #region Q3
            // in namespace
            #endregion

            #region Q4
            // in namespace
            #endregion

            #region Q5
            // in namespace
            #endregion

            #region Q6
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee
            //{
            //    ID = 1,
            //    Name = "DBA User",
            //    Gender = Gender.M,
            //    Salary = 15000,
            //    HireDate = new HireDate { Day = 1, Month = 1, Year = 2020 },
            //    SecurityLevel = SecurityLevel.DBA
            //};

            //EmpArr[1] = new Employee
            //{
            //    ID = 2,
            //    Name = "Guest User",
            //    Gender = Gender.F,
            //    Salary = 8000,
            //    HireDate = new HireDate { Day = 15, Month = 3, Year = 2021 },
            //    SecurityLevel = SecurityLevel.Guest
            //};

            //EmpArr[2] = new Employee
            //{
            //    ID = 3,
            //    Name = "Security Officer",
            //    Gender = Gender.M,
            //    Salary = 20000,
            //    HireDate = new HireDate { Day = 20, Month = 7, Year = 2022 },
            //    SecurityLevel = SecurityLevel.All
            //};


            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //    Console.WriteLine("*******************");

            //}
            #endregion



        }
    }
            
}

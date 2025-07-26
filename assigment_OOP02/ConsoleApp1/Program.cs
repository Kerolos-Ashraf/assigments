using assigment_OOP02;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Define 3D Point Class and the basic Constructors (use chaining in constructors).
            //Point3D p1 = new Point3D();
            //Console.WriteLine(p1);
            #endregion

            #region Q2
            //Override the ToString Function to produce this output:
            //Point3D P = new Point3D(10, 10, 10);
            //Point3D P =new Point3D(10,10,10);
            //Console.WriteLine(P.ToString());
            #endregion

            #region Q3
            //Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            Console.WriteLine("Enter coordinates for Point P1:");

            // x1 using TryParse
            double x1;
            Console.Write("Enter X1: ");
            while (!double.TryParse(Console.ReadLine(), out x1))
            {
                Console.Write("Invalid input. Enter a valid number for X1: ");
            }

            // y1 using Parse
            double y1;
            Console.Write("Enter Y1: ");
            try
            {
                y1 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Invalid input. Defaulting Y1 to 0.\n");
                y1 = 0;
            }

            // z1 using Convert
            Console.Write("Enter Z1: ");
            double z1;
            try
            {
                z1 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.Write("Invalid input. Defaulting Z1 to 0.\n");
                z1 = 0;
            }

            Point3D P1 = new Point3D(x1, y1, z1);

            Console.WriteLine("\nEnter coordinates for Point P2:");

            // P2

            Console.Write("Enter X2: ");
            double x2;
            while (!double.TryParse(Console.ReadLine(), out x2))
            {
                Console.Write("Invalid input. Enter a valid number for X2: ");
            }

            Console.Write("Enter Y2: ");
            double y2;
            try
            {
                y2 = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("Invalid input. Defaulting Y2 to 0.\n");
                y2 = 0;
            }

            Console.Write("Enter Z2: ");
            double z2;
            try
            {
                z2 = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.Write("Invalid input. Defaulting Z2 to 0.\n");
                z2 = 0;
            }

            Point3D P2 = new Point3D(x2, y2, z2);

            Console.WriteLine($"P1 = {P1}");
            Console.WriteLine($"P2 = {P2}");
            #endregion

            #region Q4
            //Try to use ==
            //If(P1 == P2)   Does it work properly? 
            if(P1 == P2)
                Console.WriteLine("success");
            else
                Console.WriteLine("faild");
            // there is no error but absulolty (faild) so here it compare ref but we can overload operator==
#endregion

            #region Q5
//Define an array of points and sort this array based on X & Y coordinates.
//Point3D[] Points = new Point3D[]
//{
//    new Point3D(2, 3, 5),
//    new Point3D(4, 2, 5),
//    new Point3D(1, 6, 4),
//    new Point3D(10, 20, 30)
//};

//Array.Sort(Points, (p1, p2) =>
//{
//    int result = p1.X.CompareTo(p2.X);
//    if (result == 0)
//        result = p1.Y.CompareTo(p2.Y);
//    return result;
//});

//Console.WriteLine("AFTER SORTING");
//foreach(Point3D p in Points)
//{
//    Console.WriteLine(p.ToString());
//}

#endregion
            
            #region Q6
// I DONT UNDERSTAND THIS Q

#endregion
            
            // SECOND PROJECT
            
            #region SECOND PROJECT
                /*Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
                Modify the program so that you do not have to create an instance of class to call the four methods.
                */
                
                Console.WriteLine("Add: " + Maths.Add(10, 5));
                Console.WriteLine("Subtract: " + Maths.Subtract(10, 5));
                Console.WriteLine("Multiply: " + Maths.Multiply(10, 5));
                Console.WriteLine("Divide: " + Maths.Divide(10, 5));
            #endregion

            // third project

            #region third project

            #region Q1
            //Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            Duration d1 = new Duration();  
            Duration d2 = new Duration(1, 30, 45); 

            Console.WriteLine("Default Duration: " + d1);
            Console.WriteLine("Custom Duration: " + d2);

            #endregion

            #region Q2
            //Override All System.Object Members (ToString, Equals,GetHasCode)
            Duration d1 = new Duration(1, 30, 45);
            Duration d2 = new Duration(1, 30, 45);
            Duration d3 = new Duration(2, 0, 0);

            Console.WriteLine("d1 == d2: " + d1.Equals(d2));  // True
            Console.WriteLine("d1 == d3: " + d1.Equals(d3));  // False
            Console.WriteLine("d1 HashCode: " + d1.GetHashCode());
            Console.WriteLine("d2 HashCode: " + d2.GetHashCode()); // نفس HashCode زي d1
            Console.WriteLine("d3 HashCode: " + d3.GetHashCode());
            #endregion

            #region Q3
            //Define All Required Constructors to Produce this output:
            //Duration D1 = new Duration(1, 10, 15);


            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());  

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());  

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());  

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());
            #endregion

            #region Q4
            //Implement All required Operators overloading to enable this Code:
            Duration D1 = new Duration(1, 10, 15);  
            Duration D2 = new Duration(7800);       

            Duration D3 = D1 + D2;       
            D3 = D1 + 7800;              
            D3 = 666 + D3;               
            D3 = ++D1;                   
            D3 = --D2;                   
            D1 = D1 - D2;                

            if (D1 > D2)
                Console.WriteLine("D1 is greater");

            if (D1 <= D2)
                Console.WriteLine("D1 less or equal");

            if (D1)
                Console.WriteLine(" in D1 ");

            DateTime obj = (DateTime)D1;
            Console.WriteLine(obj);

            #endregion

            #endregion



        }
    }
}
            
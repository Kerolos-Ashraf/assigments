using System.ComponentModel;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Buffers.Text;

namespace assigment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- Explain the difference between passing (Value type
            //parameters) by value and by reference then write a suitable c#
            //example.
            /*
             1- PASSING BY VALUE :- 
                        1)A COPY OF THE VARIABL IS PASSED TO THE METHOD
                        2)ANY CHANGES INSIDE THE METHOD DO NOT AFFECT THE ORIGINAL VARIABLE
            
             2- PASSING BY REF :- 
                        1)A REFERNCE TO THE ORIGINAL VARIASBLE IS PASSED
                        2)ANY CHANGES INSIDE THE METHOD WILL AFFECT THE ORIGINAL VARIABLE        
             */

            // Pass by Value
            //static void IncreaseByValue(int number)
            //{
            //    number += 10;
            //    Console.WriteLine("Inside IncreaseByValue: " + number);
            //}

            //// Pass by reference
            //static void IncreaseByReference(ref int number)
            //{
            //    number += 10;
            //    Console.WriteLine("Inside IncreaseByReference: " + number);
            //}
            //int VAL1 = 5;
            //int VAL2 = 5;
            //IncreaseByValue(VAL1);
            //Console.WriteLine($"AFTER INCREASE BY VALUE: {VAL1}");

            //IncreaseByReference(ref VAL2);
            //Console.WriteLine($"AFTER INCREASE BY REFERENCE: {VAL2}");

            #endregion
            #region Q2
            //2- Explain the difference between passing (Reference type
            //parameters) by value and by reference then write a suitable c#
            //example.
            /*
             1- Passing Reference Type by Value (Default behavior):-
                1)A copy of the reference is passed to the method.
                2)Inside the method:  You can modify the contents of the object.
             
            2- Passing Reference Type by Reference:-
                1)The actual reference itself is passed.
                2)Inside the method: 
                        You can modify the object’s content.
                        You can also assign a new object, and that change will reflect outside the method.
             */
            //class Person
            //{
            //    public string Name;
            //}


            //static void ModifyByValue(Person p)
            //{
            //    p.Name = "Changed Inside ModifyByValue";  
            //    p = new Person();                         
            //    p.Name = "New Person Inside ModifyByValue";
            //}

            //static void ModifyByReference(ref Person p)
            //{
            //    p.Name = "Changed Inside ModifyByReference"; 
            //    p = new Person();                            
            //    p.Name = "New Person Inside ModifyByReference";
            //}

            //Person person1 = new Person();
            //person1.Name = "Original";

            //ModifyByValue(person1);
            //Console.WriteLine($"After ModifyByValue: {person1.Name}");

            //Person person2 = new Person();
            //person2.Name = "Original";

            //ModifyByReference(ref person2);
            //Console.WriteLine($"After ModifyByReference: {person2.Name}");

            #endregion
            #region Q3
            //3- Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers

            //static void Calculate(int a, int b, int c, int d, out int sum, out int difference)
            //{
            //    sum = a + b;         // Sum of first two numbers
            //    difference = c - d;  // Subtract last two numbers
            //}

            //Console.Write("Enter first number (a): ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Enter second number (b): ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("Enter third number (c): ");
            //int c = int.Parse(Console.ReadLine());

            //Console.Write("Enter fourth number (d): ");
            //int d = int.Parse(Console.ReadLine());


            //Calculate(a, b, c, d, out int sumResult, out int subtractResult);


            #endregion
            #region Q4
            /*4- Write a program in C# Sharp to create a function to calculate the sum of
            the individual digits of a given number.
            Output should be like
            Enter a number: 25
            The sum of the digits of the number 25 is: 7 */
            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number != 0)
            //    {
            //        int digit = number % 10;  // Get last digit
            //        sum += digit;             // Add to sum
            //        number /= 10;             // Remove last digit
            //    }
            //    return sum;
            //}

            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //int result = SumOfDigits(input);

            //Console.WriteLine("The sum of the digits of the number {0} is: {1}", input, result);

            #endregion
            #region Q5
            //5- Create a function named "IsPrime", which receives an integer number
            //and retuns true if it is prime, or false if it is not:

            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)
            //        return false; // 0 and 1 are not prime

            //    for (int i = 2; i <= Math.Sqrt(number); i++) // Optimization: check up to square root
            //    {
            //        if (number % i == 0)
            //            return false; // Divisible by something other than 1 and itself
            //    }

            //    return true; // Number is prime
            //}

            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //bool result = IsPrime(input);

            //if (result)
            //    Console.WriteLine("{0} is a prime number.", input);
            //else
            //    Console.WriteLine("{0} is not a prime number.", input);


            #endregion
            #region Q6
            //6- Create a function named MinMaxArray, to return the minimum and
            //maximum values stored in an array, using reference parameters

            //static void MinMaxArray(int[] numbers, ref int min, ref int max)
            //{
            //    min = numbers[0];
            //    max = numbers[0];


            //    foreach (int number in numbers)
            //    {
            //        if (number < min)
            //            min = number;

            //        if (number > max)
            //            max = number;
            //    }
            //}


            //int[] data = { 15, 8, 22, 4, 17, 29, 3 };

            //int min = 0, max = 0;

            //MinMaxArray(data, ref min, ref max);

            //Console.WriteLine("Minimum value = " + min);
            //Console.WriteLine("Maximum value = " + max);


            #endregion
            #region Q7
            //7- Create an iterative (non-recursive) function to calculate the factorial
            //of the number specified as parameter

            //static long Factorial(int number)
            //{
            //    long result = 1;

            //    for (int i = 2; i <= number; i++)
            //    {
            //        result *= i;
            //    }

            //    return result;
            //}


            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());

            //if (input < 0)
            //{
            //    Console.WriteLine("Factorial is not defined for negative numbers.");
            //}
            //else
            //{
            //    long factorial = Factorial(input);
            //    Console.WriteLine("Factorial of {0} is: {1}", input, factorial);





            #endregion
            #region Q8
            //8- Create a function named "ChangeChar" to modify a letter in a certain
            //position(0 based) of a string, replacing it with a different letter

            //static string ChangeChar(string original, int position, char newChar)
            //{
            //    if (position < 0 || position >= original.Length)
            //    {
            //        Console.WriteLine("Invalid position.");
            //        return original;
            //    }

                
            //    char[] chars = original.ToCharArray();
            //    chars[position] = newChar;

            //    return new string(chars);
            //}


            //Console.Write("Enter a string: ");
            //string text = Console.ReadLine();

            //Console.Write("Enter the position to change (0-based): ");
            //int pos = int.Parse(Console.ReadLine());

            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //string updated = ChangeChar(text, pos, newChar);

            //Console.WriteLine("Updated string: " + updated);



            #endregion

        }
    }
}

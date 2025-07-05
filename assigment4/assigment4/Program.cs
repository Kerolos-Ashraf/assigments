using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace assigment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q6
            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.Write("input: ");
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= x; i++)
            //{
            //    Console.Write($"{i}, ");
            //}
            #endregion
            #region Q7
            //7- Write a program that allows the user to insert an integer then 
            // print a multiplication table up to 12.
            //Console.Write("input: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++) 
            //{
            //    x *= i;
            //    Console.Write($"{x} ");
            //    x = 5;

            //}
            #endregion
            #region Q8
            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine("Even numbers between 1 and " + number + ":");

            //for (int i = 2; i < number; i += 2)
            //{
            //    Console.Write(i + " ");
            //}
            #endregion
            #region Q9
            //9- Write a program that takes two integers then prints the power.
            //Console.Write("Enter base number: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter power: ");
            //int power = int.Parse(Console.ReadLine());

            //int result = 1;

            //for (int i = 1; i <= power; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine("Result = " + result);
            #endregion
            #region Q10
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.WriteLine("Enter marks of five subjects separated by spaces:");
            //int[] marks = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //if (marks.Length != 5)
            //{
            //    Console.WriteLine("You must enter exactly 5 marks.");
            //    return;
            //}

            //int total = marks.Sum();
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine("Total Marks = " + total);
            //Console.WriteLine("Average Marks = " + (int)average);
            //Console.WriteLine("Percentage = " + (int)percentage);
            #endregion
            #region Q11
            //11 - Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter month number (1 to 12): ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;

            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;

            //    case 2:
            //        days = 28; // أو 29 لو عايز تحسب السنة الكبيسة
            //        break;

            //    default:
            //        Console.WriteLine("Invalid month number.");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + days);
            #endregion
            #region Q12
            //12- Write a program to create a Simple Calculator.
            //Console.WriteLine("Simple Calculator");

            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //double result;

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Result = " + result);
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Result = " + result);
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Result = " + result);
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //            Console.WriteLine("Result = " + result);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Cannot divide by zero.");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operator.");
            //        break;
            //}
            #endregion
            #region Q13
            //13- Write a program to allow the user to enter a string and print the REVERSE of it.
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] chars = input.ToCharArray();
            //Array.Reverse(chars);

            //string reversed = new string(chars);

            //Console.WriteLine("Reversed string: " + reversed);
            #endregion
            #region Q14
            //14- Write a program to allow the user to enter int and print the REVERSED of it.
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversed = 0;

            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine("Reversed number: " + reversed);
            #endregion
            #region Q15
            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("The prime numbers between {0} and {1} are:", start, end);

            //for (int num = start; num <= end; num++)
            //{
            //    if (IsPrime(num))
            //    {
            //        Console.Write(num + " ");
            //    }
            //}

            //static bool IsPrime(int n)
            //{
            //    if (n <= 1) return false;
            //    for (int i = 2; i * i <= n; i++)
            //    {
            //        if (n % i == 0)
            //            return false;
            //    }
            //    return true;
            //}
            #endregion
            #region Q17
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.WriteLine("Enter coordinates of 3 points:");

            //Console.Write("x1 = ");
            //int x1 = int.Parse(Console.ReadLine());
            //Console.Write("y1 = ");
            //int y1 = int.Parse(Console.ReadLine());

            //Console.Write("x2 = ");
            //int x2 = int.Parse(Console.ReadLine());
            //Console.Write("y2 = ");
            //int y2 = int.Parse(Console.ReadLine());

            //Console.Write("x3 = ");
            //int x3 = int.Parse(Console.ReadLine());
            //Console.Write("y3 = ");
            //int y3 = int.Parse(Console.ReadLine());

            //// Check if all points lie on the same line using cross product method
            //if ((x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1))
            //    Console.WriteLine("The points lie on the same straight line.");
            //else
            //    Console.WriteLine("The points do NOT lie on the same straight line.");

            #endregion
            #region Q18
            /*18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            - If the worker takes more than 5 hours, they are required to leave the company.
                To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
            */
            //Console.Write("Enter time taken by the worker (in hours): ");
            //double hours = double.Parse(Console.ReadLine());

            //if (hours >= 2 && hours <= 3)
            //{
            //    Console.WriteLine("Highly efficient");
            //}
            //else if (hours > 3 && hours <= 4)
            //{
            //    Console.WriteLine("You need to improve your speed");
            //}
            //else if (hours > 4 && hours <= 5)
            //{
            //    Console.WriteLine("Training will be provided to improve your speed");
            //}
            //else if (hours > 5)
            //{
            //    Console.WriteLine("You have to leave the company");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input (time must be >= 2 hours)");
            //}
            #endregion


        }
    }
}

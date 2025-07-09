using System;

namespace assigment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Q19
        //19- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
        //Console.WriteLine("ENTER THE SIZE OF IDENTITY MATRIX (N): ");
        //int N = int.Parse(Console.ReadLine());

        //for (int R = 0; R < N; R++)
        //{
        //    for (int C = 0; C < N; C++)
        //    {
        //        if (R == C)
        //            Console.WriteLine("1 ");
        //        else
        //            Console.WriteLine("0 ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region Q20
        //20- Write a program in C# Sharp to find the sum of all elements of the array.
        //int[] ints = { 1, 2, 3 };
        //int SUM = 0 ;
        //for (int i = 0; i < ints.Length; i++)
        //    SUM += ints[i];

        //Console.WriteLine(SUM);
        #endregion
        #region Q21
        //21- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
        //int[] ARR1 = { 1, 2, 3 };
        //int[] ARR2 = { 4, 5, 6 };
        //int SIZE = ARR1.Length;
        //int[] MERGED_ARR = new int[SIZE * 2];
        //for (int i = 0; i < SIZE; i++) 
        //    MERGED_ARR[i] = ARR1[i];

        //for (int i = 0;i < SIZE; i++)
        //    MERGED_ARR[SIZE + i] = ARR2[i];

        //Array.Sort(MERGED_ARR);
        #endregion
        #region Q22
        //22- Write a program in C# Sharp to count the frequency of each element of an array.
        //int[] X =    { 1, 2, 3, 1, 2, 3};
        //int[] freq = new int[X.Length];
        //bool[] visited = new bool[X.Length];
        //for (int i = 0; i < X.Length; i++)
        //{
        //    if (visited[i])
        //        continue;

        //    int count = 1;

        //    for (int j = i + 1; j< X.Length ; j++)
        //    {
        //        if (X[i] == X[j])
        //        {
        //            count++;
        //            visited[j] = true;
        //        }
        //    }
        //    freq[i] = count;
        //}

        //for (int i = 0;i < X.Length; i++)
        //{
        //    if (!visited[i])
        //        Console.WriteLine($"FREQUENCY OF ELEMENT: {X[i]} IS : {freq[i]}");
        //}

        #endregion
        #region Q23
        //23- Write a program in C# Sharp to find maximum and minimum element in an array
        //int[] X = { 1, 2, 3, 4, 5 };
        //int MIN = X.Min();
        //int MAX = X.Max();
        //Console.WriteLine($" MAXIMUM ELEMENT IS : {MAX} , AND MINIMUM ELEMENT IS : {MIN}");
        #endregion
        #region Q24
        //24- Write a program in C# Sharp to find the second largest element in an array.
        //int[] X = { 1, 2, 5, 3, 4  };
        //Array.Sort(X);
        //Console.WriteLine(X[ X.Length - 2 ]);
        #endregion
        #region Q25
        //25-. Consider an Array of Integer values with size N, having values as    
        //in this Example
        //int[] X = [7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3];
        //Console.WriteLine("ENTER SIZE OF THE ARRAY");
        //int N = int.Parse(Console.ReadLine());

        //int[] arr = new int[N];
        //Console.WriteLine("ENTER THE ELEMENTS OF ARRAY");
        //for (int i = 0; i < N; i++) 
        //{
        //    Console.Write($"element [{i}] = ");
        //    arr[i]  = int.Parse(Console.ReadLine());
        //} 
        //int MaxDistance = 0;
        //for (int i = 0; i < N -1; i++)
        //{
        //    for (int j = N - 1; j > i; j--)
        //    {
        //        if (arr[j] == arr[i]) 
        //        {
        //            int distance = j - i - 1 ;
        //            if (distance > MaxDistance)
        //                MaxDistance = distance;
        //            break;
        //        }

        //    }
        //}
        //Console.WriteLine($"LONGEST DISTANCE BETWEEN TWO EQUAL ELEMENTS IS: {MaxDistance}");
        #endregion
        #region Q26
//        26- Given a list of space separated words, reverse the order of the words.

//        Input: this is a test       Output: test a is this
//Input: all your base        Output: base your all
//Input: Word Output: Word
//Note : 
//Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement

            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Reverse()));

            #endregion
        #region Q27
            //27- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] array1 = new int[rows, cols];
            //int[,] array2 = new int[rows, cols];

            //Console.WriteLine("Enter elements of the first array:");

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Element [{i},{j}]: ");
            //        array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        array2[i, j] = array1[i, j];
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        #region Q28
            //28- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] X = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //for (int i = X.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(X[i] + " ");
            //}
            #endregion
        }
    }
}

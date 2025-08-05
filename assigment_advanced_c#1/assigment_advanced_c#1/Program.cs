namespace assigment_advanced_c_1
{
    internal class Program
    {

        #region Q1
        static void OptimizeBubbleSort(int[] arr)
        {
            bool swapped ;

            for (int i = 0; i < arr.Length -1; i++)
            { 
                swapped = false ;

                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }

                }

                if(!swapped) 
                    break ;
            
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm 
            And implement the code of this optimized bubble sort algorithm */

            // IF DURING FULL PASS OF THE ARRAY NO SWAPS ARE MADE THEN THE ARRAY IS ALREADY SORTED 

            //int[] arr = { 8, 1, 2, 3, 4, 5, 6, 7 };
            //OptimizeBubbleSort (arr);
            //Console.WriteLine($"Sorted Array: {string .Join(", ",arr)}");





            #endregion


            #region Q2
            // create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.
            #region REQ1
            //Create a generic class named Range<T> where T represents the type of values.

            //Range r = new Range();
            #endregion

            #region REQ2
            //Implement a constructor that takes the minimum and maximum values to define the range.
            Range<int> r01 = new Range<int>(4,9);

            #endregion

            #region REQ3
            
            //Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
            
            Console.WriteLine(r01.IsInRange(5));


            #endregion

            #region REQ4
            //Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
            r01.Length();

            #endregion

            #region REQ5
            //Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.

            // THAT IS NOTE I DO IT
            #endregion

            #endregion
        }
    }
}

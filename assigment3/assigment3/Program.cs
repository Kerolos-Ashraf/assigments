namespace assigment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            bool X = int.TryParse(Console.ReadLine(), out int y);
            if (X && y % 3 == 0 && y % 4 == 0)
                Console.WriteLine("yes");
            else Console.WriteLine("no");
            #endregion
            #region Q2
            //2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            int X = int.Parse(Console.ReadLine());
            if(X<0)
                Console.WriteLine("NEGATIVE");
            else 
                Console.WriteLine("POSITIVE");
            #endregion
            #region Q3
            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.WriteLine("Input:");
            string input = Console.ReadLine(); 

            
            int[] numbers = input.Split().Select(int.Parse).ToArray();

            
            int max = numbers.Max();
            int min = numbers.Min();

            
            Console.WriteLine("Max element = " + max);
            Console.WriteLine("Min element = " + min);
            #endregion
            #region Q4
            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            int X = int.Parse(Console.ReadLine());
            if (X % 2 == 0)
                Console.WriteLine("EVEN");
            else
                Console.WriteLine("ODD");
            #endregion
            #region Q5
            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

                Console.WriteLine("Input:");
                char ch = char.Parse(Console.ReadLine());

                ch = char.ToLower(ch);

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    Console.WriteLine("vowel");
                else
                    Console.WriteLine("Consonant");
            }
        }

        #endregion
    }



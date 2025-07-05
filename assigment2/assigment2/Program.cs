using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace ASS1_S2
{

    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("ENTER A NUMBER");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(x);
            #endregion
            #region Q2
            String S = "123ABC";
            int X = int.Parse(S);
            // GET FORMAT EXCEPTION STRING S CONTAIN NON NUMIRIC CHARACTERS CAN NOT CASTING
            #endregion
            #region Q3
            float l = 23.6f;
            float y = 45.8f;
            float q = l + y;
            Console.WriteLine("l + y = " + q);
            #endregion
            #region Q4
            String C = "KEROLOS_ASHRAF";
            string b = C.Substring(3);
            #endregion
            #region Q5
            int a = 5, f = 6;
            a = f;
            f = 8;
            // value of a will reset to be the same value of f , when modify the value of f do not affect in value of a

            #endregion
            #region Q6
            Point p1 = new Point();
            Point p2 = new Point();
            p1 = p2;
            p1.g = 20;
            // here p1 and p2 affected by modification so refernce to same place in heap

            #endregion
            #region Q7
            string s1 = "kero ";
            string s2 = "ashaf";
            string s3 = s1 + s2;
            #endregion
            #region Q8
            // B) A VALUE 1 WILL BE ASSIGNED TO D
            #endregion
            #region Q9
            // A) 6.5 1
            #endregion
            #region Q10
            // 7 7
            #endregion

        }
        #region Q6
        class Point
        {
            public int g = 9;
            public int h = 10;
        }
        #endregion
    }

}
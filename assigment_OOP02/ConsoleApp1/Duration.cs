using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_OOP02
{
    internal class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration()
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
        }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }


        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Duration))
                return false;

            Duration other = (Duration)obj;
            return this.Hours == other.Hours &&
                   this.Minutes == other.Minutes &&
                   this.Seconds == other.Seconds;
        }

        public override int GetHashCode()
        {
            return Hours.GetHashCode() ^ Minutes.GetHashCode() ^ Seconds.GetHashCode();
        }


        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            int remaining = totalSeconds % 3600;
            Minutes = remaining / 60;
            Seconds = remaining % 60;
        }

        // Override ToString()
        public override string ToString()
        {
            string result = "";

            if (Hours > 0)
                result += $"Hours: {Hours}, ";

            if (Minutes > 0 || Hours > 0)
                result += $"Minutes :{Minutes}, ";

            result += $"Seconds :{Seconds}";

            return result;

        }

        // 3. Get total seconds
        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        // 4. Operator + (Duration + Duration)
        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.TotalSeconds() + d2.TotalSeconds());
        }

        // 5. Operator + (Duration + int)
        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        // 6. Operator + (int + Duration)
        public static Duration operator +(int seconds, Duration d)
        {
            return new Duration(d.TotalSeconds() + seconds);
        }

        // 7. Operator - (Duration - Duration)
        public static Duration operator -(Duration d1, Duration d2)
        {
            return new Duration(Math.Max(0, d1.TotalSeconds() - d2.TotalSeconds()));
        }

        // 8. Operator ++
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60); // add 1 minute
        }

        // 9. Operator --
        public static Duration operator --(Duration d)
        {
            return new Duration(Math.Max(0, d.TotalSeconds() - 60)); // minus 1 minute
        }

        // 10. Comparison >
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() >= d2.TotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }

        // 11. true/false operator
        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }

        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() == 0;
        }

        // 12. Casting to DateTime
        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }

    }
}

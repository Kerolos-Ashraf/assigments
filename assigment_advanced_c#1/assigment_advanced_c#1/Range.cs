using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_advanced_c_1
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }
        public Range(T min , T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T Value)
        {
            return Value.CompareTo(Min) >=0 && Value.CompareTo(Max) <= 0; 
        }

        
        public dynamic Length()
        {
            return (dynamic)Max - (dynamic)Min;
        }
    
    }
}

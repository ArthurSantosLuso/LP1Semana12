using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> items, T limit) 
            where T : struct, IComparable<T>
        {
            foreach (T item in items)
            {
                if (item.CompareTo(limit) < 0)
                {
                    yield return item;
                }
            }
        }
    }
}

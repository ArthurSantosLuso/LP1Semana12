using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int cntType = 0;

            foreach(object o in items)
            {
                if (o is T)
                {
                    cntType++;
                }
            }
            return cntType;
        }
    }
}

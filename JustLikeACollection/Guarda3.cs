using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JustLikeACollection
{
    public class Guarda3<T> : IEnumerable<T>
    {
        private T val1;
        private T val2;
        private T val3;

        public Guarda3()
        {
            val1 = default;
            val2 = default;
            val3 = default;
        }

        public T GetItem(int i)
        {
            VerifyIfInRange(i);

            if (i == 0)
                return val1;
            else if (i == 1)
                return val2;
            else return val3;
        }

        public void SetItem(int i, T item)
        {
            VerifyIfInRange(i);

            if (i == 0)
                val1 = item;
            else if (i == 1)
                val2 = item;
            else val3 = item;
        }

        private void VerifyIfInRange(int i)
        {
            if (i < 0 || i > 2)
                throw new IndexOutOfRangeException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return val1;
            yield return val2;
            yield return val3;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

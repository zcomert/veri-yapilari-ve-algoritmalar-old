using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrray.Generic
{
    public class Array<T> : ICloneable, IEnumerable<T>
    {
        protected T[] InnerArray { get; set; }
        public int Length => InnerArray.Length;

        public Array(int defaultSize = 2)
        {
            InnerArray = new T[defaultSize]; // fixed size
        }

        public Array(params T[] sourceArray) : this(sourceArray.Length)
        {
            System.Array.Copy(sourceArray, InnerArray, sourceArray.Length);
        }

        public T GetValue(int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            return InnerArray[index];
        }

        public void SetValue(T value, int index)
        {
            if (!(index >= 0 && index < InnerArray.Length))
                throw new ArgumentOutOfRangeException();
            if (value == null)
                throw new ArgumentNullException();

            InnerArray[index] = value;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < InnerArray.Length; i++)
            {
                if (GetValue(i).Equals(value))
                    return i;
            }
            return -1; // O(n)
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ArrayEnumerator<T>(InnerArray);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ArrayEnumerator<T> : IEnumerator<T>
    {
        private T[] _array;

        public ArrayEnumerator(T[] array)
        {
            _array = array;
            index = -1;
        }

        private int index;

        public T Current => _array[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool MoveNext()
        {
            if (index<_array.Length-1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}

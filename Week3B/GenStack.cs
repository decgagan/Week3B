using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3B
{
    internal class GenStack<T> where T : IComparable
    {
        private int top=0; private int maxSize; private T[] array;

        public GenStack()
        {
            this.maxSize = 10;
            this.array = new T[this.maxSize];
        }

        public GenStack(int maxSize)
        {
            this.maxSize = maxSize;
            this.array = new T[maxSize];
        }

        public void Push(T value)
        {

            array[top++] = value;

        }
        public T Pop()
        {
            return array[--top];
        }

    }
}

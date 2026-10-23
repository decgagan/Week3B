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
            if (!IsFull())
            {
                array[top++] = value;
            }
            else
            {
                throw new InvalidOperationException("Stack is full");
            }

        }
        public T Pop()
        {
            if(!IsEmpty())
            {
                return array[--top];
            }
            else
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }
        public bool IsEmpty()
        {
            return top == 0;
        }
        public bool IsFull()
        {
            return top == maxSize;
        }

    }
}

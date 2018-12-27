using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class MyStack<T> : SimpleList<T> 
       where T : IComparable
    {
        public new int Count = 0;

        public void Push(T element)
        {
            Count++;
            this.Add(element);
            
            
        }

        public T Pop()
        {

           
            
            return this.Get(--Count );
        }
    }
}
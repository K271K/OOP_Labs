using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
   
    internal class Node<T>
    {
        //Конструктор
        public Node(T data) { 
            Data = data;
            pNext = null;
        }

        public T Data { get; }
        public Node<T> pNext { get; set; }
    }
    internal class MyList<T> : IEnumerable
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        //Чтобы работал foreach
        public IEnumerator GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current;
                current = current.pNext;
            }
        }
        //Добавить в конец
        public void push_back(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                Tail.pNext = new Node<T>(data);
                Tail = Tail.pNext;
            }

        }
    }

}

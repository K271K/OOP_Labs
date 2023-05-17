using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
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
        private int Size;
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        //Чтобы работал foreach
        public IEnumerator GetEnumerator()
        {
            Node<T> current = Head;
            while (current != null)
            {
                yield return current.Data;
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
            Size++;

        }
        public T pop_front()
        {
            if (Head == null)
                return default(T);
            else if (Head.pNext == null)
            {
                T tempData = Head.Data;
                Head = null;
                Tail = null;
                Size--;
                return tempData;
            }
            else
            {
                Node<T> tempNode = Head;
                T tempData = Head.Data;
                Head = Head.pNext;
                tempNode = null;
                Size--;
                return tempData;
            }
        }
        public T remove(int index)
        {
            if (index < 0 || index - Size > -1)
            {
                return default(T);
            }
            else if (index == 0 || Head == null)
            {
                return pop_front();
            }
            else
            {
                Node<T> previous = Head;
                for (int i = 0; i < index; i++)
                {
                    previous = previous.pNext;
                }
                Node<T> ToDeleteNode = previous.pNext;
                T ToDeleteData = ToDeleteNode.Data;
                previous.pNext = ToDeleteNode.pNext;
                ToDeleteNode = null;
                Size--;
                return ToDeleteData;
            }
        }
    }

}

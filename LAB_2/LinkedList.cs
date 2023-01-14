using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace LAB_2
{

    public class LinkedList<T> : IEnumerable<T>
    {
        Node<T> head; //первый элемент списка
        Node<T> tail; //последний элемент списка
        int count; //количество элементов списка    
        public void Add(T data)//метод добавление элементов в наш  список
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public bool Delete(T data)//метод удаление элемента 
        {
            Node<T> current = head;
            Node<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public void Clear()//метод очистки списка
        {
            head = null;
            tail = null;
            count = 0;
        }
        public void AppendFirst(T data)//метод добавления элемента в начало списка
        {
            Node<T> node = new Node<T>(data);
            node.Next = head;
            head = node;
            if (count == 0)
                tail = head;
            count++;
        }
        
        public bool Contains(T data)//метод для проверки элемента в нашем списке
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()//перечислитель, который можно использовать для итерации по коллекции
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()//объект IEnumerator, который используется для прохода по коллекции
        {
            return ((IEnumerable)this).GetEnumerator();
        }


    }
}

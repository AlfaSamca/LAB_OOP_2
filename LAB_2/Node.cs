using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_2
{
    class Node<T>
    {
        public Node(T data) //новый экземпляр 
        {
            Data = data;
        }
        public T Data { get; set; } //наши хранимые данные
        public Node<T> Next { get; set; } //следующий элемент
    }
}

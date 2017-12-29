using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class MyQUEUEList<T>:ClassPerem<T>
    {
        int capacity = defaultCapacity;
        int tail = 0;
        int head = -1;
        public MyQUEUEList()
        {
        T[] MyQUEUEList = new T[defaultCapacity];
        
        }


        public void Enqueue(T newElement) //добавление элемента в конец очереди
        {
            if (pointer == capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(_array, 0, newQueue, 0, _array.Length);
                _array = newQueue;
                capacity *= 2;
            }
            pointer++;
            _array[tail++ % capacity] = newElement;
        }

        public T Dequeue() //удаляет объект из начала очереди и возвращает его
        {
            if (pointer == 0)
            {
                throw new InvalidOperationException();
            }
            pointer--;
            return _array[++head % capacity];
        }

      
      
        public T Peek()// Просмотр элемента на вершине очереди.
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return _array[head];
        }

  

        public void Clear() //Очистка очереди
        {
            if (head < tail)
                Array.Clear(_array, head, Count);
            else
            {
                Array.Clear(_array, head, _array.Length - head);
                Array.Clear(_array, 0, tail);
            }
            head = 0;
            tail = 0;
            pointer = 0;
        }
     
    }
}

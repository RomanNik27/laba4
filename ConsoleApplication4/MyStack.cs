using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication4
{
    class CStack<T>:ClassPerem<T>
    {
     

        public CStack()
        { 
            this._array = new T[defaultCapacity];
        }

        //Возвращает объект в верхней части Stack без его удаления.
        public T Peek()
        {
            if (pointer == 0)
            {
                throw new InvalidOperationException();
            }
            return this._array[pointer - 1];
        }

        public T Pop() //Удаляет и возвращает объект, находящийся в начале Stack.
        {
            if (this.size() == 0)
            { //вброс ошибки при взятии с пустого стека (Overflow)
                throw new InvalidOperationException();
            }
            return this._array[--pointer];
        }

        //Вставляет объект как верхний элемент стека Stack.
        public void Push(T newElement)
        {
            if (this.size() == this._array.Length) //если у нас переполнение...
            { 
                T[] newArray = new T[2 * this._array.Length];
                Array.Copy(this._array, 0, newArray, 0, pointer);
                this._array = newArray; //просто создаем новый массив с двойным размером
            }
            this._array[pointer++] = newElement; //вставляем элемент
        }

      
        //Метод возврата последнего элемента 
        public  T Last<T>(T[] _array)
        {
            if (_array == null) return default(T);

            // Возвращаем последний элемент.
            return _array.Last();
        }
    }
}

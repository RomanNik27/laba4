
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ConsoleApplication4
{
    public class MyArrayList<T> : ClassPerem<T>
    {


        /*
        Добавляет новый элемент в список. При достижении размера внутреннего
        массива происходит его увеличение в два раза.
        */
        public void add(T item)
        {
            if (pointer == _array.Length - 1)
                resize(_array.Length * 2); // увеличу в 2 раза, если достигли границ
            _array[pointer++] = item;
        }

        //Метод возвращения индекса если присутсвует этот элемент, а если не находим то возвращаем deafult T
        public int Find(T[] _array, char str)
        {
            for (int i = 0; i < pointer; i++)
            {
                if (Convert.ToChar(_array[i]) == str)
                    return i;
            }
            return Convert.ToInt32(default(T));
        }
        /*
        Удаляет элемент списка по индексу. Все элементы справа от удаляемого 
        перемещаются на шаг налево. Если после удаления элемента количество    
        элементов стало в CUT_RATE раз меньше чем размер внутреннего массива, 
        то внутренний массив уменьшается в два раза, для экономии занимаемого 
        места.
        */
        public void remove(int index)
        {
            for (int i = index; i < pointer; i++)
                _array[i] = _array[i + 1];
            _array[pointer] = default(T);
            pointer--;
            if (_array.Length > defaultCapacity && pointer < _array.Length / CUT_RATE)
                resize(_array.Length / 2); // если элементов в CUT_RATE раз меньше чем длина массива, то уменьшим в два раза
        }

    };
}
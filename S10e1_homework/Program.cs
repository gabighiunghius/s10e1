using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10.Generics.App04
{
    internal class GenericList<T> where T : IComparable, new()
    {
        private readonly T[] array;

        private readonly int size;

        private int currentElemIdx;

        public GenericList(int size)
        {
            this.currentElemIdx = 0;
            this.size = size;
            this.array = new T[size];
        }

        public void Add(T value)
        {
            if (this.currentElemIdx == this.size)
            {
                Console.WriteLine("Size full!");
                return;
            }

            this.array[this.currentElemIdx] = value;
            this.currentElemIdx++;
        }



        public T Get(int index)
        {
            if (index > this.size || index < this.size)
            {
                Console.WriteLine("Out of range");
            }


            var x = array[index];
            return x;
        }

        public void Insert(int poz, T value)
        {
            array[poz] = value;
        }

        public void Remove(int poz)
        {
            array[poz] = default;
        }

        public void ClearList()
        {

            for (int i = 0; i <= array.Length; i++)
            {
                array[i] = default;
            }
        }

        public void Finder(T value)
        {
            for (int i = 0; i <= array.Length; i++)
            {
                if (array.GetType().Equals(value.GetType()))
                {
                    value.ToString();
                }
            }

        }


        public void AutoGrow()
        {
            if (array[size] != default)
            {


                int size2;
                size2 = size * 2;
                T[] array2 = new T[size2];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = array2[i];
                }


            }
        }

        public void Max<T>()
        {
            var max = array[0];
            for (int i = 0; i <= array.Length; i++)
            {
                if (array[i].CompareTo(max) > 0)
                {
                    max = array[i];
                }
            }

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var stringList = new GenericList<string>(3);

            stringList.Add("123");
            stringList.Add("1234");
            stringList.Add("12345");
        }
    }
}








//Problem 5. Generic class
//Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
//Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
//Check all input parameters to avoid accessing elements at invalid positions.


namespace GenericClass
{
    using System;
    public class GenericList<T> where T : IComparable<T>
    {
        private int capacity = 4;
        private T[] arr;
        private int index;

        public GenericList()
        {
            this.Capacity = capacity;
            this.Arr = new T[this.Capacity];
            this.Index = 0;
        }
        public T[] Arr { get; set; }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Capacity should be > 0");
                }
                else
                {
                    this.capacity = value;
                }
            }
        }
        public int Index
        {
            get
            {
                return this.index;
            }
            set
            {
                if (value < 0 && value > this.arr.Length)
                {
                    throw new ArgumentOutOfRangeException("Index should be > 0 and <" + this.arr.Length);
                }
                else
                {
                    this.index = value;
                }
            }
        }

        public void Add(T element)
        {
            if (this.Index >= this.Arr.Length)
            {
                this.AutoGrow();
            }
            this.Arr[this.Index] = element;
            this.Index++;
        }
        
        public T Access(int index)
        {
            return this.Arr[index];
        }
        
        public void Remove(int index)
        {
            for (int i = index; i < this.Arr.Length - 1; i++)
            {
                this.Arr[i] = this.Arr[i + 1];
            }
        }
        
        public void Insert(T element, int index)
        {
            if (this.Index >= this.Arr.Length)
            {
                this.AutoGrow();
            }
            T[] newArr = new T[this.Arr.Length];
            for (int i = 0; i < this.Arr.Length - 1; i++)
            {
                if (i < index)
                {
                    newArr[i] = this.Arr[i];
                }
                else if (i == index)
                {
                    newArr[i] = element;
                }
                else
                {
                    newArr[i] = this.Arr[i - 1];
                }
            }
            this.Arr = newArr;
            this.Index++;
        }
        
        public void Clear()
        {
            this.Arr = new T[this.Capacity];
        }
        
        public int IndexOf(T element)
        {
            return Array.IndexOf(this.Arr, element);
        }
        
        public void AutoGrow()
        {
            T[] newArr = new T[this.Arr.Length * 2];
            for (int i = 0; i < this.Arr.Length; i++)
            {
                newArr[i] = this.Arr[i];
            }
            this.Arr = newArr;
        }
        
        public T Min()
        {
            T min = this.Arr[0];
            for (int i = 0; i < this.Index; i++)
            {
                if (min.CompareTo(this.Arr[i]) >= 0)
                {
                    min = this.Arr[i];
                }
            }
            return min;
        }
        
        public T Max()
        {
            T max = this.Arr[0];
            for (int i = 0; i < this.Index; i++)
            {
                if (max.CompareTo(this.Arr[i]) < 0)
                {
                    max = this.Arr[i];
                }
            }
            return max;
        }
       
        public override string ToString()
        {
            return String.Join(",", this.Arr);
        }
    }
}

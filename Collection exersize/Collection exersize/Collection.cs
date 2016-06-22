using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Collection_exersize
{
    //This class is used for executing foreach loop
    //IEnumerable<T> interface has GetEnumerator() method to enumerate elements and it
    //returns IEnumerator<T>.
    //class Enumerator<T> : IEnumerator<T>
    //{
    //    private T[] objects;
    //    private int cur;

    //    public Enumerator(T[] list)
    //    {
    //        this.objects = list;
    //        cur = -1;
    //    }

    //    public T Current
    //    {
    //        get
    //        {
    //            return objects[cur];
    //        }
    //    }

    //    object System.Collections.IEnumerator.Current
    //    {
    //        get
    //        {
    //            return objects[cur];
    //        }
    //    }

    //    public void Reset()
    //    {
    //        cur = -1;
    //    }

    //    public bool MoveNext()
    //    {
    //        cur++;
    //        if (cur < objects.Length)
    //            return true;
    //        else
    //            return false;
    //    }

    //    public void Dispose()
    //    {
    //        return;
    //    }
    //}

    class Collection<T> //: IEnumerable<T>
    {
        // when we inherit an interface, every method, property, delegate and event of that interface
        // must be implemented throughout the class. That means must give proper definition.
        private T[] items;
        private int size;

        public Collection()
        {
            size = 0;
            items = new T[1];
        }

        public int Count
        {
            get
            {
                return size;
            }
        }

        public void Add(T item)
        {
            items[size] = item;
            size++;
            Array.Resize<T>(ref items, size + 1);
        }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
                size++;
            }
        }

        //public IEnumerator<T> GetEnumerator()
        //{
        //    return new Enumerator<T>(items);
        //}

        //System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        //{
        //    return new Enumerator<T>(items);
        //}

        public IEnumerator<T> GetEnumerator()
        {
            int counter = 0;

            while (counter < Count)
            {
                yield return items[counter];
                counter++;
            }
        }
    }
}

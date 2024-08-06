using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment13.CustomLists
{
    // CustomList class inherits from List<T>
    public class CustomList<T> : List<T>
    {

        // Checks if any element in the list matches the specified predicate
        
        //The Predicate<T> delegate takes a single parameter of type T
        //and returns a boolean value. 
        public bool Exists(Predicate<T> match)
        {
            foreach (T item in this)
            {
                if (match(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (T item in this)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default(T);
        }
        // Finds all elements that match the specified predicate
        // and returns them in a new list
        public List<T> FindAll(Predicate<T> match)
        {
            List<T> list = new List<T>();
            foreach (T item in this)
            {
                if (match(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
        // Finds the index of the first element that matches the specified predicate
        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (match(this[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        // Finds the last element that matches the specified predicate

        public T FindLast(Predicate<T> match)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (match(this[i]))
                {
                    return this[i];
                }
            }
            return default(T);
        }
        // Finds the index of the last element that matches the specified predicate
        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                if (match(this[i]))
                {
                    return i;
                }
            }
            return -1;
        }
        // Executes the specified action on each element of the list
        public void ForEach(Action<T> action)
        {
            foreach (T item in this)
            {
                action(item);
            }
        }
        // Determines whether all elements in the list match the specified predicate
        public bool TrueForAll(Predicate<T> match)
        {
            foreach (T item in this)
            {
                if (!match(item))
                {
                    return false;
                }
            }
            return true;
        }
    }
}

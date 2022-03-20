using System;
using System.Collections;
using System.Collections.Generic;

namespace PracticeUniqCollections
{
    public class UniqueCollection : ICollection<string>
    {
        private List<string> innerCol;

        public int Count { get { return innerCol.Count; } }

        public UniqueCollection()
        {
            innerCol = new List<string>();
        }

        public IEnumerator GetEnumerator()
        {
            IEnumerator enumerator = innerCol.GetEnumerator();
            while (enumerator.MoveNext())
            {
                yield return enumerator.Current;
            }
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
               
        public bool Contains(string name)
        {
            bool found = false;
            foreach (string str in innerCol)
            {
                if (str.Equals(name))
                {
                    found = true;
                }
            }
            return found;
        }

        public void Add(string name)
        {
            if (!Contains(name))
            {
                innerCol.Add(name);
            }
            else
            {
                Console.WriteLine("A Student with that name is allready in the list");
            }

        }

        public void Clear()
        {
            innerCol.Clear();
        }

        public bool Remove(string name)
        {
            bool result = false;

           if(Contains(name))
            {
                innerCol.Remove(name);
            }
            else
            {
                Console.WriteLine("That name is not in the list");
            }
            return result;
        }

        public void CopyTo(string[] array, int arrayIndex)
        {
            array = innerCol.GetRange(arrayIndex, innerCol.Count).ToArray();
        }

       

        public bool IsReadOnly { get { return false; } }

    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    interface IList
    {
        public void Add(int value);

        public void Add(int[] values);

        public void AddToStart(int value);

        public void AddToStart(int[] values);

        public void AddByIndex(int index, int value);

        public void AddByIndex(int index, int[] values);

        public void Delete();
        
        public void Delete(int numberOfValues);

        public void DeleteToStart();

        public void DeleteToStart(int numberOfValues);

        public void DeleteByIndex(int index);

        public void DeleteByIndex(int index, int numberOfValues);

        public int GetTheLength();

        public int GetAccessByIndex(int index);

        public int GetIndexByValue(int value);

        public void ChangeByIndex(int index, int value);

        public void Reverse();

        public int FindMaxElement();

        public int FindMinElement();

        public int FindIndexOfMaxElement();

        public int FindIndexOfMinElement();

        public void SortMinToMax();

        public void SortMaxToMin();

        public void DeleteFirstElementByValue(int value);

        public void DeleteAllElementsByValue(int value);

    }
}

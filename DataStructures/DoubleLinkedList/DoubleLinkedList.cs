using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleLinkedList
{
    public class DoubleLinkedList: IList
    {
        private DoubleNode _root;
        private DoubleNode _end;
        public int Length { get; private set; }

        public DoubleLinkedList()
        {
            _root = null;
            _end = null;
            Length = 0;
        }

        public DoubleLinkedList(int value)
        {
            _root = new DoubleNode(value);
            _end = _root;
            Length = 1;
        }

        public DoubleLinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;
                _end = null;
                Length = 0;
            }
            else
            {
                _root = new DoubleNode(array[0]);
                DoubleNode current = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    current.Next = new DoubleNode(array[i]);
                    current.Next.Previous = current;
                    current = current.Next;
                }
                _end = current;
                Length = array.Length;
            }
        }

        public override bool Equals(object obj)
        {
            DoubleLinkedList doubleLinkedList = (DoubleLinkedList)obj;

            if (Length != doubleLinkedList.Length)
            {
                return false;
            }

            DoubleNode tmp1 = _root;
            DoubleNode tmp2 = doubleLinkedList._root;

            for (int i = 0; i < Length; i++)
            {
                if (tmp1.Value != tmp2.Value)
                {
                    return false;
                }
                tmp1 = tmp1.Next;
                tmp2 = tmp2.Next;
            }
            return true;
        }

        public override string ToString()
        {
            string s = "";

            DoubleNode tmp = _root;
            for (int i = 0; i < Length; i++)
            {
                s += tmp.Value + ";";
                tmp = tmp.Next;
            }
            return s;
        }

        public void Add(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else if (Length==0)
            {
                _root = new DoubleNode(value);
                _end = _root;
                Length = 1;
            }
            else
            {
                _end.Next = new DoubleNode(value);
                _end.Next.Previous = _end;
                _end = _end.Next;
                Length++;
            }
        }

        public void Add(int[] values)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void AddToStart(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void AddToStart(int[] values)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void AddByIndex(int index, int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void AddByIndex(int index, int[] values)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void Delete()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void Delete(int numberOfValues)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void DeleteToStart()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void DeleteToStart(int numberOfValues)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void DeleteByIndex(int index)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void DeleteByIndex(int index, int numberOfValues)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public int GetTheLength()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public int GetAccessByIndex(int index)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public int GetIndexByValue(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public void ChangeByIndex(int index, int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void Reverse()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public int FindMaxElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public int FindMinElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public int FindIndexOfMaxElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public int FindIndexOfMinElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }
            return 0;
        }

        public void SortMinToMax()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void SortMaxToMin()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void DeleteFirstElementByValue(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }

        public void DeleteAllElementsByValue(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {

            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkedList: IList
    {
        public int Length { get; set; }

        private Node _root;

        public int this[int index]
        {
            get
            {
                Node tmp = _root;
                for (int i = 1; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                return tmp.Value;
            }

            set
            {
                Node tmp = _root;
                for (int i = 1; i <= index; i++)
                {
                    tmp = tmp.Next;
                }
                tmp.Value = value;
            }
        }

        public LinkedList()
        {
            Length = 0;
            _root = null;
        }

        public LinkedList(int value)
        {
            _root = new Node(value);
            Length = 1;
        }

        public LinkedList(int[] array)
        {
            if (array.Length != 0)
            {
                _root = new Node(array[0]);
                Node tmp = _root;
                for (int i = 1; i < array.Length; i++)
                {
                    tmp.Next = new Node(array[i]);
                    tmp = tmp.Next;
                }
                Length = array.Length;
            }
            else
            {
                Length = 0;
                _root = null;
            }
        }

        public override bool Equals(object obj)
        {
            LinkedList linkedList = (LinkedList)obj;
            if (Length != linkedList.Length)
            {
                return false;
            }
            Node tmp1 = _root;
            Node tmp2 = linkedList._root;
            for (int i = 1; i < Length; i++)
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

            if (_root != null)
            {
                Node tmp = _root;
                while (tmp != null)
                {
                    s += tmp.Value + ";";
                    tmp = tmp.Next;
                }
            }
            return s;
        }

        public void Add(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else if (Length == 0)
            {
                _root = new Node(value);
                Length++;
            }
            Node current = _root;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(value);
            Length++;
        }

        public void Add(int[] values)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else if (Length == 0)
            {
                _root = new Node(values[0]);
            }
            Node current = _root;
            while (current.Next != null)
            {
                current = current.Next;
            }
            for (int i = 0; i < values.Length; i++)
            {
                current.Next = new Node(values[i]);
                current = current.Next;
            }
            Length += values.Length;
        }

        public void AddToStart(int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
                Length++;
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
                Node tmp;
                Node current = _root;
                Length += values.Length;
                for (int i = values.Length - 1; i >= 0; i--)
                {
                    tmp = new Node(values[i]);
                    current = tmp;
                    current.Next = _root;
                    _root = tmp;
                }
            }

        }

        public void AddByIndex(int index, int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else if (index == 0 || Length==0)
            {
                Node tmp = _root;
                _root = new Node(value);
                _root.Next = tmp;
            }
            else
            {
                Node current = _root;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                Node tmp = current.Next;
                current.Next = new Node(value);
                current.Next.Next = tmp;
            }
            Length++;
        }

        public void AddByIndex(int index, int[] values)
        {
            Node current;
            Node tmp;
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }

            else if (index == 0)
            {
                AddToStart(values);
            }

            else
            {
                current = _root;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                for (int i = 0; i < values.Length; i++)
                {
                    tmp = current.Next;
                    current.Next = new Node(values[i]);
                    current = current.Next;
                }
                Length += values.Length;
            }
        }

        public void Delete()
        {
            if (Length > 0)
            {
                Node current = _root;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
                Length--;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public void Delete(int numberOfValues)
        {
            if(numberOfValues>Length)
            {
                throw new InvalidOperationException();
            }
            else if(numberOfValues<0) 
            {
                throw new ArgumentException();
            }
            else
            {
                Node current = _root;
                int count = 0;
                while (current != null)
                {
                    current = current.Next;
                    count++;
                }
                current = _root;
                for (int i = 0; i < (count - numberOfValues); i++)
                {
                    current = current.Next;
                }
                Length -= numberOfValues;
            }

        }

        public void DeleteToStart()
        {
            if (Length<0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                _root = _root.Next;
                Length--;
            }

        }

        public void DeleteToStart(int numberOfValues)
        {
            if (numberOfValues > Length)
            {
                throw new InvalidOperationException();
            }
            else if (numberOfValues < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i < numberOfValues; i++)
                {
                    _root = _root.Next;
                }
                Length -= numberOfValues;
            }

        }

        public void DeleteByIndex(int index)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }

            else if(index==0)
            {
                DeleteToStart();
            }

            else
            {
                Node current = _root;
                for (int i = 1; i<index; i++)
                {
                    current = current.Next;
                }
                current = current.Next;
                Length--;
            }
        }
        
        public void DeleteByIndex(int index, int numberOfValues)
        {
            if (numberOfValues > Length)
            {
                throw new InvalidOperationException();
            }
            else if (numberOfValues < 0)
            {
                throw new ArgumentException();
            }
            else if (index == 0)
            {
                DeleteToStart(numberOfValues);
            }
            else
            {
                Node current = _root;
                Node tmp;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                tmp = current;
                for (int i = index; i < index + numberOfValues; i++)
                {
                    tmp = tmp.Next;
                }
                current = tmp.Next;
                Length -= numberOfValues;
            }
        }
        
        public int GetTheLength()
        {
            Node current = _root;
            int count = 0;
            while (current != null)
            {
                current = current.Next;
                count++;
            }
            return count;
        }

        public int GetAccessByIndex(int index)
        {
            Node current = _root;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public int GetIndexByValue(int value)
        {
            Node current = _root;
            int count = 0;
            while (current.Next != null)
            {
                if (current.Value == value)
                {
                    return count;
                }
                current = current.Next;
                count++;
            }
            return count;
        }

        public void ChangeByIndex(int index, int value)
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }

            else if (index == 0)
            {
                _root.Value = value;
            }

            else
            {
                Node current = _root;
                for (int i = 1; i < index; i++)
                {
                    current = current.Next;
                }
                current.Next = new Node(value);
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
                Node oldRoot = _root;
                Node tmp;
                while (oldRoot.Next != null)
                {
                    tmp = oldRoot.Next;
                    oldRoot.Next = oldRoot.Next.Next;
                    tmp.Next = _root;
                    _root = tmp;
                }
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
                int tmp = _root.Value;
                Node current = _root;
                while (current != null)
                {
                    if (current.Value > tmp)
                    {
                        tmp = current.Value;
                    }
                    current = current.Next;
                }
                return tmp;
            }
        }

        public int FindMinElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                int tmp = _root.Value;
                Node current = _root;
                while (current != null)
                {
                    if (current.Value < tmp)
                    {
                        tmp = current.Value;
                    }
                    current = current.Next;
                }
                return tmp;
            }
        }

        public int FindIndexOfMaxElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                int max = FindMaxElement();
                int count = 0;
                Node current = _root;
                while (current != null)
                {
                    if (max == current.Value)
                    {
                        break;
                    }
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public int FindIndexOfMinElement()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                int min = FindMinElement();
                int count = 0;
                Node current = _root;
                while (current != null)
                {
                    if (min == current.Value)
                    {
                        break;
                    }
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public void SortMinToMax()
        {
            if (Length < 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Node current = _root;
                for (int i = 0; i < Length; i++)
                {
                    current = _root;
                    for (int j = 1; j < Length - i; j++)
                    {
                        if (current.Value > current.Next.Value)
                        {
                            int tmp = current.Next.Value;
                            current.Next.Value = current.Value;
                            current.Value = tmp;
                        }
                        current = current.Next;
                    }
                }
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
                Node current = _root;
                for (int i = 0; i < Length; i++)
                {
                    current = _root;
                    for (int j = 1; j < Length - i; j++)
                    {
                        if (current.Value < current.Next.Value)
                        {
                            int tmp = current.Next.Value;
                            current.Next.Value = current.Value;
                            current.Value = tmp;
                        }
                        current = current.Next;
                    }
                }
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
                if (_root.Value==value)
                {
                    _root = _root.Next;
                }
                else
                {
                    Node current = _root;
                    while (current != null)
                    {
                        if (current.Next.Value == value)
                        {
                            current.Next = current.Next.Next;
                            break;
                        }
                        current = current.Next;
                    }
                }
                Length--;

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
                Node last = null;
                Node current = _root;
                while (current != null)
                {
                    if (current.Value==value)
                    {
                        DeleteFirstElementByValue(value);
                    }
                    current = current.Next;
                }
            }
        }
    }
}

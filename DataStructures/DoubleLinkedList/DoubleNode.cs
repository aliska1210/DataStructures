using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.DoubleLinkedList
{
    class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode(int value)
        {
            Value = value;
            Previous = null;
            Next = null;
        }
    }
}

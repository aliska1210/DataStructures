using DataStructures;
using NUnit.Framework;
using System.Collections.Generic;

namespace ArrayListTests
{
    public class Tests
    {
        [TestCase(0)]
        public void ConstructorTest(int expected)
        {
            ArrayList Array = new ArrayList();
            int actual = Array.Length;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(4659, 1)]
        [TestCase(-864, 1)]
        [TestCase(4, 1)]
        public void ConstructorTest(int value, int expected)
        {
            ArrayList Array = new ArrayList(value);
            int actual = Array.Length;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[3] { 0, 1, 2 }, 3)]
        [TestCase(new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 10)]
        [TestCase(new int[7] { 0, 1, 2, 3, 4, 5, 6 }, 7)]
        public void ConstructorTest(int[] values, int expected)
        {
            ArrayList Array = new ArrayList(values);
            int actual = Array.Length;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 2, new int[1] { 2 })]
        [TestCase(new int[2] { 0, 1 }, 2, new int[3] { 0, 1, 2 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 2, new int[6] { 0, 1, 2, 3, 4, 2 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 27, new int[21] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 27 })]
        public void AddTest(int[] array, int value, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.Add(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[2] { 0, 1 }, new int[2] { 2,3}, new int[4] { 0, 1, 2,3 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[3] { 5, 6,7 }, new int[8] { 0, 1, 2, 3, 4, 5,6,7 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, new int[4] { 20, 21,22,23 }, new int[24] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,21,22,23 })]
        public void AddTest(int[] array, int[] values, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.Add(values);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[2] { 0, 1 }, 2, new int[3] { 2, 0, 1 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 2, new int[6] { 2, 0, 1, 2, 3, 4 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 27, new int[21] { 27, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void AddToStartTest(int[] array, int value, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.AddToStart(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[2] { 0, 1 }, new int[2] { 2, 3 }, new int[4] { 2, 3, 0, 1 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[3] { 5, 6, 7 }, new int[8] { 5, 6, 7, 0, 1, 2, 3,4 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, new int[4] { 20, 21, 22, 23 }, new int[24] { 20, 21, 22, 23, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void AddToStartTest(int[] array, int[] values, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.AddToStart(values);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 0, 5, new int[5] { 5, 1, 2, 3, 4 })]
        [TestCase(new int[2] { 0, 1 }, 1, 2, new int[3] { 0, 2, 1 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 5, 2, new int[6] { 0, 1, 2, 3, 4, 2 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 0, 27, new int[21] { 27, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void AddByIndexTest(int[] array, int index, int value, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 0, new int[2] { 2, 3 }, new int[6] { 2, 3, 1,2,3,4 })]
        [TestCase(new int[2] { 0, 1 }, 1, new int[3] { 5, 6, 7 }, new int[5] { 0, 5, 6, 7, 1})]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 20, new int[4] { 20, 21, 22, 23 }, new int[24] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23 })]
        public void AddByIndexTest(int[] array, int index, int[] values, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, values);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[3] { 1, 2, 3 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[4] { 0, 1, 2, 3 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, new int[19] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 })]
        public void DeleteTest(int[] array, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.Delete();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 },2, new int[2] { 1, 2 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 },4, new int[1] { 0 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 },10, new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9})]
        public void DeleteTest(int[] array, int numberOfValues, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.Delete(numberOfValues);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, new int[3] { 2, 3, 4 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[4] { 1, 2, 3, 4 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, new int[19] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void DeleteToStartTest(int[] array, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.DeleteToStart();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 2, new int[2] { 3, 4 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 4, new int[1] { 4 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 10, new int[10] { 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void DeleteToStartTest(int[] array, int numberOfValues, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.DeleteToStart(numberOfValues);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 0, new int[3] { 2, 3, 4 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 3, new int[4] { 0, 1, 2, 4 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 20, new int[19] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, })]
        public void DeleteByIndexTest(int[] array, int index, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.DeleteByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 0, 2, new int[2] { 3, 4 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 2, 3, new int[2] { 0, 1 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 15, 5, new int[15] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14})]
        public void DeleteByIndexTest(int[] array, int index, int numberOfValues, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.DeleteByIndex(index, numberOfValues);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 5)]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 20)]
        public void GetTheLengthTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.GetTheLength();


            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 0, 1)]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 3, 3)]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 19, 19)]
        public void GetAccessByIndexTest(int[] array, int index, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.GetAccessByIndex(index);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 1, 2, 3, 4 }, 1, 0)]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 3, 3)]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 19, 19)]
        public void GetIndexByValueTest(int[] array, int value, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.GetIndexByValue(value);

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[4] { 0, 1, 2, 3 }, 0, -7, new int[4] { -7, 1, 2, 3 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 3, -7, new int[5] { 0, 1, 2, -7, 4 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 19, 100, new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 100 })]
        public void ChangeByIndexTest(int[] array, int index, int value, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.ChangeByIndex(index, value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 0, 1, 2, 3 }, new int[4] { 3, 2, 1, 0 })]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, new int[5] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, new int[20] { 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        public void ReverseTest(int[] array, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.Reverse();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 0, 1, 2, 3 }, 3)]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 4)]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 19)]
        public void FindMaxElementTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 0, 1, 2, 3 }, 0)]
        [TestCase(new int[5] { 0, 1, 2, 3, 4 }, 0)]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 }, 0)]
        public void FindMinElementTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 0, 1, 2, 3 }, 3)]
        [TestCase(new int[5] { 4, 1, 2, 3, 0 }, 0)]
        [TestCase(new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 19, 10, 11, 12, 13, 14, 15, 16, 17, 18, 9 }, 9)]
        public void FindIndexOfMaxElementTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindIndexOfMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 0, 1, 2, 3 }, 0)]
        [TestCase(new int[5] { 4, 1, 2, 3, 0 }, 4)]
        [TestCase(new int[20] { 19, 1, 2, 3, 4, 5, 6, 7, 8, 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 9 }, 9)]
        public void FindIndexOfMinElementTest(int[] array, int expected)
        {
            ArrayList Array = new ArrayList(array);
            int actual = Array.FindIndexOfMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 3, 1, 0, 2 }, new int[4] { 0, 1, 2, 3 })]
        [TestCase(new int[5] { 4, 1, 2, 3, 0 }, new int[5] { 0, 1, 2, 3, 4 })]
        [TestCase(new int[20] { 19, 1, 2, 4, 3, 5, 6, 7, 8, 0, 10, 11, 12, 13, 16, 15, 14, 17, 18, 9 }, new int[20] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 })]
        public void SortMinToMaxTest(int[] array, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.SortMinToMax();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 3, 1, 0, 2 }, new int[4] { 3, 2, 1, 0 })]
        [TestCase(new int[5] { 4, 1, 2, 3, 0 }, new int[5] { 4, 3, 2, 1, 0 })]
        [TestCase(new int[20] { 19, 1, 2, 4, 3, 5, 6, 7, 8, 0, 10, 11, 12, 13, 16, 15, 14, 17, 18, 9 }, new int[20] { 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 })]
        public void SortMaxToMinTest(int[] array, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.SortMaxToMin();

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[4] { 3, 1, 3, 2 }, 3, new int[3] { 1, 3, 2 })]
        [TestCase(new int[5] { 4, 1, 4, 3, 4 }, 4, new int[4] { 1, 4, 3, 4 })]
        [TestCase(new int[20] { 19, 1, 2, 4, 3, 5, 6, 7, 8, 19, 10, 11, 12, 13, 16, 15, 14, 17, 18, 9 },19, new int[19] { 1, 2, 4, 3, 5, 6, 7, 8, 19, 10, 11, 12, 13, 16, 15, 14, 17, 18, 9 })]
        public void DeleteFirstElementByValueTest(int[] array, int value, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.DeleteFirstElementByValue(value);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[5] { 2, 2, 2, 2, 2 }, 2, new int[] { })]
        [TestCase(new int[5] { 2, 2, 2, -3, 4}, 2, new int[2] { -3, 4 })]
        [TestCase(new int[4] { 3, 1, 3, 2 },3, new int[2] { 1, 2 })]
        [TestCase(new int[5] { 4, 1, 4, 3, 4 },4, new int[2] { 1, 3 })]
        [TestCase(new int[20] { 19, 1, 2, 4, 3, 5, 6, 7, 8, 19, 10, 11, 12, 13, 16, 15, 14, 17, 18, 9 },19, new int[18] { 1, 2, 4, 3, 5, 6, 7, 8, 10, 11, 12, 13, 16, 15, 14, 17, 18, 9 })]
        public void DeleteAllElementsByValueTest(int[] array, int value, int[] exp)
        {
            ArrayList expected = new ArrayList(exp);
            ArrayList actual = new ArrayList(array);
            actual.DeleteAllElementsByValue(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
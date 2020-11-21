using System;
using System.Linq;

namespace DataStructures
{
    public class ArrayList: IList
    {
        public int Length { get; private set; }

        private int[] _array;

        private int _TrueLenght
        {
            get
            {
                return _array.Length;
            }
        }

        public ArrayList()
        {
            _array = new int[9];
            Length = 0;
        }

        public ArrayList(int value)
        {
            _array = new int[9];
            _array[0] = value;
            Length = 1;
        }

        public ArrayList(int[] values)
        {
            _array = new int[(int)(values.Length * 1.33d)];
            Length = values.Length;
            Array.Copy(values, _array, values.Length);
        }


        public int this[int i]
        {
            get
            {
                if (i >= Length || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                return _array[i];
            }
            set
            {
                if (i >= Length || i < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                _array[i] = value;
            }
        }

        public override bool Equals(object obj)
        {
            ArrayList arrayList = (ArrayList)obj;

            if (Length != arrayList.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_array[i] != arrayList._array[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            return string.Join(", ", _array.Take(Length));
        }

        private void IncreaseLenght(int number = 1)
        {
            int newLenght = _TrueLenght;
            while (newLenght <= Length + number)
            {
                newLenght = (int)(newLenght * 1.33 + 1);
            }

            int[] newArray = new int[newLenght];
            /*for(int i = 0; i<=Lenght+number; i++)
            {
                newArray[i] = _array[i];
            }
            */
            Array.Copy(_array, newArray, _TrueLenght);
            _array = newArray;
        }

        private void DecreaseLength(int number = 1)
        {
            int newLength = _TrueLenght;
            int[] newArray = new int[newLength];
            if (Length>0&& _TrueLenght / Length >= 2)
            {
                newLength = newLength * 2 / 3 + number;
                Array.Copy(_array, newArray, Length);
                _array = newArray;
            }
        }

        public void Add(int value)
        {
            if (_TrueLenght <= Length)
            {
                IncreaseLenght();
            }
            _array[Length] = value;
            Length++;
        }

        public void Add(int[] values)
        {
            int startIndex =Length;
            int valuesIndex = 0;
            Length = Length + values.Length;
            if (_TrueLenght <= Length)
            {
                IncreaseLenght(values.Length);
            }

            for (int i = startIndex; i< Length; i++)
            {
                _array[i] = values[valuesIndex];
                valuesIndex++;
            }
        }

        public void AddToStart(int value)
        {
            if (Length <= _TrueLenght)
            {
                IncreaseLenght();
            }
            for (int i = Length+1; i >= 1; i--)
            {
                _array[i] = _array[i - 1];
            }
            _array[0] = value;
            Length++;
        }

        public void AddToStart(int[] values)
        {
            int startIndex = values.Length; 
            Length = Length + values.Length;

            if (_TrueLenght <= Length)
            {
                IncreaseLenght(values.Length);
            }

            for (int i = Length; i >=startIndex; i--)
            {
                _array[i] = _array[i-startIndex];
            } 

            for (int i = 0; i < startIndex; i++)
            {
                _array[i] = values[i];
            }

        }

        public void AddByIndex(int index, int value)
        {
            if(index>=0 && index <Length+1)
            {
                if (Length <= _TrueLenght)
                {
                    IncreaseLenght();
                }
                for (int i = Length + 1; i > index; i--)
                {
                    _array[i] = _array[i - 1];
                }
                _array[index] = value;
                Length++;
            }

            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void AddByIndex(int index, int[] values)
        {
            int valuesIndex = 0;
            int lastIndex = index+ values.Length;
            Length = Length + values.Length;

            if (_TrueLenght <= Length)
            {
                IncreaseLenght(values.Length);
            }

            for (int i = Length-1; i >= lastIndex; i--)
            {
                _array[i] = _array[i - lastIndex+index];
            }

            for (int i = index; i < lastIndex; i++)
            {
                _array[i] = values[valuesIndex];
                valuesIndex++;
            }

        }

        public void Delete()
        {
            _array[Length-1] = 0;
            Length--;
            DecreaseLength();
        }
        
        public void Delete(int numberOfValues)
        {
            for (int i = Length-numberOfValues; i<Length; i++)
            {
                _array[i] = 0;
            }
            Length = Length - numberOfValues;

            DecreaseLength();
        }

        public void DeleteToStart()
        {
            for (int i = 0; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            DecreaseLength();
        }

        public void DeleteToStart(int numberOfValues)
        {
            for (int i = 0; i <Length/2; i++)
            {
                _array[i] = _array[i + numberOfValues];
            }
            Length=Length-numberOfValues;
            DecreaseLength();
        }

        public void DeleteByIndex(int index)
        {
            for (int i = index; i < Length; i++)
            {
                _array[i] = _array[i + 1];
            }
            Length--;
            DecreaseLength();
        }
        
        public void DeleteByIndex(int index, int numberOfValues)
        {
            for (int i = index; i < Length-numberOfValues; i++)
            {
                _array[i] = _array[i + numberOfValues];
            }
            Length = Length - numberOfValues;
            DecreaseLength();
        }
        
        public int GetTheLength()
        {
            return Length;
        }

        public int GetAccessByIndex(int index)
        {
            return _array[index];
        }

        public int GetIndexByValue(int value)
        {
            for(int i = 0; i< Length; i++)
            {
                if (_array[i]==value)
                {
                    return i;
                }  
            }
            return -1;
        }

        public void ChangeByIndex(int index, int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == index)
                {
                    _array[i] = value;
                }
            }
        }

        public void Reverse()
        {
            int tmp = 0;
            for (int i = 0; i < Length/2; i++)
            {
                tmp = _array[i];
                _array[i] = _array[Length-1-i];
                _array[Length - 1 - i] = tmp;

            }
        }

        public int FindMaxElement()
        {
            int tmp = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] >= tmp)
                {
                    tmp = _array[i];
                }
            }
            return tmp;
        }

        public int FindMinElement()
        {
            int tmp = _array[0];
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] <= tmp)
                {
                    tmp = _array[i];
                }
            }
            return tmp;
        }

        public int FindIndexOfMaxElement()
        {
            int maxElement = FindMaxElement();
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == maxElement)
                {
                    index = i;
                }
            }
            return index;
        }

        public int FindIndexOfMinElement()
        {
            int minElement = FindMinElement();
            int index = 0;
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == minElement)
                {
                    index = i;
                }
            }
            return index;
        }

        public void SortMinToMax()
        {
            int tmp = 0;
            for (int i = 0; i <= Length - 1; i++)
            {
                int minIndex = i;

                for (int j = i; j <= Length - 1; j++)
                {
                    if (_array[j] < _array[minIndex])
                    {
                        minIndex = j;
                    }

                }
                tmp = _array[i];
                _array[i] = _array[minIndex];
                _array[minIndex] = tmp;
            }
        }

        public void SortMaxToMin()
        {
            int tmp = 0;
            for (int i = 0; i < Length - 1; i++)
            {
                for (int j = 1; j <= Length - 1; j++)
                {
                    if (_array[j] > _array[j - 1])
                    {
                        tmp = _array[j - 1];
                        _array[j - 1] = _array[j];
                        _array[j] = tmp;
                    }
                }
            }
        }

        public void DeleteFirstElementByValue(int value)
        {
            for (int i = 0; i <= value; i++)
            {
                if (_array[i] == value)
                {
                    for (int j = i; j < Length; j++ )
                    {
                        _array[j] = _array[j + 1];
                    }
                    Length--;
                    break;
                }
            }
            DecreaseLength();
        }

        public void DeleteAllElementsByValue(int value)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_array[i] == value)
                {
                    for (int j = i; j < Length; j++)
                    {
                        _array[j] = _array[j + 1];
                    }
                    i -= 1;
                    Length--;
                }
            }
            DecreaseLength();
        }

    }
}

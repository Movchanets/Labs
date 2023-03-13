using System.Text;

namespace ClassLibrary1;

public class MyList<T> {
   private int _size;
   private int _capacity;
   private T[] _array;
   public MyList()
    {
        _size = 0;
        _capacity = 1;
        _array = new T[_capacity];
    }
   public MyList(params T[] array)
   {
       
         _size = array.Length;
         _capacity = array.Length;
         _array = new T[_capacity];
         for (int i = 0; i < _size; i++)
         {
              _array[i] = array[i];
         }
   }
   public MyList(MyList <T> list)
   {
         _size = list._size;
         _capacity = list._capacity;
         _array = new T[_capacity];
         for (int i = 0; i < _size; i++)
         {
              _array[i] = list._array[i];
         }
   }
   public int Capacity
   {
       get => _capacity;
   }

   public static bool operator ==(MyList<T> arr1, MyList<T> arr2)
   {
         if (arr1._size != arr2._size)
         {
              return false;
         }
         for (int i = 0; i < arr1._size; i++)
         {
              if (!arr1._array[i].Equals(arr2._array[i]))
              {
                return false;
              }
         }
         return true;
   }
    public static bool operator !=(MyList<T> arr1, MyList<T> arr2)
    {
            return !(arr1 == arr2);
    }
   public void Add(T element)
   {
         if (_size == _capacity)
         {
              _capacity *= 2;
              T[] newArray = new T[_capacity];
              for (int i = 0; i < _size; i++)
              {
                newArray[i] = _array[i];
              }
              _array = newArray;
         }
         _array[_size] = element;
         _size++;
   }

   public MyList<T> Concat(MyList<T> list)
   {
       _array = _array.Concat(list._array).ToArray();
       return this;
   }
    public void AddRange(params T[] array)
    {
          for (int i = 0; i < array.Length; i++)
          {
                Add(array[i]);
          }
    }
    public void Insert(int index, T element)
    {
        if (index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException();
        }
        if (_size == _capacity)
        {
            _capacity *= 2;
            T[] newArray = new T[_capacity];
            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        for (int i = _size; i > index; i--)
        {
            _array[i] = _array[i - 1];
        }
        _array[index] = element;
        _size++;
    }
    public void Clear()
    {
        _size = 0;
        _capacity = 1;
        _array = new T[_capacity];
    }
   public void RemoveAt(int index)
   {
        if (index < 0 || index >= _size)
        {
            throw new IndexOutOfRangeException();
        }
        for (int i = index; i < _size - 1; i++)
        {
            _array[i] = _array[i + 1];
        }
        _size--;
   }
   public void Reverse()
   {
        for (int i = 0; i < _size / 2; i++)
        {
            (_array[i], _array[_size - i - 1]) = (_array[_size - i - 1], _array[i]);
        }
   }
    public int Count => _size;
    public T this[int index]
    {
        get => _array[index];
        set => _array[index] = value;
    }
    public void InsertRange(int index, params T[] array)
    {
        if (index < 0 || index > _size)
        {
            throw new IndexOutOfRangeException();
        }
        if (_size + array.Length > _capacity)
        {
            _capacity = _size + array.Length;
            T[] newArray = new T[_capacity];
            for (int i = 0; i < _size; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
        for (int i = _size + array.Length - 1; i >= index + array.Length; i--)
        {
            _array[i] = _array[i - array.Length];
        }
        for (int i = 0; i < array.Length; i++)
        {
            _array[index + i] = array[i];
        }
        _size += array.Length;
    }
  
}

public class StringNumber
{
    MyList<char> _number = new MyList<char>();

    
    public StringNumber()
    {
    }

    public StringNumber(string number)
    {
        if(string.IsNullOrEmpty(number)){return;}
        int i = 0;
      

        while (number[i] == '0' && i < number.Length)
        {
            i++;
        }
        
        for (; i < number.Length; i++)
        {
          if (char.IsNumber(number[i]))
                {
                    _number.Add(number[i]);
                }
            
        }
        if(_number.Count == 0)
        {
            _number.Add('0');
            
        }
        
    }
    public StringNumber(params char[] array)
    {
     
        for (int i = 0; i < array.Length; i++)
        {
            if (char.IsNumber(array[i]))
            {
                _number.Add(array[i]);
            }
        }
    }
    public StringNumber (StringNumber number)
    {
        _number = new MyList<char>(number._number);
      
    }
    public int Length => _number.Count;
    public char this[int index]
    {
        get => _number[index];
        set { if(char.IsNumber(value)){ _number[index] = value;} }
    }
    public void SetNumber(string number)
    {
        _number.Clear();
        if(string.IsNullOrEmpty(number)){return;}
        int i = 0;
        while (number[i] == '0' && i < number.Length)
        {
            i++;
        }
        for (; i < number.Length; i++)
        {
            if (char.IsNumber(number[i]))
            {
                _number.Add(number[i]);
            }
        }
        if(_number.Count == 0)
        {
            _number.Add('0');
        }
    }
    public void Reverse()
    {
        _number.Reverse();
    }
    public StringNumber Concat(StringNumber number)
    {
        _number.Concat(number._number);
        return this;
    }
    public void InsertRange(int index, params char[] array)
    {
        _number.InsertRange(index, array);
    }
    public static StringNumber operator ^(StringNumber number1, StringNumber number2)
    {
        StringNumber result = new StringNumber();
        int i = number1.Length - 1;
        int j = number2.Length - 1;
        int temp = 0;
        while (i >= 0 || j >= 0)
        {
            int sum = temp;
            if (i >= 0)
            {
                sum += number1[i] - '0';
                i--;
            }
            if (j >= 0)
            {
                sum += number2[j] - '0';
                j--;
            }
            result.Add((char)(sum % 10 + '0'));
            temp = sum / 10;
        }
        if (temp > 0)
        {
            result.Add((char)(temp + '0'));
        }
        result.Reverse();
        return result;
    }

    public static StringNumber operator *(StringNumber number, int n)
    {
        number.AddRange( n.ToString().ToCharArray());
        return number;
    }
    public static StringNumber operator *(int n, StringNumber number)
    {
        number.InsertRange(0, n.ToString().ToCharArray());
        return number;
    }

    public static StringNumber operator +(StringNumber n1, StringNumber n2)
    {
        return n1.Concat(n2);
    }
    public static bool operator ==(StringNumber n1, StringNumber n2)
    {
      return n1._number == n2._number;
    }
    public static bool operator !=(StringNumber n1, StringNumber n2)
    {
        return !(n1._number == n2._number);
    }

    public static StringNumber operator --(StringNumber number)
    {
        StringNumber result = new StringNumber(number);
        result.RemoveAt(result.Length - 1);
        return result;
    }
    public  static bool operator true(StringNumber number)
    {
        return number.Length > 0;
    }
    public static bool operator false(StringNumber number)
    {
        return number.Length == 0;
    }
    public void Add(char element)
    {
        if (char.IsNumber(element))
        {
            _number.Add(element);
        }
    }
    public void AddRange(params char[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (char.IsNumber(array[i]))
            {
                _number.Add(array[i]);
            }
        }
    }
    public void Insert(int index, char element)
    {
        if (char.IsNumber(element))
        {
            _number.Insert(index, element);
        }
    }
    public void Clear()
    {
        _number.Clear();
    }
    public void RemoveAt(int index)
    {
        _number.RemoveAt(index);
    }
    
    public override string ToString()
    {
        StringBuilder result = new StringBuilder("");
       

        int i = 0;
        while (_number[i] == '0' && i < _number.Count)
        {
            i++;
        }
        for (; i < _number.Count; i++)
        {
            result.Append(_number[i]);
        }
        return result.ToString();
    }
}
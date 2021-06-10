using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            sehirler.Add("Bursa");
            Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            sehirler2.Add("Bursa");
            Console.WriteLine(sehirler2.Count);

        }
    }
    //Generic Class
    class MyList<T> //burada ki T sayesinde string verirsek string, int verirsek int farklı bir class verirsek o olur yukarıda. T Type'dan gelir.
    {
        T[] _Array;
        T[] _tempArray; //Bunu var olan diziyi newlerken önceki diziyi ve elemanlarının referansını kaybetmemek için yazarız.
        public MyList()
        {
            _Array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _Array;
            _Array = new T[_Array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _Array[i] = _tempArray[i];
            }
            _Array[_Array.Length - 1] = item;
        }

        public int Count
        {
            get { return _Array.Length; }
        }

    }

}

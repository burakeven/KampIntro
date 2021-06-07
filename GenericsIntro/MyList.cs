using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Only I can change my life. No one can do it for me.
//Always do your best. What you plant now, you will harvest tomorrow.
//It does not matter how slowly you go as long as you do not stop.
namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList() //ctor yaz tab twice
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //bu sayede referans kaybolmayacak ve alt satırda hata olmayacak.
            items = new T[items.Length+1]; //dinamik yaptı, mevcut eleman sayısını 1 arttırdı. Her girdi de 1 arttıracak.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item; //lenght eleman sayısını verir, atıyorum 6 elemanlıysa son indexi almak için 6-1 yapariz ve beşinci indexe ulaşmış oluruz.
        }
        public int Lenght //diğer ders konusu, simdilik burda dursun
        {
            get { return items.Length; } 
        }
        
        public T[] Items
        {
            get { return items; }
        }
    }
}

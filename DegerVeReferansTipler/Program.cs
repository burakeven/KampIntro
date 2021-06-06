using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999

            /*int,decimal,float,double,bool = bunlar birer deger tipleridir
             array,class interface=bunlar ise birer referans tipleridir.
            */

            /*
                                STACK                                                       HEAP
               sayi1=10 --> asama 1 = bu artık 30 olur    
               sayi2=30 --> asama 2= bu artık 65'e tanımlanmış olur
              
             
             */

            /*                   STACK                                                                  HEAP
             *         101/sayilar1 = bu dizi sayilar2'esitlenince 102'i referans edinmiş olur.    101/[10,20,30] = bunun olayi artik kalmamis oluyor
             *         102/sayilar2                                                                102/[100,200,300]
                
             
             */
        }
    }
}

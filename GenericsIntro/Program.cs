using System;
using System.Collections.Generic;
//Only I can change my life. No one can do it for me.
//Always do your best. What you plant now, you will harvest tomorrow.
//It does not matter how slowly you go as long as you do not stop.
namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>(); //arkaplanda aslında bir array yönetir. |Nasıl yaparım?|
            names.Add("Engin");

            Console.WriteLine(names.Lenght);

            names.Add("Kerem");
            Console.WriteLine(names.Lenght);
            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }

        }
    }
}

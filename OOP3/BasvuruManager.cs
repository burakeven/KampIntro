using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager)
        {
            //Basvuran bilgilerini degerlendirme
            //
           
            creditManager.Calculate();
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculate();
            }
        }
    }
}

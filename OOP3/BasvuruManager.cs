using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerService> loggerService)
        {
            //Basvuran bilgilerini degerlendirme
            //
           
            creditManager.Calculate();
            foreach (var item in loggerService)
            {
                item.Log();
            }
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

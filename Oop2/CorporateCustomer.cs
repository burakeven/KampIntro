using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //Bu iki nokta ve ardından diger Class'ı yazmamız miras almadır yani Inheritence'dır. CorporateCustomer Customer'dan miras alır.
    class CorporateCustomer :Customer
    {
        
        public string CompanyName { get; set; }

        public string TaxNo { get; set; }
    }
}

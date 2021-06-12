using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    //Bu iki nokta ve ardından diger Class'ı yazmamız miras almadır yani Inheritence'dır. IndividualCustomer Customer'dan miras alır.
    class IndividualCustomer:Customer
    {
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

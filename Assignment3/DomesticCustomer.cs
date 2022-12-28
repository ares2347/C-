using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class DomesticCustomer : Customer
    {
        public CustomerCategory Category { get; set; }

        public DomesticCustomer()
        {
            if (Usage < 50)
            {
                Price= Usage * 1000;
            }
            else if (Usage<100)
            {
                Price= 50 * 1000 + (Usage-50)*1200;
            }
            else if (Usage<200)
            {
                Price = 50 * 1000 + 50 * 1200 + (Usage - 100) * 1500;
            }
            else
            {
                Price = 50 * 1000 + 50 * 1200 + 100 * 1500 + (Usage - 200) * 2000;
            }
        }

    }
}

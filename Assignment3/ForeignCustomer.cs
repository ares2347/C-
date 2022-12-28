using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class ForeignCustomer : Customer
    {
        public string Nationality { get; set; }
        public ForeignCustomer()
        {
            Price = 2000 * Usage;
        }
    }
}

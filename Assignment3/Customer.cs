using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }  
        public float Usage { get; set; }
        public float Price { get; protected set; }
    }
}

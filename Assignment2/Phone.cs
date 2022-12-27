﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal abstract class Phone
    {
        public abstract void InsertPhone(string name, string phone);
        public abstract void RemovePhone(string name);
        public abstract void UpdatePhone(string name, string newPhone);
        public abstract List<string> SearchPhone(string name);
        public abstract void Sort();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class PhoneBook : Phone
    {
        public List<PhoneModel> PhoneList { get; set; }
        public override void InsertPhone(string name, string phone)
        {
            if (PhoneList.Exists(x => x.Name == name))
            {
                var exist = PhoneList.FirstOrDefault(x => x.Name == name);
                if(!exist.Phone.Contains(phone))
                {
                    exist.Phone.Add(phone); 
                }
            }
            else
            {
                PhoneList.Add(new PhoneModel
                {
                    Name = name,
                    Phone = new List<string>() { phone}
                }) ;
            };
        }

        public override void RemovePhone(string name)
        {
            PhoneList.Remove(PhoneList.FirstOrDefault(x => x.Name == name));
        }

        public override List<string> SearchPhone(string name)
        {
            return PhoneList.FirstOrDefault(x => x.Name == name).Phone;
        }

        private static int PhoneComparer(PhoneModel x, PhoneModel y)
        {
            return x.Name.CompareTo(y.Name);
        }
    public override void Sort()
        {
            PhoneList.Sort(PhoneComparer);
        }

        public override void UpdatePhone(string name, string newPhone)
        {
            var exist = PhoneList.FirstOrDefault(x => x.Name==name);
            exist.Phone = new List<string> { newPhone };
        }
    }
}

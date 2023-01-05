using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class ManagerHouse
    {
        private List<HanoiHouse> houses;
        public List<HanoiHouse> Houses {get => houses;}

        public ManagerHouse()
        {
            houses = new List<HanoiHouse>();
        }

        public void Display()
        {
            foreach(HanoiHouse house in houses)
            {
                house.Display();
            }
        }
        public void Insert(HanoiHouse house)
        {
            houses.Add(house);
        }
        public void Insert(List<HanoiHouse> _houses)
        {
            houses.AddRange(_houses);
        }

        public void Sort()
        {
            houses.Sort((a, b) =>  a.DiaChi.CompareTo(b.DiaChi));
        }
        public HanoiHouse SearchByAddress(string diaChi)
        {
            return houses.Find(x => x.DiaChi.Equals(diaChi));
        }
    }
}

using house.cm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.hanoi
{
    internal class HanoiHouse : House
    {
        private string tenQuan;
        public string TenQuan { get => tenQuan; set => tenQuan = value; }
        public HanoiHouse()
        {
        }

        public HanoiHouse(string soNha, string diaChi, string loaiNha, string tenQuan) : base(soNha, diaChi, loaiNha)
        {
            TenQuan = tenQuan;
        }

        public void Input(HanoiHouse house)
        {
            SoNha = house.SoNha;
            DiaChi = house.DiaChi;
            LoaiNha = house.LoaiNha;
            TenQuan= house.TenQuan;
        }
        

    }
}

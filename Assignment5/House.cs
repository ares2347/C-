using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace house.cm
{
    public class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;

        public string SoNha { get => soNha; set => soNha = value; } 
        public string DiaChi { get => diaChi;set=> diaChi = value; }
        public string LoaiNha { get => loaiNha;set=> loaiNha = value; }

        public House()
        {

        }

        public House(string _soNha, string _diaChi, string _loaiNha)
        {
            soNha = _soNha;
            diaChi = _diaChi;
            loaiNha = _loaiNha;
        }

        public void Display()
        {
            Console.WriteLine($"{SoNha} - {DiaChi} - {LoaiNha}");
        }

        public void Input(House house)
        {
            SoNha = house.SoNha;
            DiaChi = house.DiaChi;
            LoaiNha = house.LoaiNha;
        }
    }
}

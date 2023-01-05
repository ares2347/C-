using house.hanoi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal static class Menu
    {
        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("HOUSE MANAGER!");
            Console.WriteLine("Menu");
            Console.WriteLine("1.Input");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Sort and Display");
            Console.WriteLine("4.Search by address");
            Console.Write("Please select your action:");
        }
        public static int ReadChoice()
        {
            var action = Console.ReadKey().KeyChar;
            int.TryParse(action.ToString(), out int res);
            if (res == null) throw new Exception("Invalid Action");
            return res;
        }

        public static void HandleChoice(int action, List<HanoiHouse> houses)
        {
            do
            {
                switch (action)
                {
                    case 0:
                        break;
                    case 1:
                        var house = new HanoiHouse();
                        Console.Clear();

                        Console.WriteLine("Input So nha:");
                        house.SoNha = Console.Read().ToString();

                        Console.WriteLine("Input Dia chi:");
                        house.DiaChi = Console.Read().ToString();

                        Console.WriteLine("Input Loai nha:");
                        house.LoaiNha = Console.Read().ToString();

                        Console.WriteLine("Input Ten Quan:");
                        house.TenQuan = Console.Read().ToString();

                        houses.Add(house);
                        Console.WriteLine("House Inserted");

                        Clear();
                        break;
                    case 2:
                        Console.WriteLine();
                        Clear();
                        break;
                    case 3:
                        Console.WriteLine();
                        Clear();
                        break;
                    case 4:
                        Console.WriteLine();
                        Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid Action");
                        break;
                }
            } while (!new List<int> { 0, 1, 2, 3, 4 }.Contains(action));
        }

        public static void Clear()
        {
            Console.Write("Press Any Key To Continue");
            Console.Read();
            Console.Clear();
        }
    }
}

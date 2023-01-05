using house.hanoi;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var houseManager = new ManagerHouse();
            int action;
            do
            {
                Menu.ShowMenu();
                action = Menu.ReadChoice();
                Menu.HandleChoice(action, houseManager.Houses);
            } while (action != 0);
        }
    }
}
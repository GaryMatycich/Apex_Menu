using System;
using System.Collections.Generic;
using System.Text;

namespace ApexMenu
{
    public class Menu
    {
        public bool MainMenuScreen()
        {
            Console.Clear();
            Console.WriteLine("Apex Legends\n");
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Legends Info");
            Console.WriteLine("2) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                LegendsInfoScreen();
                return true;
            }
            else if (result == "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void LegendsInfoScreen()
        {
            Console.Clear();

            LegendRepository repository = new LegendRepository();
            Legend[] legends = repository.GetAllLegends();
            
            Console.WriteLine("Character selection\n");
            for(int i = 0; i < legends.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {legends[i]}");
            }
            string result = Console.ReadLine();
        }
    }
}

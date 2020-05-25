using ApexMenu;
using System;
using System.Runtime.CompilerServices;

namespace Apex_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = menu.MainMenuScreen();
            }
        }
    }

}

using ConsoleMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenuSimple
{
    public class Program
    {
        public delegate void ItemAction();
        static void Main(string[] args)
        {
            Program monProg = new Program();
            monProg.AfficheMenu();
        }

        private void AfficheMenu()
        {
            Program prog = new Program();
            ItemAction itemAction = null;
            Menu monMenu = new Menu();
            MenuItem it1 = new MenuItem("H", "<H>ello", AfficheHello);
            monMenu.AddItem(it1);
            MenuItem it2 = new MenuItem("D", "<D>ate", AfficheDate);
            monMenu.AddItem(it2);
            MenuItem it3 = new MenuItem("E", "<E>xit", Exit);
            monMenu.AddItem(it3);
            Console.WriteLine("Bonjour");
            foreach (MenuItem it in monMenu.ListeMenuItems)
            {
                Console.WriteLine(it.Title);
            }
            //string res = monMenu.ListeMenuItems.Where(mi => mi.Identifier == "H").FirstOrDefault().Action;
            Console.ReadLine();

        }
        private void AfficheHello()
        {
            Console.WriteLine("Hello");
        }
        private void AfficheDate()
        {
            Console.WriteLine("Date: {0}", DateTime.Now);
        }
        
        private void Exit()
        {

        }

    }
}

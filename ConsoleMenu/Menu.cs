using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    public class Menu
    {
        private List<MenuItem> _listeMenuItems;

        public Menu()
        {
            ListeMenuItems = new List<MenuItem>();
        }

        public List<MenuItem> ListeMenuItems
        {
            get
            {
                return _listeMenuItems;
            }

            set
            {
                _listeMenuItems = value;
            }
        }
        public void AddItem(MenuItem item)
        {
            _listeMenuItems.Add(item);
        }
    }
}

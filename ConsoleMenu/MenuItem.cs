using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    public class MenuItem
    {
        private string _identifier;
        private string _title;
        private Action _action;

        public MenuItem(string identifier, string title, System.Action action)
        {
            Identifier = identifier;
            Title = title;
            Action = action;
        }
        public string Identifier
        {
            get
            {
                return _identifier;
            }

            set
            {
                _identifier = value;
            }
        }

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public Action Action
        {
            get
            {
                return _action;
            }

            set
            {
                _action = value;
            }
        }
    }
}

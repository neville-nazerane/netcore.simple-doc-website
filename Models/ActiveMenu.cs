using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Website.Models
{
    public class ActiveMenu
    {

        public string Current { get; set; }

        public ActiveMenu(string Current)
        {
            this.Current = Current;
        }

        public string this[string key]
        {
            get
            {
                return Current == key ? "active" : "";
            }
        }

    }
}

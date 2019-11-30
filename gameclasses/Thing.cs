using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    public class Thing
    {
        private string _name;
        private string _description;

        public Thing(string aName, string aDesction)
        {
            _name = aName;
            _description = aDesction;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }
    }
}

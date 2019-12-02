using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    public class Thing
    {
        public Thing(string aName, string aDesction)
        {
            Name = aName;
            Description = aDesction;
        }

        public string Name { get; set; }

        public string Description { get;  set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    class Actor : Thing
    {
        public Actor(string aName, string aDescription, Room aRoom) :
            base(aName, aDescription)
        {
            Location = aRoom;
        }

        public Room Location { get; set; }
    }
}

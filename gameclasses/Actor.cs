using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    class Actor : Thing
    {
        private Room _location;

        public Actor(string aName, string aDescription, Room aRoom) :
            base(aName, aDescription)
        {
            _location = aRoom;
        }

        public Room Location
        {
            get => _location;
            set => _location = value;
        }
    }
}

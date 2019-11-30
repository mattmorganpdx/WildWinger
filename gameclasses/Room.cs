using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    public class Room : Thing
    {
        private Rm _n;
        private Rm _s;
        private Rm _w;
        private Rm _e;
        
        public Room(string aName, string aDescription, Rm aN, Rm aS, Rm aW, Rm aE) :
            base(aName, aDescription)
        {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public Rm N
        {
            get => _n;
        }

        public Rm S
        {
            get => _s;
        }

        public Rm W
        {
            get => _w;
        }

        public Rm E
        {
            get => _e;
        }
    }
}

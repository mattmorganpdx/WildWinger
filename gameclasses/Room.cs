using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    public class Room : Thing
    {
        public Room(string aName, string aDescription, Rm aN, Rm aS, Rm aW, Rm aE) :
            base(aName, aDescription)
        {
            N = aN;
            S = aS;
            W = aW;
            E = aE;
        }

        public Rm N { get; }

        public Rm S { get; }

        public Rm W { get; }

        public Rm E { get; }
    }
}

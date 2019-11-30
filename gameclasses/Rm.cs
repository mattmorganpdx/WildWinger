using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    public enum Rm
    {
        /*
         *  room0 = new Room("Street", "A City Street", 3, -1, 1, 2);
            room1 = new Room("West Patio", "You can see the sunset from here. It's beautiful.", -1, -1, -1, 0);
            room2 = new Room("East Patio", "There are two pigeons fighting over a french fry. Gross!", -1, -1, 0, -1);
            room3 = new Room("Front Door", "An entry way to wing heaven. There's an ATM here", 5, 0, -1, -1);
            room4 = new Room("Men's Room", "Employees must wash hands.", -1, -1, -1, 5);
            room5 = new Room("Lobby", "There is a friendly Hostest waiting to seat you.", 7, 3, 4, 6);
            room6 = new Room("Dinning Room", "It's hella family friendly up in here.", -1, -1, 5, -1);
            room7 = new Room("Main Bar", "A room full of bar stools and beer taps A.K.A. heaven.", -1, 5, -1, -1);
            */

        Street,
        WestPatio,
        EastPatio,
        FrontDoor,
        MensRoom,
        Lobby,
        DinningRoom,
        MainBar,
        NOEXIT
    }
}

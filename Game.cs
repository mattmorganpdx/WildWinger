using System;
using WildWinger.gameclasses;

namespace WildWinger
{
    public class Game
    {
        private RoomList _map;
        private Actor _player;


        public void InitGame()
        {
            /*
            *                  Main Bar[7]
            *                     |
            *      Men's Room[4] - Lobby[5] - Dinning Room[6]
            *                     |    
            *                  Front Door[3]
            *                     |
            *     West Patio[1] - Street[0] - East Patio[2]                
            */

            _map = new RoomList
            {
                { Rm.Street, new Room("Street", "A City Street", Rm.FrontDoor, Rm.NOEXIT, Rm.WestPatio, Rm.EastPatio) },
                { Rm.WestPatio, new Room("West Patio", "You can see the sunset from here. It's beautiful.", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.Street) },
                { Rm.EastPatio, new Room("East Patio", "There are two pigeons fighting over a french fry. Gross!", Rm.NOEXIT, Rm.NOEXIT, Rm.Street, Rm.NOEXIT) },
                { Rm.FrontDoor, new Room("Front Door", "An entry way to wing heaven. There's an ATM here", Rm.Lobby, Rm.Street, Rm.NOEXIT, Rm.NOEXIT) },
                { Rm.MensRoom, new Room("Men's Room", "Employees must wash hands.", Rm.NOEXIT, Rm.NOEXIT, Rm.NOEXIT, Rm.Lobby) },
                { Rm.Lobby, new Room("Lobby", "There is a friendly Hostest waiting to seat you.", Rm.MainBar, Rm.FrontDoor, Rm.MensRoom, Rm.DinningRoom) },
                { Rm.DinningRoom, new Room("Dinning Room", "It's hella family friendly up in here.", Rm.NOEXIT, Rm.NOEXIT, Rm.Lobby, Rm.NOEXIT) },
                { Rm.MainBar, new Room("Main Bar", "A room full of bar stools and beer taps A.K.A. heaven.", Rm.NOEXIT, Rm.Lobby, Rm.NOEXIT, Rm.NOEXIT) }
            };

            _player = new Actor("Matt", "A man on a quest for buffalo wings", _map.RoomAt(Rm.Street));
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome To WildWinger!");
            Console.WriteLine($"You are in the {_player.Location.Name}.\n");
            Console.WriteLine("Enter a direction: N, S, E, W or L to Look");
        }

        public void MovePlayer(Rm newPosition)
        {
            if(newPosition == Rm.NOEXIT)
            {
                Console.WriteLine("You can't go that way from here.");
            } else
            {
                _player.Location = _map.RoomAt(newPosition);
                Console.WriteLine($"You are now in the {_player.Location.Name}");
            }
            return;
        }


        public void Loop()
        {
            var key = Console.ReadKey().Key.ToString();
            switch (key)
            {
                case "N":
                    MovePlayer(_player.Location.N);
                    break;
                case "S":
                    MovePlayer(_player.Location.S);
                    break;
                case "W":
                    MovePlayer(_player.Location.W);
                    break;
                case "E":
                    MovePlayer(_player.Location.E);
                    break;
                case "L":
                    Console.WriteLine(_player.Location.Description);
                    break;
                case "Q":
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid Key");
                    break;
            }
        }
    }
}
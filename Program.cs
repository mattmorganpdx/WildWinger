using System;
using WildWinger.gameclasses;

namespace WildWinger
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var game = new Game();
            game.InitGame();
            game.StartGame();
            while (true)
            {
                game.Loop();
            }
        }
    }
}

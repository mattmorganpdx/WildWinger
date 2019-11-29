﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildWinger.gameclasses;

namespace WildWinger
{
    public partial class Form1 : Form
    {
        Room room0;
        Room room1;
        Room room2;
        Room room3;
        Room room4;
        Room room5;
        Room room6;
        Room room7;

        Room[] map;

        Actor _player;

        public Form1()
        {
            InitializeComponent();
            InitGame();
            StartGame();
        }

        private void InitGame()
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

            room0 = new Room("Street", "A City Street", 3, -1, 1, 2);
            room1 = new Room("West Patio", "You can see the sunset from here. It's beautiful.", -1, -1, -1, 0);
            room2 = new Room("East Patio", "There are two pigeons fighting over a french fry. Gross!", -1, -1, 0, -1);
            room3 = new Room("Front Door", "An entry way to wing heaven. There's an ATM here", 5, 0, -1, -1);
            room4 = new Room("Men's Room", "Employees must wash hands.", -1, -1, -1, 5);
            room5 = new Room("Lobby", "There is a friendly Hostest waiting to seat you.", 7, 3, 4, 6);
            room6 = new Room("Dinning Room", "It's hella family friendly up in here.", -1, -1, 5, -1);
            room7 = new Room("Main Bar", "A room full of bar stools and beer taps A.K.A. heaven.", -1, 5, -1, -1);
            

            map = new Room[8];
            map[0] = room0;
            map[1] = room1;
            map[2] = room2;
            map[3] = room3;
            map[4] = room4;
            map[5] = room5;
            map[6] = room6;
            map[7] = room7;

            _player = new Actor("Matt", "A man on a quest for buffalo wings", room0);
        }

        private void StartGame()
        {
            outputTB.Text = "Welcome To WildWinger!\n";
            outputTB.AppendText($"You are in the {_player.Location.Name}.\n");
            outputTB.AppendText("Click a direction: N, S, E, W");
        }

        private void MovePlayer(int newpos)
        {
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            foreach (var item in map)
            {
                if(item != null) outputTB.AppendText(Exits(map, item));
            }
            
        }
        public string Exits(Room[] map, Room r)
        {
            return $"You are in the {r.Name}\n";
        }

    }
}

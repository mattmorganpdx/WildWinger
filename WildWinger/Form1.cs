using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WildWinger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

            Room room0 = new Room();
            Room room1 = new Room();
            Room room2 = new Room();
            Room room3 = new Room();
            Room room4 = new Room();
            Room room5 = new Room();
            Room room6 = new Room();
            Room room7 = new Room();
            Room room8 = new Room();

            Room[] map = new Room[9];
            map[0] = room0;
            map[1] = room1;
            map[2] = room2;
            map[3] = room3;
            map[4] = room4;
            map[5] = room5;
            map[6] = room6;
            map[7] = room7;
            map[8] = room8;
             
            room0.name = "Street";
            room0.n = 3;
            room0.s = -1;
            room0.w = 1;
            room0.e = 2;

            room1.name = "West Patio";
            room1.n = -1;
            room1.s = -1;
            room1.w = -1;
            room1.e = 0;

            room2.name = "East Patio";
            room2.n = -1;
            room2.s = -1;
            room2.w = 0;
            room2.e = -1;

            room3.name = "Front Door";
            room3.n = 5;
            room3.s = 0;
            room3.w = -1;
            room3.e = -1;

            room4.name = "Men's Room";
            room4.n = -1;
            room4.s = -1;
            room4.w = -1;
            room4.e = 5;

            room5.name = "Lobby";
            room5.n = 7;
            room5.s = 3;
            room5.w = 4;
            room5.e = 6;

            room6.name = "Dinning Room";
            room6.n = -1;
            room6.s = -1;
            room6.w = 5;
            room6.e = -1;

            room7.name = "Main Bar";
            room7.n = -1;
            room7.s = 5;
            room7.w = -1;
            room7.e = -1;



            outputTB.Text = "Welcome To WildWinger!\n";
            foreach (var item in map)
            {
                outputTB.AppendText(Exits(map, item));
            }
            
        }
        public string Exits(Room[] map, Room r)
        {
            return $"Your are in the {r.name}, There are exits to: N={map[r.n].name} S={map[r.s].name} W={map[r.w].name} E={map[r.e].name}\n";
        }
    }
}

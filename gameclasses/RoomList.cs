using System;
using System.Collections.Generic;
using System.Text;

namespace WildWinger.gameclasses
{
    public class RoomList : Dictionary<Rm, Room>
    {
        public RoomList() { }

        public Room RoomAt(Rm id)
        {
            return this[id];
        }

        public string Describe()
        {
            string s = "";
            if(this.Count == 0)
            {
                s = "Nothing in the RoomList.";
            } else
            {
                foreach (KeyValuePair<Rm, Room> kv in this)
                {
                    s = s + kv.Value.Description + "\r\n";
                }
            }
            return s;
        }
    }
}

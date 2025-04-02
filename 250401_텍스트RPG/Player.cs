using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _250401_텍스트RPG
{
    public class Player
    {
        private int power;
        public int Power { get { return power; } set { power = value; } }

        private int speed;
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private int level;
        public int Level { get { return level; } set { level = value; } }
    }
}

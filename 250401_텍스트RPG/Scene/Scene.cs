using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250401_텍스트RPG
{
    public abstract class Scene1
    {
        protected ConsoleKey input;
        public abstract void Render(); 
        public abstract void Choice();
        public void Input()
        {
            input = Console.ReadKey(true).Key;
        }
        public abstract void Result(); 
        public abstract void Wait(); 
        public abstract void Next(); 

        

    }
}

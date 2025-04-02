﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _250401_텍스트RPG
{
    class TitleScene : Scene1
    {
        public override void Render()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("*    레전드 RPG     *");
            Console.WriteLine("*********************");
            Console.WriteLine();
        }
        public override void Result()
        {
            
        }
        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현");
            Console.WriteLine("3. 게임종료");
        }
        public override void Wait()
        {
            
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}

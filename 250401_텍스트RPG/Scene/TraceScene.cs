using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250401_텍스트RPG.Scene
{
    class TraceScene : Scene1
    {
        public override void Render()
        {
            Console.WriteLine("남자가 도망치는 중에 바위에 발이 걸려 넘어집니다...");
            Console.WriteLine("몇 차례 땅바닥을 구른 남자가 주변을 둘러보더니 근처에 있는 돌을 움켜쥐고 당신을 쳐다봅니다.");
            Console.WriteLine("어떻게 하시겠습니까?");
        }

        public override void Choice()
        {
            Console.WriteLine("1. 그대로 달려가 명치를 걷어찬다.");
            Console.WriteLine("2. 도망간다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Player.Speed >= 12 && Game.Player.Power >= 10)
                    {
                        Console.WriteLine("남자는 당신에게 명치를 맞고 쓰러졌습니다.");
                    }
                    else
                    {
                        Console.WriteLine("남자가 당신의 공격을 회피하고 돌로 머리를 내려쳤습니다.");
                        Console.WriteLine("정신이 흐려집니다.");
                    }
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 남자에게 위협을 느꼈고 돌아가기로 결정했습니다.");
                    Console.WriteLine("마을로 도망쳤습니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("아무키나 누르시오.");
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    // TODO : 남자를 수색해 지도를 찾음 구현
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Town");
                    break;
            }
        }
    }
}

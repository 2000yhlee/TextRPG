using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250401_텍스트RPG.Scene
{
    class ShopScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("\"어서오세요~\"");
            Console.WriteLine("상점에 오신걸 환영합니다~");
            Console.WriteLine("무엇이 필요하신가요?");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 누가봐도 수상한 구슬을 산다.");
            Console.WriteLine("");
        }
        public override void Result()
        {

        }
        public override void Wait()
        {

        }
        public override void Next()
        {

        }
    }
}

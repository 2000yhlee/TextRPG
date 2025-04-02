using _250401_텍스트RPG.Scene;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250401_텍스트RPG
{
    public static class Game
    {
        //게임에 필요한 정보들
        private static bool gameOver;
        
        private static Dictionary<string, Scene1> sceneDic;
        private static Scene1 curScene;

        private static Player player;
        public static Player Player { get { return player; } }

        //1. 상황들

        //게임에 필요한 기능들
        //1. 게임시작
        public static void Start()
        {
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene1>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());
            sceneDic.Add("Shop", new ShopScene());
            sceneDic.Add()

            // 처음시작할 씬을 선정
            curScene = sceneDic["Title"];

            player = new Player();
            player.Power = 10;
            player.Speed = 8;
            player.Level = 1;
        }

        //2. 게임종료
        public static void End()
        {

        }

        //3. 게임동작
        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();

                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();

            }
        }

        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void Gameover(string reason)
        {
            Console.Clear();
            Console.WriteLine("************************");
            Console.WriteLine("*    사망하셨습니다    *");
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }

        public static void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("플레이어");
            Console.WriteLine(" 힘 : {0}\t 속도 : {1}", player.Power, player.Speed);
            Console.WriteLine();
        }
    }
}

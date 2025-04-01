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
        
        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        //1. 상황들

        //게임에 필요한 기능들
        //1. 게임시작
        public static void Start()
        {
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자룍구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Town", new TownScene());

            // 처음시작할 씬을 선정
            curScene = sceneDic["Title"];
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
    }
}

using Aimtec;
using Aimtec.SDK.Events;
using Berts_Base.Managers;
using System;

namespace Berts_Base
{
    class Program
    {
#warning Need to update champ name
        private static string CHAMPIONNAME = String.Empty;

        static void Main(string[] args)
        {
            GameEvents.GameStart += GameEvents_GameStart;
        }

        private static void GameEvents_GameStart()
        {
            if (ObjectManager.GetLocalPlayer().ChampionName != CHAMPIONNAME)
            {
                Console.WriteLine("Did not detect supported champion so unloading - " + CHAMPIONNAME);
                return;
            }

            Console.WriteLine("Loading - " + CHAMPIONNAME);
            SetUp();
        }

        private static void SetUp()
        {
            new Champion.Champion(new GameObjectManager());
        }
    }
}

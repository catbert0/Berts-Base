using Aimtec;
using Berts_Base.Managers;
using Berts_Base.Utility;
using System;

namespace Berts_Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Obj_AI_Hero champion = ObjectManager.GetLocalPlayer();

            if (champion.ChampionName != Constants.Champion.)
            {
                Console.WriteLine("Did not detect supported champion so unloading - " + Constants.Champion.);

                return;
            }

            Console.WriteLine("Loading - " + champion.ChampionName);
            SetUp(champion);
        }

        private static void SetUp(Obj_AI_Hero champion)
        {
            GameObjectManager gamePlay = new GameObjectManager();

            Object[] args = { gamePlay };
            Type t = Type.GetType("Berts_Base.Champion.Ezreal");

            Activator.CreateInstance(t, args);
        }
    }
}

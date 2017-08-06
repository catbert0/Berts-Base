using Aimtec;
using Aimtec.SDK.Events;
using Berts_Base.SetupHelpers;
using System;

namespace Berts_Base
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Assembly Entrance
    /// </summary>
    class Program
    {
        private static string ChampionName = Properties.Setup.Default.ChampionName;

        /// <summary>
        /// Initialises the GameStart event
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GameEvents.GameStart += GameEvents_GameStart;
        }

        /// <summary>
        /// Exits or creates the Assembly depending on if the user is
        /// playing the supported champion
        /// </summary>
        private static void GameEvents_GameStart()
        {
            if (ObjectManager.GetLocalPlayer().ChampionName != ChampionName)
            {
                return;
            }
            InitLogFile();
            SimpleLog.Info("Loading + " + ChampionName);
            SetUp();
        }

        /// <summary>
        /// Initialises the Assembly and associated objects
        /// </summary>
        private static void SetUp()
        {
            new Champion.Champion(new GameObjectManager());
        }

        /// <summary>
        /// Sets an enviroment location to store Assembly Log Files
        /// </summary>
        private static void InitLogFile()
        {
            try
            {
                SimpleLog.SetLogFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Constants.General.NameSpace + "\\" + ChampionName);
            }
            catch
            {
                Console.WriteLine("Unable to create log file");
            }
        }
    }
}

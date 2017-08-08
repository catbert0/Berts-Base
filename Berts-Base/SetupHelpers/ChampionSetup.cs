using Aimtec;
using Berts_Base.Champion.AssemblyMenu;
using Berts_Base.Champion.ComboLogic.Builds;

namespace Berts_Base.SetupHelpers
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Base class for Champion
    /// </summary>
    abstract class ChampionSetup
    {
        protected Build _currentBuild { set; get; }

        protected MenuManager _menu;
        protected ChampionMenu _championMenu = new ChampionMenu();
        protected GameObjectManager _gamePlay;
    
        //Refrences to specific Build logic
        private AD_Mode _adMode = null;
        private AP_Mode _apMode = null;
        private General_Mode _generalMode = null;
        private Support_Mode _supportMode = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChampionSetup"/> class.
        /// </summary>
        /// <param name="gamePlay">The game play.</param>
        public ChampionSetup(GameObjectManager gamePlay)
        {
            SimpleLog.Info("Initialising Champion " + _currentBuild);
            _gamePlay = gamePlay;
            _menu = gamePlay._menu;
            _championMenu.PopulateSupportedBuilds(_menu);
            _currentBuild = _championMenu.GetBuildSettings(_menu);
            SetupNewBuild(_currentBuild);
            Game.OnUpdate += Game_OnUpdate;
            SimpleLog.Info("Champion Initialised " + _currentBuild);
        }

        /// <summary>
        /// Gets the orb walker mode logic.
        /// </summary>
        protected void PerformAssemblyLogic()
        {
            switch (_currentBuild)
            {
                case Build.AD_Mode:
                    {
                        _adMode.PerformAssemblyLogic();
                    }
                    break;

                case Build.AP_Mode:
                    {
                        _apMode.PerformAssemblyLogic();
                    }
                    break;

                case Build.General_Mode:
                    {
                        _generalMode.PerformAssemblyLogic();
                    }
                    break;

                case Build.Support_Mode:
                    {
                        _supportMode.PerformAssemblyLogic();
                    }
                    break;

                default:
                    SimpleLog.Error("Mode was not detected in PerformAssemblyLogic()");
                    break;
            }
        }

        /// <summary>
        /// We only create the logic objects when they are loaded in the menu
        /// so that we do not have multiple calls to events e.g. OnCastSpell
        /// in AD_Mode and Support mode as this would potentially cause performance
        /// issues, especially as we only need the logic from the selected build.
        /// </summary>
        /// <param name="newSelectedBuild">The new selected build.</param>
        /// <param name="deletingOldBuild">if set to <c>true</c> [deleting old build].</param>
        protected void SetupNewBuild(Build newSelectedBuild, bool deletingOldBuild = false)
        {
            if (deletingOldBuild)
                CleanUpOldBuild();

            switch (newSelectedBuild)
            {
                case Build.AD_Mode:
                    {
                        SimpleLog.Info("Creating ADMode Logic");
                        _adMode = new AD_Mode(_gamePlay);
                    }
                    break;

                case Build.AP_Mode:
                    {
                        SimpleLog.Info("Creating APMode Logic");
                        _apMode = new AP_Mode(_gamePlay);
                    }
                    break;

                case Build.General_Mode:
                    {
                        SimpleLog.Info("Creating GeneralMode Logic");
                        _generalMode = new General_Mode(_gamePlay);
                    }
                    break;

                case Build.Support_Mode:
                    {
                        SimpleLog.Info("Creating SupportMode Logic");
                        _supportMode = new Support_Mode(_gamePlay);
                    }
                    break;

                default:
                    SimpleLog.Error("Unsupported build in SetupNewBuild");
                    break;
            }
        }

        /// <summary>
        /// Cleans up old build.
        /// </summary>
        private void CleanUpOldBuild()
        {
            if (_adMode != null)
            {
                _adMode.Dispose();
                return;
            }

            if (_apMode != null)
            {
                _apMode.Dispose();
                return;
            }

            if (_generalMode != null)
            {
                _generalMode.Dispose();
                return;
            }

            if (_supportMode != null)
            {
                _supportMode.Dispose();
                return;
            }
        }

        /// <summary>
        /// Event is fired on every game update
        /// </summary>
        public abstract void Game_OnUpdate();
    }
}

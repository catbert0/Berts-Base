using Berts_Base.Champion.AssemblyMenu;
using Berts_Base.SetupHelpers;

namespace Berts_Base.Champion
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Main class for Champions - All basic actions should be performed in here
    /// and anything specific to a build should be put into the build class
    /// </summary>
    /// <seealso cref="Berts_Base.SetupHelpers.ChampionSetup" />
    class Champion : ChampionSetup
    {
        private ChampionMenu _championMenu = new ChampionMenu();

        bool _manaManagerOff = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Champion"/> class.
        /// </summary>
        /// <param name="gamePlay">The game play.</param>
        public Champion(GameObjectManager gamePlay) : base(gamePlay)
        {
            SimpleLog.Info("Initialising Champion " + _currentBuild);
            _championMenu.PopulateSupportedBuilds(_menu);
            _currentBuild = _championMenu.GetBuildSettings(_menu);
            SetupNewBuild(_currentBuild);
            SimpleLog.Info("Champion Initialised " + _currentBuild);
        }

        /// <summary>
        /// Event is fired on every game update
        /// </summary>
        public override void Game_OnUpdate()
        {
            //Always prioritise autosmite

            CheckForMenuRefresh();

            //if (!CanCastSpells())
              // return;

            PerformAssemblyLogic();

#warning Need to implement disable AA in combo

#warning Need to implement disabling lasthitting (Support mode)
        }

        /// <summary>
        /// Refreshes the menu if the user changes build in the menu
        /// </summary>
        private void CheckForMenuRefresh()
        {
            if (_championMenu._needsRefresh)
            {
                try
                {
                    SimpleLog.Info("Refreshing Menu" + _currentBuild);
                    MenuHelper.SimulateKeyPress(Constants.General.ShiftSimulateKey);
                    _championMenu.PopulateSupportedBuilds(_menu);
                    _currentBuild = _championMenu.GetBuildSettings(_menu);
                    SetupNewBuild(_currentBuild, true);
                    SimpleLog.Info("MenuRefreshed");
                }
                catch
                {
                    SimpleLog.Error("Failed to transition Builds in CheckForMenuRefresh()");
                }
            }
        }
    }
}

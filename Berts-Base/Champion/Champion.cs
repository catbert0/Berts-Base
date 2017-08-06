using Berts_Base.SetupHelpers;
using Berts_Base.Champion.Menu;

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
            _championMenu.PopulateSupportedBuilds(ref _menu);
            _currentBuild = _championMenu.GetBuildSettings(ref _menu);
            SetupNewBuild(_currentBuild);
            SimpleLog.Info("Champion Initialised " + _currentBuild);
        }

        /// <summary>
        /// Event is fired on every game update
        /// </summary>
        public override void Game_OnUpdate()
        {
            CheckForMenuRefresh();

            if (!CastSpells())
                return;

            GetOrbWalkerModeLogic();

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
                    _championMenu.PopulateSupportedBuilds(ref _menu);
                    _currentBuild = _championMenu.GetBuildSettings(ref _menu);
                    SetupNewBuild(_currentBuild, true);
                    SimpleLog.Info("MenuRefreshed");
                }
                catch
                {
                    SimpleLog.Error("Failed to transition Builds in CheckForMenuRefresh()");
                }
            }
        }

        /// <summary>
        /// Controller to not cast spells until a certain specified level from the menu
        /// </summary>
        /// <returns></returns>
        private bool CastSpells()
        {
            if (!SpellLogicHelper.ShouldCastSpells(_champion.Level, _menu))
            {
                //User has selected to block spell casts until a level so we just orbwalk until the level has been reached
                return false;
            }

            return true;
        }

        /// <summary>
        /// Controller to ignore manamanager if player has blue buff
        /// </summary>
        /// <returns></returns>
        private void IgnoreManaManager()
        {
            if (SpellLogicHelper.IgnoreManaManager(_menu) && _champion.BuffManager.HasBuff(Constants.BuffNames.BlueBuff))
            {
                _manaManagerOff = true;
            }

            _manaManagerOff = false;
        }
    }
}

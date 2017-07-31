using Berts_Base.Managers;
using Berts_Base.Champion.Menu;

namespace Berts_Base.Champion
{
    class Champion : ChampionSetup
    {
        ChampionMenu _championMenu = new ChampionMenu();

        public Champion(GameObjectManager gamePlay) : base(gamePlay)
        {
            _championMenu.PopulateBuilds(ref _menu);
            _championMenu.GetBuildSettings(ref _menu);
        }

        public override void Game_OnUpdate()
        {
            CheckForMenuRefresh();

            if (!CastSpells())
                return;

#warning Need to implement manamanager override

#warning Need to implement disable AA in combo

#warning Need to implement disabling lasthitting (Support mode)


        }

        /// <summary>
        /// Refreshes the menu if user changed build
        /// </summary>
        private void CheckForMenuRefresh()
        {
            if (ChampionMenu._needsRefresh)
            {
                //Populates supported builds
                _championMenu.PopulateBuilds(ref _menu);
                //Populates build settings
                _championMenu.GetBuildSettings(ref _menu);
                ChampionMenu._needsRefresh = false;
            }
        }

        /// <summary>
        /// Controller to not cast spells until a certain
        /// specified level
        /// </summary>
        /// <returns></returns>
        private bool CastSpells()
        {
            if (!_spellLogic.ShouldCastSpells(_champion.Level, _menu))
            {
                //User has selected to block spell casts until a level so we just orbwalk until the level has been reached
                return false;
            }

            return true;
        }
    }
}

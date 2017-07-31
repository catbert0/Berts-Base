using System;
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
        }

        public override void Game_OnUpdate()
        {
            //_championMenu.populateBuilds(ref menu);
            _championMenu.GetBuildSettings(ref _menu);

            throw new NotImplementedException();
        }
    }
}

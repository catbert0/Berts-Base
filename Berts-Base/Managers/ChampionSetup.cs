using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;
using Berts_Base.Utility.Helpers;

namespace Berts_Base.Managers
{
    abstract class ChampionSetup
    {
        public IHealthPrediction _healthPredition { private set; get; }
        public IOrbwalker _orbWalker { private set; get; }
        public ITargetSelector _targetSelector { private set; get; }
        public MenuManager _menu;
        public Obj_AI_Hero _champion { private set; get; }
        public SpellLogic _spellLogic { private set; get; }

        public ChampionSetup(GameObjectManager gamePlay)
        {
            this._menu = gamePlay.GetMenuManager();
            this._champion = gamePlay.GetChampion();
            _healthPredition = gamePlay.GetHealthPredition();
            _orbWalker = gamePlay.GetOrbWalker();
            _targetSelector = gamePlay.GetTargetSelector();
            _spellLogic = new SpellLogic();
            Game.OnUpdate += Game_OnUpdate;
        }

        abstract public void Game_OnUpdate();
    }
}

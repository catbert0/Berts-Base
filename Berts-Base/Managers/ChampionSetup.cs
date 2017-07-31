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
            this._menu = gamePlay._menu;
            this._champion = gamePlay._champion;
            _healthPredition = gamePlay._healthPredition;
            _orbWalker = gamePlay._orbWalker;
            _targetSelector = gamePlay._targetSelector;
            _spellLogic = new SpellLogic();
            Game.OnUpdate += Game_OnUpdate;
        }

        abstract public void Game_OnUpdate();
    }
}

using System;
using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;
using Berts_Base.Utility.Helpers;
using Aimtec.SDK.Events;

namespace Berts_Base.Managers
{
    abstract class ChampionSetup
    {
        public IHealthPrediction _healthPredition { private set; get; }
        public IOrbwalker _orbWalker { private set; get; }
        public ITargetSelector _targetSelector { private set; get; }
        public MenuManager _menu;
        public Obj_AI_Hero _champion { private set; get; }
        public SpellLogicHelper _spellLogic { private set; get; }

        public ChampionSetup(GameObjectManager gamePlay)
        {
            Game.OnUpdate += Game_OnUpdate;
            _menu = gamePlay._menu;
            _champion = gamePlay._champion;
            _healthPredition = gamePlay._healthPredition;
            _orbWalker = gamePlay._orbWalker;
            _targetSelector = gamePlay._targetSelector;
            _spellLogic = new SpellLogicHelper();
        }

        public abstract void Game_OnUpdate();
    }
}

using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;
using Berts_Base.Utility;

namespace Berts_Base.Managers
{
    class GameObjectManager
    {
        public Obj_AI_Hero _champion { private set; get; }
        public MenuManager _menu { private set; get; }
        public IHealthPrediction _healthPredition { private set; get; }
        public IOrbwalker _orbWalker { private set; get; }
        public ITargetSelector _targetSelector { private set; get; }

        public GameObjectManager()
        {
            _champion = ObjectManager.GetLocalPlayer();
            _healthPredition = HealthPrediction.Implementation;
            _targetSelector = TargetSelector.Implementation;
            _orbWalker = Orbwalker.Implementation;
            _menu = new MenuManager(_orbWalker, _champion.ChampionName.ToLower(), Constants.General.ProjectName + _champion.ChampionName);
        }
    }
}

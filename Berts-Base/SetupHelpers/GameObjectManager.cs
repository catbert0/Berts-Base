using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;

namespace Berts_Base.SetupHelpers
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Creates instances of objects to be used throughout the
    /// assemblies lifecycle and initialises the menu
    /// </summary>
    class GameObjectManager
    {
        public Obj_AI_Hero _champion { private set; get; }
        public MenuManager _menu { private set; get; }
        public IHealthPrediction _healthPredition { private set; get; }
        public IOrbwalker _orbWalker { private set; get; }
        public ITargetSelector _targetSelector { private set; get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GameObjectManager"/> class.
        /// </summary>
        public GameObjectManager()
        {
            SimpleLog.Info("Initialising GameObjectManager");
            _champion = ObjectManager.GetLocalPlayer();
            _healthPredition = HealthPrediction.Implementation;
            _targetSelector = TargetSelector.Implementation;
            _orbWalker = Orbwalker.Implementation;
            _menu = new MenuManager(_orbWalker, _champion.ChampionName.ToLower(), Constants.General.ProjectName + _champion.ChampionName);
            SimpleLog.Info("GameObjectManager Initialised");
        }
    }
}

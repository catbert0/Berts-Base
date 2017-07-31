using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;
using Berts_Base.Utility;

namespace Berts_Base.Managers
{
    class GameObjectManager
    {
        private Obj_AI_Hero champion;
        private MenuManager menu;
        private IHealthPrediction healthPredition;
        private IOrbwalker orbWalker;
        private ITargetSelector targetSelector;

        public GameObjectManager()
        {
            champion = ObjectManager.GetLocalPlayer();
            healthPredition = HealthPrediction.Implementation;
            orbWalker = Orbwalker.Implementation;
            targetSelector = TargetSelector.Implementation;
            menu = new MenuManager(orbWalker, champion.ChampionName, Constants.General.ProjectName + champion.ChampionName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IHealthPrediction GetHealthPredition()
        {
            return healthPredition;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IOrbwalker GetOrbWalker()
        {
            return orbWalker;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ITargetSelector GetTargetSelector()
        {
            return targetSelector;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Obj_AI_Hero GetChampion()
        {
            return champion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public MenuManager GetMenuManager()
        {
            return menu;
        }
    }
}

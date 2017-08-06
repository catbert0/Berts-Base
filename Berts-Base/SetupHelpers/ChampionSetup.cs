using Aimtec;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.Prediction.Health;
using Aimtec.SDK.TargetSelector;
using Berts_Base.Champion.ComboLogic.Builds;

namespace Berts_Base.SetupHelpers
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Base class for Champion
    /// </summary>
    abstract class ChampionSetup
    {
        public IHealthPrediction _healthPredition { private set; get; }
        public ITargetSelector _targetSelector { private set; get; }
        public Obj_AI_Hero _champion { private set; get; }
        protected Build _currentBuild { set; get; }

        //Passed by refrence
        public IOrbwalker _orbWalker;
        public MenuManager _menu;

        //Refrences to specific Build logic
        AD_Mode _adMode = null;
        AP_Mode _apMode = null;
        General_Mode _generalMode = null;
        Support_Mode _supportMode = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChampionSetup"/> class.
        /// </summary>
        /// <param name="gamePlay">The game play.</param>
        public ChampionSetup(GameObjectManager gamePlay)
        {
            Game.OnUpdate += Game_OnUpdate;
            _menu = gamePlay._menu;
            _champion = gamePlay._champion;
            _healthPredition = gamePlay._healthPredition;
            _orbWalker = gamePlay._orbWalker;
            _targetSelector = gamePlay._targetSelector;
        }

        /// <summary>
        /// Gets the orb walker mode logic.
        /// </summary>
        protected void GetOrbWalkerModeLogic()
        {
            switch (_currentBuild)
            {
                case Build.AD_Mode:
                    {
                        _adMode.PerformObwalkingMode(_orbWalker.Mode);
                    }
                    break;

                case Build.AP_Mode:
                    {
                        _apMode.PerformObwalkingMode(_orbWalker.Mode);
                    }
                    break;

                case Build.General_Mode:
                    {
                        _generalMode.PerformObwalkingMode(_orbWalker.Mode);
                    }
                    break;

                case Build.Support_Mode:
                    {
                        _supportMode.PerformObwalkingMode(_orbWalker.Mode);
                    }
                    break;

                default:
                    SimpleLog.Error("Mode was not detected in GetOrbWalkerModeLogic()");
                    break;
            }
        }

        /// <summary>
        /// We only create the logic objects when they are loaded in the menu
        /// so that we do not have multiple calls to events e.g. OnCastSpell
        /// in AD_Mode and Support mode as this would potentially cause performance
        /// issues, especially as we only need the logic from the selected build.
        /// </summary>
        /// <param name="newSelectedBuild">The new selected build.</param>
        /// <param name="deletingOldBuild">if set to <c>true</c> [deleting old build].</param>
        protected void SetupNewBuild(Build newSelectedBuild, bool deletingOldBuild = false)
        {
            if (deletingOldBuild)
                CleanUpOldBuild();

            switch (newSelectedBuild)
            {
                case Build.AD_Mode:
                    {
                        SimpleLog.Info("Creating ADMode Logic");
                        _adMode = new AD_Mode(ref _orbWalker);
                    }
                    break;

                case Build.AP_Mode:
                    {
                        SimpleLog.Info("Creating APMode Logic");
                        _apMode = new AP_Mode(ref _orbWalker);
                    }
                    break;

                case Build.General_Mode:
                    {
                        SimpleLog.Info("Creating GeneralMode Logic");
                        _generalMode = new General_Mode(ref _orbWalker);
                    }
                    break;

                case Build.Support_Mode:
                    {
                        SimpleLog.Info("Creating SupportMode Logic");
                        _supportMode = new Support_Mode(ref _orbWalker);
                    }
                    break;

                default:
                    SimpleLog.Error("Unsupported build in SetupNewBuild");
                    break;
            }
        }

        /// <summary>
        /// Cleans up old build.
        /// </summary>
        private void CleanUpOldBuild()
        {
            if (_adMode != null)
            {
                _adMode.Dispose();
                return;
            }

            if (_apMode != null)
            {
                _apMode.Dispose();
                return;
            }

            if (_generalMode != null)
            {
                _generalMode.Dispose();
                return;
            }

            if (_supportMode != null)
            {
                _supportMode.Dispose();
                return;
            }
        }

        /// <summary>
        /// Event is fired on every game update
        /// </summary>
        public abstract void Game_OnUpdate();
    }
}

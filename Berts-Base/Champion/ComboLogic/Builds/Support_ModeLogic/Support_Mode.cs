using Aimtec.SDK.Orbwalking;
using Berts_Base.Champion.ComboLogic.Builds.Support_ModeLogic.ChampionLogic;
using Berts_Base.SetupHelpers;

namespace Berts_Base.Champion.ComboLogic.Builds
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Contains specific logic for SupportMode
    /// </summary>
    /// <seealso cref="Berts_Base.Champion.ComboLogic.Builds.ChampionBuildBase" />
    class Support_Mode : ChampionBuildBase
    {
        private SupportModeOrbLogic _orbwalkerModeLogic;
        private SupportModeEventLogic _supportModeEventLogic;
        private SupportModeWeavingLogic _supportModeWeavingLogic;

        private OrbwalkingMode _lastOrbwalkingMode;

        /// <summary>
        /// Initializes a new instance of the <see cref="Support_Mode"/> class.
        /// </summary>
        /// <param name="orbwalker">The orbwalker.</param>
        public Support_Mode(GameObjectManager gameeObjectManager) : base(gameeObjectManager)
        {
            _orbwalkerModeLogic = new SupportModeOrbLogic();
            _supportModeEventLogic = new SupportModeEventLogic();
            _supportModeWeavingLogic = new SupportModeWeavingLogic();
        }

        /// <summary>
        /// Performs the obwalking mode.
        /// </summary>
        /// <param name="orbWalkingMode">The orb walking mode.</param>
        /// 
        #warning bring champion spells into this class and perform all actions here 
        public override void PerformAssemblyLogic()
        {
#warning AutoSmite here

            switch (_orbwalker.Mode)
            {
                case OrbwalkingMode.Combo:
                    {
                        _orbwalkerModeLogic.Combo(_champion);
                    }
                    break;

                case OrbwalkingMode.Mixed:
                    {
                        _orbwalkerModeLogic.Harass(_champion);
                    }
                    break;

                case OrbwalkingMode.Lasthit:
                    {
                        _orbwalkerModeLogic.LastHit(_champion);
                    }
                    break;

                case OrbwalkingMode.Laneclear:
                    {
                        _orbwalkerModeLogic.LaneClear(_champion);
                    }
                    break;

                case OrbwalkingMode.None:
                    {
#warning need to add auto harass
                    }
                    break;

                default:
                    break;
            }
        }

#warning example
        protected override void OnPostAttack(object sender, PostAttackEventArgs e)
        {
            return;
        }

    }
}

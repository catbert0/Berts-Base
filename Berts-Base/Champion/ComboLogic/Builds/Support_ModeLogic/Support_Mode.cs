using Aimtec.SDK.Orbwalking;
using Berts_Base.Champion.ComboLogic.Builds.Support_ModeLogic.ChampionLogic;

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
        SupportModeOrbLogic _orbwalkerModeLogic = new SupportModeOrbLogic();

        /// <summary>
        /// Initializes a new instance of the <see cref="Support_Mode"/> class.
        /// </summary>
        /// <param name="orbwalker">The orbwalker.</param>
        public Support_Mode(ref IOrbwalker orbwalker) : base(ref orbwalker)
        {
        }

        /// <summary>
        /// Performs the obwalking mode.
        /// </summary>
        /// <param name="orbWalkingMode">The orb walking mode.</param>
        public override void PerformObwalkingMode(OrbwalkingMode orbWalkingMode)
        {
            switch (orbWalkingMode)
            {
                case OrbwalkingMode.Combo:
                    {
                        _orbwalkerModeLogic.Combo();
                    }
                    break;

                case OrbwalkingMode.Mixed:
                    {
                        _orbwalkerModeLogic.Harass();
                    }
                    break;

                case OrbwalkingMode.Lasthit:
                    {
                        _orbwalkerModeLogic.LastHit();
                    }
                    break;

                case OrbwalkingMode.Laneclear:
                    {
                        _orbwalkerModeLogic.LaneClear();
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
    }
}

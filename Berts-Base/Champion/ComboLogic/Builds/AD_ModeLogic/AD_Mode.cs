using System;
using Aimtec.SDK.Orbwalking;
using Berts_Base.Champion.ComboLogic.Builds.AD_ModeLogic.ChampionLogic;

namespace Berts_Base.Champion.ComboLogic.Builds
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Contains specific logic for ADMode
    /// </summary>
    /// <seealso cref="Berts_Base.Champion.ComboLogic.Builds.ChampionBuildBase" />
    class AD_Mode : ChampionBuildBase
    {
        ADModeOrbLogic _orbwalkerModeLogic = new ADModeOrbLogic();

        /// <summary>
        /// Initializes a new instance of the <see cref="AD_Mode"/> class.
        /// </summary>
        /// <param name="orbwalker">The orbwalker.</param>
        public AD_Mode(ref IOrbwalker orbwalker) : base(ref orbwalker)
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
                        Console.WriteLine("Combo");
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
                        Console.WriteLine("LaneCleat");
                        _orbwalkerModeLogic.LastHit();
                    }
                    break;

                case OrbwalkingMode.Laneclear:
                    {
                        Console.WriteLine("LaneCleat");
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

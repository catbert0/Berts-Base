using System;
using Aimtec.SDK.Orbwalking;
using Berts_Base.Champion.ComboLogic.Builds.AD_ModeLogic.ChampionLogic;
using Aimtec;
using Berts_Base.Champion.Spells;
using Berts_Base.SetupHelpers;

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
        public AD_Mode(GameObjectManager gameObjectManager) : base(gameObjectManager)
        {
            
        }

        /// <summary>
        /// Performs the obwalking mode.
        /// </summary>
        /// <param name="orbWalkingMode">The orb walking mode.</param>
        public override void PerformAssemblyLogic()
        {
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
    }
}

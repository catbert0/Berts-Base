using Aimtec;

namespace Berts_Base.Champion.ComboLogic.Builds.Shared
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Base class for different automation logic
    /// </summary>
    abstract class OrbwalkingModes
    {
        /// <summary>
        /// Performs the Combo Logic
        /// </summary>
        public abstract void Combo(Obj_AI_Hero champion);

        /// <summary>
        /// Performs the Harass Logic
        /// </summary>
        public abstract void Harass(Obj_AI_Hero champion);

        /// <summary>
        /// Performs the AutoHarass Logic
        /// </summary>
        public abstract void AutoHarass(Obj_AI_Hero champion);

        /// <summary>
        /// Performs the LaneClear Logic
        /// </summary>
        public abstract void LaneClear(Obj_AI_Hero champion);

        /// <summary>
        /// Performs the LastHit logic
        /// </summary>
        public abstract void LastHit(Obj_AI_Hero champion);
    }
}

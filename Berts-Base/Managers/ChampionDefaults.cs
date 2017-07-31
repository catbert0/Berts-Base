using Berts_Base.Utility;

namespace Berts_Base.Managers
{
    abstract class ChampionDefaults
    {
        public static BertOrbwalkingModes combo;

        abstract public void Combo();

        abstract public void Mixed();

        abstract public void Lasthit();

        abstract public void Laneclear();

        abstract public void AutoHarass();

        abstract public void SemiUlt();
    }
}

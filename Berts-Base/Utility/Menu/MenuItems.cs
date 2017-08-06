using Aimtec.SDK.Menu;

namespace Berts_Base.MenuContainers
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Container class for the different Menu containers in the Assembly
    /// </summary>
    public class MenuItems
    {
        public Menu Root { get; set; }

        public Menu Misc { get; set; }

        public Menu Mode { get; set; }
        public Menu Combo { get; set; }
        public Menu Harass { get; set; }
        public Menu AutoHarass { get; set; }
        public Menu Lasthit { get; set; }
        public Menu Laneclear { get; set; }
        public Menu SemiUlt { get; set; }

        public Menu ComboManaMenu { get; set; }
        public Menu HarassManaMenu { get; set; }
        public Menu LaneClearManaMenu { get; set; }
        public Menu LastHitManaMenu { get; set; }
        public Menu AutoHarassManaMenu { get; set; }
    }
}

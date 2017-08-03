using Aimtec.SDK.Menu;

public class MenuItems
{
    public Menu Root { get; set; }
    public Menu Combo { get; set; }
    public Menu Mixed { get; set; }
    public Menu Lasthit { get; set; }
    public Menu Laneclear { get; set; }
    public Menu AutoHarass { get; set; }
    public Menu SemiUlt { get; set; }
    public Menu Mode { get; set; }
    public Menu Misc { get; set; }

    public Menu ComboManaMenu { get; set; }
    public Menu HarassManaMenu { get; set; }
    public Menu LaneClearManaMenu { get; set; }
    public Menu LastHitManaMenu { get; set; }
    public Menu AutoHarassManaMenu { get; set; }
    public Menu Champion { get; internal set; }
}

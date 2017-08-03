using Aimtec.SDK.Menu.Components;
using Berts_Base.Managers;
using Berts_Base.Utility;

namespace Berts_Base.Champion.Menu.BuildMenus
{
    class BasicSettings
    {
        protected BasicSettings(ref MenuManager menu, string build)
        {
            SetUpComboManaManager(ref menu, build);
            SetUpHarassManaManager(ref menu, build);
            SetUpLaneClearManaManager(ref menu, build);
            SetUpLastHitManaManager(ref menu, build);
            SetUpAutoHarassManaManager(ref menu, build);
        }

        protected virtual void SetUpComboManaManager(ref MenuManager menu, string build)
        {
            //Combo Container
            menu._menuItems.Combo = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.ComboSettingsL, Constants.ChampionMenus.ComboSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Combo);

            //Combo Mana Menu
            menu._menuItems.ComboManaMenu = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.ComboManaManagerL, Constants.ChampionMenus.ComboManaManager);
            {
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Combo.Add(menu._menuItems.ComboManaMenu);
        }

        protected virtual void SetUpHarassManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.Mixed = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.HarassSettingsL, Constants.ChampionMenus.HarassSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Mixed);

            //Harass Mana Menu
            menu._menuItems.HarassManaMenu = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.HarassManaManagerL, Constants.ChampionMenus.HarassManaManager);
            {
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Mixed.Add(menu._menuItems.HarassManaMenu);
        }

        protected virtual void SetUpLaneClearManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.Laneclear = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.LaneClearSettingsL, Constants.ChampionMenus.LaneClearSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Laneclear);

            //Harass Mana Menu
            menu._menuItems.LaneClearManaMenu = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.LaneClearManaManagerL, Constants.ChampionMenus.LaneClearManaManager);
            {
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Laneclear.Add(menu._menuItems.LaneClearManaMenu);
        }

        protected virtual void SetUpLastHitManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.Lasthit = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.LastHitSettingsL, Constants.ChampionMenus.LastHitSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Lasthit);

            //Harass Mana Menu
            menu._menuItems.LastHitManaMenu = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.LastHitManaManagerL, Constants.ChampionMenus.LastHitManaManager);
            {
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Lasthit.Add(menu._menuItems.LastHitManaMenu);
        }

        protected virtual void SetUpAutoHarassManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.AutoHarass = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.AutoHarassSettingsL, Constants.ChampionMenus.AutoHarassSettings);
            menu._menuItems.Mode.Add(menu._menuItems.AutoHarass);

            //Harass Mana Menu
            menu._menuItems.AutoHarassManaMenu = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.AutoHarassManaManagerL, Constants.ChampionMenus.AutoHarassManaManager);
            {
                menu._menuItems.AutoHarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.AutoHarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.AutoHarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.AutoHarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.AutoHarass.Add(menu._menuItems.AutoHarassManaMenu);
        }
    }
}

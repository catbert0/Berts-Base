using Aimtec.SDK.Menu;
using Aimtec.SDK.Menu.Components;
using Berts_Base.SetupHelpers;
using System;

namespace Berts_Base.Champion.AssemblyMenu.BuildMenus
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Base class for General Champion Settings
    /// </summary>
    class BasicSettings
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasicSettings"/> class.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="build">The build.</param>
        protected BasicSettings(ref MenuManager menu, string build)
        {
            try
            {
                SimpleLog.Info("Setting up General Champion settings");
                SetUpComboManaManager(ref menu, build);
                SetUpHarassManaManager(ref menu, build);
                SetUpLaneClearManaManager(ref menu, build);
                SetUpLastHitManaManager(ref menu, build);
                SetUpAutoHarassManaManager(ref menu, build);
                SimpleLog.Info("Finished setting up Champion settings");
            }
            catch (Exception ex)
            {
                SimpleLog.Error("Could not setup BasicSettings " + ex.Message);
            }
        }

        /// <summary>
        /// Sets up combo mana manager.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="build">The build.</param>
        protected virtual void SetUpComboManaManager(ref MenuManager menu, string build)
        {
            //Combo Container
            menu._menuItems.Combo = new Menu(Constants.ChampionMenus.ComboSettingsL, Constants.ChampionMenus.ComboSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Combo);

            //Combo Mana Menu
            menu._menuItems.ComboManaMenu = new Menu(Constants.ChampionMenus.ComboManaManagerL, Constants.ChampionMenus.ComboManaManager);
            {
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.ComboManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Combo.Add(menu._menuItems.ComboManaMenu);
        }

        /// <summary>
        /// Sets up harass mana manager.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="build">The build.</param>
        protected virtual void SetUpHarassManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.Harass = new Menu(Constants.ChampionMenus.HarassSettingsL, Constants.ChampionMenus.HarassSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Harass);

            //Harass Mana Menu
            menu._menuItems.HarassManaMenu = new Menu(Constants.ChampionMenus.HarassManaManagerL, Constants.ChampionMenus.HarassManaManager);
            {
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.HarassManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Harass.Add(menu._menuItems.HarassManaMenu);
        }

        /// <summary>
        /// Sets up lane clear mana manager.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="build">The build.</param>
        protected virtual void SetUpLaneClearManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.Laneclear = new Menu(Constants.ChampionMenus.LaneClearSettingsL, Constants.ChampionMenus.LaneClearSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Laneclear);

            //Harass Mana Menu
            menu._menuItems.LaneClearManaMenu = new Menu(Constants.ChampionMenus.LaneClearManaManagerL, Constants.ChampionMenus.LaneClearManaManager);
            {
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.LaneClearManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Laneclear.Add(menu._menuItems.LaneClearManaMenu);
        }

        /// <summary>
        /// Sets up last hit mana manager.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="build">The build.</param>
        protected virtual void SetUpLastHitManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.Lasthit = new Menu(Constants.ChampionMenus.LastHitSettingsL, Constants.ChampionMenus.LastHitSettings);
            menu._menuItems.Mode.Add(menu._menuItems.Lasthit);

            //Harass Mana Menu
            menu._menuItems.LastHitManaMenu = new Menu(Constants.ChampionMenus.LastHitManaManagerL, Constants.ChampionMenus.LastHitManaManager);
            {
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerQL, Constants.ChampionMenus.manaManagerQ, 0));
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerWL, Constants.ChampionMenus.manaManagerW, 0));
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerEL, Constants.ChampionMenus.manaManagerE, 0));
                menu._menuItems.LastHitManaMenu.Add(new MenuSlider(build + Constants.ChampionMenus.manaManagerRL, Constants.ChampionMenus.manaManagerR, 0));
            }
            menu._menuItems.Lasthit.Add(menu._menuItems.LastHitManaMenu);
        }

        /// <summary>
        /// Sets up automatic harass mana manager.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <param name="build">The build.</param>
        protected virtual void SetUpAutoHarassManaManager(ref MenuManager menu, string build)
        {
            //Harass Container
            menu._menuItems.AutoHarass = new Menu(Constants.ChampionMenus.AutoHarassSettingsL, Constants.ChampionMenus.AutoHarassSettings);
            menu._menuItems.Mode.Add(menu._menuItems.AutoHarass);

            //Harass Mana Menu
            menu._menuItems.AutoHarassManaMenu = new Menu(Constants.ChampionMenus.AutoHarassManaManagerL, Constants.ChampionMenus.AutoHarassManaManager);
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

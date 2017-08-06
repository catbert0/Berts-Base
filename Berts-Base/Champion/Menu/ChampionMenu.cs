using Berts_Base.Champion.Menu.BuildMenus;
using Berts_Base.SetupHelpers;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Menu;
using System;

namespace Berts_Base.Champion.Menu
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Class for managing the different supported menus
    /// </summary>
    class ChampionMenu
    {
        public bool _needsRefresh { get; private set; }

        private ADMenu _adMenu;
        private APMenu _apMenu;
        private SupportMenu _supportMenu;
        private GeneralMenu _generalMenu;

        /// <summary>
        /// Populates the menu with supported builds
        /// </summary>
        /// <param name="menu">The menu.</param>
        public void PopulateSupportedBuilds(ref MenuManager menu)
        {
            SimpleLog.Info("Initialising MenuManager");

            DisposeOldMenu(ref menu);

            menu._menuItems.Mode = new Aimtec.SDK.Menu.Menu(Constants.MenuOptions.BuildL, Constants.MenuOptions.Build);
            {
                menu._menuItems.Mode.Add(new MenuList(Constants.MenuOptions.ModeL, Constants.MenuOptions.Mode, MenuHelper.GetSupportedModes(), 0));
            }
            menu._menuItems.Root.Add(menu._menuItems.Mode);

            menu._menuItems.Mode.OnValueChanged += Mode_OnValueChanged;
        }

        /// <summary>
        /// Initialises a new build
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        public Build GetBuildSettings(ref MenuManager menu)
        {
            SimpleLog.Info("Initialising a new build GetBuildSettings()");
            Build build = GetBuild(menu);
            switch (build)
            {
                case Build.AD_Mode:
                    {
                        _adMenu = new ADMenu(ref menu, Constants.ChampionMenus.AD.ToLower());
                        return Build.AD_Mode;
                    }

                case Build.AP_Mode:
                    {
                        _apMenu = new APMenu(ref menu, Constants.ChampionMenus.AP.ToLower());
                        return Build.AP_Mode;
                    }

                case Build.General_Mode:
                    {
                        _generalMenu = new GeneralMenu(ref menu, Constants.ChampionMenus.General.ToLower());
                        return Build.General_Mode;
                    }

                case Build.Support_Mode:
                    {
                        _supportMenu = new SupportMenu(ref menu, Constants.ChampionMenus.Support.ToLower());
                        return Build.Support_Mode;
                    }

                default:
                    SimpleLog.Error("Failed to recognise build set in the menu GetBuildSettings()");
                    return Build.Unknown;
            }
        }

        /// <summary>
        /// Choosing a different build type will remove the menu
        /// and rebuild it for the new build
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The arguments.</param>
        private void Mode_OnValueChanged(MenuComponent sender, ValueChangedArgs args)
        {
            //We only refresh menu if a new build is chosen
            if (sender.DisplayName == Constants.MenuOptions.Mode)
                _needsRefresh = true;
        }

        /// <summary>
        /// Disposes old build menu if it has changed
        /// </summary>
        /// <param name="menu">The menu.</param>
        private void DisposeOldMenu(ref MenuManager menu)
        {
            try
            {
                //If we changed build - we dispose old menu and rebuild
                if (_needsRefresh)
                {
                    SimpleLog.Info("Refreshing Menu...");
                    _needsRefresh = false;
                    menu._menuItems.Mode.Dispose();
                }
            }
            catch(Exception ex)
            {
                SimpleLog.Error("Failed to RefreshMenu() " + ex.Message);
            }
        }

        /// <summary>
        /// Attemps get the Build currently set in the menu
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        private Build GetBuild(MenuManager menu)
        {
            try
            {
                SimpleLog.Info("Getting Build from menu");
                Build build;
                Enum.TryParse(menu._menuItems.Mode[Constants.MenuOptions.ModeL].As<MenuList>().SelectedItem.ToString(), out build);
                return build;
            }
            catch (Exception ex)
            {
                SimpleLog.Error("Failed to GetBuild() " + ex.Message);
                return Build.Unknown;
            }
        }
    }
}

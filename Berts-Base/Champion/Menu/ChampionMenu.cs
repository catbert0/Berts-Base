using Berts_Base.Champion.Menu.BuildMenus;
using Berts_Base.Utility;
using Berts_Base.Managers;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Menu;
using System;

namespace Berts_Base.Champion.Menu
{
    class ChampionMenu
    {
        public static bool _needsRefresh { get; set; }

        ADMenu _adMenu;
        APMenu _apMenu;
        SupportMenu _supportMenu;
        GeneralMenu _generalMenu;

        public void PopulateBuilds(ref MenuManager menu)
        {
            //If we changew buuild - we dispose old menu and rebuild
            if (_needsRefresh)
            {
                menu._menuItems.Mode.Dispose();
            }

            menu._menuItems.Mode = new Aimtec.SDK.Menu.Menu(Constants.MenuOptions.BuildL, Constants.MenuOptions.Build);
            {
                menu._menuItems.Mode.Add(new MenuList(Constants.MenuOptions.ModeL, Constants.MenuOptions.Mode, Constants.Builds.SupportedBuilds, 0));
            }
            menu._menuItems.Root.Add(menu._menuItems.Mode);

            menu._menuItems.Mode.OnValueChanged += Mode_OnValueChanged;
        }

        public void GetBuildSettings(ref MenuManager menu)
        {
            switch (menu._menuItems.Mode[Constants.MenuOptions.ModeL].As<MenuList>().SelectedItem.ToString())
            {
                case Constants.Builds.ADSupported:
                    {
                        _adMenu = new ADMenu(ref menu, Constants.ChampionMenus.AD.ToLower());
                    }
                    break;

                case Constants.Builds.APSupported:
                    {
                        _apMenu = new APMenu(ref menu, Constants.ChampionMenus.AP.ToLower());
                    }
                    break;

                case Constants.Builds.GeneralSupported:
                    {
                        _generalMenu = new GeneralMenu(ref menu, Constants.ChampionMenus.General.ToLower());
                    }
                    break;

                case Constants.Builds.SupportSupported:
                    {
                        _supportMenu = new SupportMenu(ref menu, Constants.ChampionMenus.Support.ToLower());
                    }
                    break;
            }
        }

        /// <summary>
        /// Choosing a different build type will remove the menu
        /// and rebuild it for the new build
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void Mode_OnValueChanged(MenuComponent sender, ValueChangedArgs args)
        {
            //We only refresh menu if a new build is chosen
            if (sender.DisplayName == Constants.MenuOptions.Mode)
                _needsRefresh = true;
        }
    }
}

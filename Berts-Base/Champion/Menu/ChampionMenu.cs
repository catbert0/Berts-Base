using System;
using Berts_Base.Champion.Menu.BuildMenus;
using System.Collections.Generic;
using System.Reflection;
using Berts_Base.Utility;
using System.Linq;
using Berts_Base.Managers;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Menu;

namespace Berts_Base.Champion.Menu
{
    class ChampionMenu
    {
        public static bool _needsRefresh { get; set; }

        ADMenu _adMenu = new ADMenu();
        APMenu _apMenu = new APMenu();
        SupportMenu _supportMenu = new SupportMenu();
        GeneralMenu _generalMenu = new GeneralMenu();

#warning This must be updated with supported builds
        List<String> _supportedBuilds = new List<string> { Constants.MenuOptions.ADSupported, Constants.MenuOptions.APSupported, Constants.MenuOptions.GeneralSupported, Constants.MenuOptions.SupportSupported };

        public void PopulateBuilds(ref MenuManager menu)
        {
            //If we changew buuild - we dispose old menu and rebuild
            if (_needsRefresh)
            {
                menu._menuItems.Mode.Dispose();
            }

            menu._menuItems.Mode = new Aimtec.SDK.Menu.Menu(Constants.MenuOptions.BuildL, Constants.MenuOptions.Build);
            {
                menu._menuItems.Mode.Add(new MenuList(Constants.MenuOptions.ModeL, Constants.MenuOptions.Mode, _supportedBuilds.ToArray(), 0));
            }
            menu._menuItems.Root.Add(menu._menuItems.Mode);

            menu._menuItems.Mode.OnValueChanged += Mode_OnValueChanged;
        }

        public void GetBuildSettings(ref MenuManager menu)
        {
            switch (menu._menuItems.Mode[Constants.MenuOptions.ModeL].As<MenuList>().SelectedItem.ToString())
            {
                case Constants.MenuOptions.ADSupported:
                    {
                        _adMenu.SetupMenu(ref menu);
                    }
                    break;

                case Constants.MenuOptions.APSupported:
                    {
                        _apMenu.SetupMenu(ref menu);
                    }
                    break;

                case Constants.MenuOptions.GeneralSupported:
                    {
                        _generalMenu.SetupMenu(ref menu);
                    }
                    break;

                case Constants.MenuOptions.SupportSupported:
                    {
                        _supportMenu.SetupMenu(ref menu);
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
            _needsRefresh = true;
        }
    }
}

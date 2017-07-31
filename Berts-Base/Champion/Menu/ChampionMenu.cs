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
        ADMenu _adMenu = new ADMenu();
        APMenu _apMenu = new APMenu();
        SupportMenu _supportMenu = new SupportMenu();
        GeneralMenu _generalMenu = new GeneralMenu();

        public void PopulateBuilds(ref MenuManager menu)
        {
            List<String> builds = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.Namespace == Constants.ChampionMenus.BuildsLocation).ToList().Select(x => x.Name).ToList();

            menu._menuItems.Mode = new Aimtec.SDK.Menu.Menu(Constants.MenuOptions.BuildL, Constants.MenuOptions.Build);
            {
                menu._menuItems.Mode.Add(new MenuList(Constants.MenuOptions.ModeL, Constants.MenuOptions.Mode, builds.ToArray(), 0));
            }
            menu._menuItems.Root.Add(menu._menuItems.Mode);

            menu._menuItems.Mode.OnValueChanged += Mode_OnValueChanged;
        }

        public void GetBuildSettings(ref MenuManager menu)
        {
            switch (menu._menuItems.Mode[Constants.MenuOptions.ModeL].As<MenuList>().Value)
            {
                case 0:
                    {
                        _adMenu.SetupMenu(ref menu);
                    }
                    break;

                case 1:
                    {
                        _apMenu.SetupMenu(ref menu);
                    }
                    break;

                case 2:
                    {
                        _generalMenu.SetupMenu(ref menu);
                    }
                    break;

                case 3:
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
            sender.Parent.Dispose();
        }
    }
}

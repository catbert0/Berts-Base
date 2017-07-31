using Aimtec.SDK.Menu.Components;
using Berts_Base.Managers;
using Berts_Base.Utility;

namespace Berts_Base.Champion.Menu.BuildMenus
{
    class SupportMenu
    {
        public void SetupMenu(ref MenuManager menu)
        {
            menu._menuItems.Champion = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus., Constants.ChampionMenus.);
            {
                menu._menuItems.Champion.Add(new MenuBool(Constants.MenuOptions., Constants.MenuOptions.));
            }
            menu._menuItems.Mode.Add(menu._menuItems.Champion);
        }
    }
}

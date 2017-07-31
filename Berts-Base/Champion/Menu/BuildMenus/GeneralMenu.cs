using Aimtec.SDK.Menu.Components;
using Berts_Base.Managers;
using Berts_Base.Utility;

namespace Berts_Base.Champion.Menu.BuildMenus
{
    class GeneralMenu
    {
        public void SetupMenu(ref MenuManager menu)
        {
            menu._menuItems.Champion = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.General.ToLower(), Constants.ChampionMenus.General);
            {
                menu._menuItems.Champion.Add(new MenuBool(Constants.MenuOptions.AutoHarassQL, Constants.MenuOptions.AutoHarassQ));
            }
            menu._menuItems.Mode.Add(menu._menuItems.Champion);
        }
    }
}

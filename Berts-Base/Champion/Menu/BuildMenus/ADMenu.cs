using Aimtec.SDK.Menu.Components;
using Berts_Base.Utility;
using Berts_Base.Managers;

namespace Berts_Base.Champion.Menu.BuildMenus
{
    class ADMenu
    {
        public void SetupMenu(ref MenuManager menu)
        {
            menu._menuItems.Champion = new Aimtec.SDK.Menu.Menu(Constants.ChampionMenus.AD.ToLower(), Constants.ChampionMenus.AD);
            {
                menu._menuItems.Champion.Add(new MenuBool(Constants.MenuOptions.AutoHarassQL, Constants.MenuOptions.AutoHarassQ));
            }
            menu._menuItems.Mode.Add(menu._menuItems.Champion);
        }
    }
}

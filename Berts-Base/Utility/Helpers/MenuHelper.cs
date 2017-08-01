using Aimtec.SDK.Menu;
using Aimtec.SDK.Menu.Components;

namespace Berts_Base.Utility.Helpers
{
    class MenuHelper
    {
        /// <summary>
        /// Utility method to return the value selected in a list
        /// </summary>
        /// <param name="menuItem"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static int GetMenuListItemVal(Menu menuItem, string option)
        {
            return menuItem[option].As<MenuList>().Value;
        }

        /// <summary>
        /// Utility method to return the value selected in a list
        /// </summary>
        /// <param name="menuItem"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        public static bool GetMenuBoolVal(Menu menuItem, string option)
        {
            return menuItem[option].As<MenuBool>().Value;
        }
    }
}

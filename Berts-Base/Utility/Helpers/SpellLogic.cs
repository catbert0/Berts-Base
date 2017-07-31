using Aimtec.SDK.Menu;
using Aimtec.SDK.Menu.Components;
using Berts_Base.Managers;
using Berts_Base.Utility;

namespace Berts_Base.Utility.Helpers
{
    public class SpellLogic
    {
        /// <summary>
        /// Block casting spells until a selected level
        /// </summary>
        /// <param name="championLevel"></param>
        /// <param name="menu"></param>
        /// <returns></returns>
        public bool ShouldCastSpells(int championLevel, MenuManager menu)
        {
            int selectedMenuVal = GetListItemVal(menu._menuItems.Misc, Constants.MenuOptions.SpellLevelBlockerL);

            return selectedMenuVal == 0 ? true : championLevel >= selectedMenuVal;
        }

        /// <summary>
        /// Utility method to return the value selected in a list
        /// </summary>
        /// <param name="menuItem"></param>
        /// <param name="option"></param>
        /// <returns></returns>
        private int GetListItemVal(Menu menuItem, string option)
        {
            return menuItem[option].As<MenuList>().Value;
        }
    }
}

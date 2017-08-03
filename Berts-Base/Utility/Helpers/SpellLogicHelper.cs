using Berts_Base.Managers;

namespace Berts_Base.Utility.Helpers
{
    public class SpellLogicHelper
    {
        /// <summary>
        /// Block casting spells until a selected level
        /// </summary>
        /// <param name="championLevel"></param>
        /// <param name="menu"></param>
        /// <returns></returns>
        public bool ShouldCastSpells(int championLevel, MenuManager menu)
        {
            int selectedMenuVal = MenuHelper.GetMenuListItemVal(menu._menuItems.Misc, Constants.MenuOptions.SpellLevelBlockerL);

            return selectedMenuVal == 0 ? true : championLevel >= selectedMenuVal;
        }

        /// <summary>
        /// Gets if player should ignore manamanger with bluebuff
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public bool IgnoreManaManager(MenuManager menu)
        {
            return(MenuHelper.GetMenuBoolVal(menu._menuItems.Misc, Constants.MenuOptions.ManaManagerDisableL));
        }
    }
}

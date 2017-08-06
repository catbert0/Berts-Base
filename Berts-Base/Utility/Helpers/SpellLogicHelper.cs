using Berts_Base.SetupHelpers;

namespace Berts_Base
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// SpellHelper class to interface with menu options to decide
    /// what to do
    /// </summary>
    public static class SpellLogicHelper
    {
        /// <summary>
        /// Block casting spells until a selected level
        /// </summary>
        /// <param name="championLevel">The champion level.</param>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        public static bool ShouldCastSpells(int championLevel, MenuManager menu)
        {
            int selectedMenuVal = MenuHelper.GetMenuListItemVal(menu._menuItems.Misc, Constants.MenuOptions.SpellLevelBlockerL);

            return selectedMenuVal == 0 ? true : championLevel >= selectedMenuVal;
        }

        /// <summary>
        /// Gets if player should ignore manamanger with bluebuff
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public static bool IgnoreManaManager(MenuManager menu)
        {
            return(MenuHelper.GetMenuBoolVal(menu._menuItems.Misc, Constants.MenuOptions.ManaManagerDisableL));
        }
    }
}

using Aimtec;
using Aimtec.SDK.Menu;
using Berts_Base.SetupHelpers;

namespace Berts_Base.Champion.Spells
{
    class SpellController
    {
        /// <summary>
        /// Block casting spells until a selected level
        /// </summary>
        /// <param name="championLevel">The champion level.</param>
        /// <param name="menu">The menu.</param>
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
            return (MenuHelper.GetMenuBoolVal(menu._menuItems.Misc, Constants.MenuOptions.ManaManagerDisableL));
        }

        //RX
        public bool CanCastSmite(Obj_AI_Hero champion, ChampionSpellValues championSpells, MenuManager menu)
        {
            if (championSpells._smiteSpell != null && championSpells._smiteSpell.Ready && champion.Mana >= MenuHelper.GetMenuSliderValue(menu._menuItems.Misc, Constants.ChampionMenus.manaManagerQL))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether this instance [can cast q] useing the specified champion.
        /// </summary>
        /// <param name="champion">The champion.</param>
        /// <param name="championSpells">The champion spells.</param>
        /// <param name="menu">The menu.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can cast q] the specified champion; otherwise, <c>false</c>.
        /// </returns>
        public bool CanCastQ(Obj_AI_Hero champion, ChampionSpellValues championSpells, Menu menu)
        {
            //RC neeed to pass in specific menu of the orbwalking mode
            if (championSpells._qSpell != null && champion.SpellBook.CanUseSpell(SpellSlot.Q) && championSpells._qSpell.Ready &&
                champion.Mana >= MenuHelper.GetMenuSliderValue(menu, Constants.ChampionMenus.manaManagerQL))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Determines whether this instance [can cast q] useing the specified champion.
        /// </summary>
        /// <param name="champion">The champion.</param>
        /// <param name="championSpells">The champion spells.</param>
        /// <param name="menu">The menu.</param>
        /// <returns>
        ///   <c>true</c> if this instance [can cast q] the specified champion; otherwise, <c>false</c>.
        /// </returns>
        public bool CanCastW(Obj_AI_Hero champion, ChampionSpellValues championSpells, Menu menu)
        {
            //RC neeed to pass in specific menu of the orbwalking mode
            if (championSpells._wSpell != null && champion.SpellBook.CanUseSpell(SpellSlot.W) && championSpells._wSpell.Ready &&
                champion.Mana >= MenuHelper.GetMenuSliderValue(menu, Constants.ChampionMenus.manaManagerWL))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Controller to not cast spells until a certain specified level from the menu
        /// </summary>
        /// <returns></returns>
        private bool CanCastSpells(Obj_AI_Hero champion, MenuManager menu)
        {
            return ShouldCastSpells(champion.Level, menu);
        }

        /// <summary>
        /// Controller to ignore manamanager if player has blue buff
        /// </summary>
        /// <returns></returns>
        private bool ShouldIgnoreManaManager(Obj_AI_Hero champion, MenuManager menu)
        {
            if (IgnoreManaManager(menu) && champion.BuffManager.HasBuff(Constants.BuffNames.BlueBuff))
            {
                return true;
            }

            return false;
        }
    }
}

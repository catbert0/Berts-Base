using Aimtec.SDK.Menu;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Orbwalking;
using Berts_Base.Utility;

namespace Berts_Base.Managers
{
    public class MenuManager
    {
        public MenuItems _menuItems { get; set; }

        public MenuManager(IOrbwalker orbWalker, string rootMenuNameInternalName, string rootMenuName)
        {
            _menuItems = new MenuItems()
            {
                Root = new Menu(rootMenuNameInternalName, rootMenuName, true)
            };
            {
                orbWalker.Attach(_menuItems.Root);

                _menuItems.Mode = new Menu(Constants.MenuOptions.ModeMenuL, Constants.MenuOptions.ModeMenu);
                {
                    _menuItems.Mode.Add(new MenuList(Constants.MenuOptions.ModeL, Constants.MenuOptions.Mode, Constants.MenuOptions.ModeOptions, 0));
                }

                _menuItems.Misc = new Menu(Constants.MenuOptions.MiscMenuL, Constants.MenuOptions.MiscMenu);
                {
                    _menuItems.Misc.Add(new MenuBool(Constants.MenuOptions.SupportModeL, Constants.MenuOptions.SupportMode));
                    _menuItems.Misc.Add(new MenuBool(Constants.MenuOptions.DisableAAL, Constants.MenuOptions.DisableAA));
                    _menuItems.Misc.Add(new MenuBool(Constants.MenuOptions.ManaManagerDisableL, Constants.MenuOptions.ManaManagerDisable));
                    _menuItems.Misc.Add(new MenuList(Constants.MenuOptions.SpellLevelBlockerL, Constants.MenuOptions.SpellLevelBlocker, Constants.MenuOptions.SpellLevelBlockerOptions, 0));
                }
                _menuItems.Root.Add(_menuItems.Misc);
            }
            _menuItems.Root.Attach();
        }
    }
}

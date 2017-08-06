using Aimtec.SDK.Menu;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Orbwalking;
using Berts_Base.MenuContainers;

namespace Berts_Base.SetupHelpers
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Initialises the Menu with Supported Builds and Misc Settings
    /// </summary>
    public class MenuManager
    {
        public MenuItems _menuItems { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuManager"/> class.
        /// </summary>
        /// <param name="orbWalker">The orb walker.</param>
        /// <param name="rootMenuNameInternalName">Name of the root menu name internal.</param>
        /// <param name="rootMenuName">Name of the root menu.</param>
        public MenuManager(IOrbwalker orbWalker, string rootMenuNameInternalName, string rootMenuName)
        {
            SimpleLog.Info("Initialising MenuManager");

            _menuItems = new MenuItems()
            {
                Root = new Menu(rootMenuNameInternalName, rootMenuName, true)
            };
            {
                orbWalker.Attach(_menuItems.Root);

                _menuItems.Mode = new Menu(Constants.MenuOptions.BuildL, Constants.MenuOptions.Build);
                {
                    _menuItems.Mode.Add(new MenuList(Constants.MenuOptions.ModeL, Constants.MenuOptions.Mode, MenuHelper.GetSupportedModes(), 0));
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

            SimpleLog.Info("MenuManager Initialised");
        }
    }
}

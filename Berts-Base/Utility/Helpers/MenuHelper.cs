using Aimtec.SDK.Menu;
using System.Collections.Generic;
using Aimtec.SDK.Menu.Components;

namespace Berts_Base
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// MenuHelper class to support getting values from MenuComponents
    /// </summary>
    static class MenuHelper
    {
        /// <summary>
        /// Utility method to return the value selected in a list
        /// </summary>
        /// <param name="menuItem">The menu item.</param>
        /// <param name="option">The option.</param>
        /// <returns></returns>
        public static int GetMenuListItemVal(Menu menuItem, string option)
        {
            return menuItem[option].As<MenuList>().Value;
        }

        /// <summary>
        /// Utility method to return the value selected in a list
        /// </summary>
        /// <param name="menuItem">The menu item.</param>
        /// <param name="option">The option.</param>
        /// <returns></returns>
        public static bool GetMenuBoolVal(Menu menuItem, string option)
        {
            return menuItem[option].As<MenuBool>().Value;
        }

        /// <summary>
        /// Gets the menu slider value.
        /// </summary>
        /// <param name="menuItem">The menu item.</param>
        /// <param name="option">The option.</param>
        /// <returns></returns>
        public static int GetMenuSliderValue(Menu menuItem, string option)
        {
            return menuItem[option].As<MenuSlider>().Value;
        }

        /// <summary>
        /// Checks to see what builds are supported in the properties
        /// file, so it can update the menu options
        /// </summary>
        /// <returns></returns>
        public static string[] GetSupportedModes()
        {
            SimpleLog.Info("Loading Supported Modes");
            List<string> supportedModes = new List<string>();

            if (Properties.Setup.Default.AD_Supported)
                supportedModes.Add(Build.AD_Mode.ToString());

            if (Properties.Setup.Default.AP_Supported)
                supportedModes.Add(Build.AP_Mode.ToString());

            if (Properties.Setup.Default.General_Supported)
                supportedModes.Add(Build.General_Mode.ToString());

            if (Properties.Setup.Default.Support_Supported)
                supportedModes.Add(Build.Support_Mode.ToString());

            SimpleLog.Info("Loaded + " + string.Join(",", supportedModes) + " Modes");
            return supportedModes.ToArray();
        }

        /// <summary>
        /// Currently a workaround for redrawing menus when user
        /// is holding an additional key when changing builds.
        /// 
        /// It simulates pressing a key to fix its state.
        /// </summary>
        /// <param name="keyPress"></param>
        public static void SimulateKeyPress(string keyPress)
        {
            SimpleLog.Info("Simulating " + keyPress);
            System.Windows.Forms.SendKeys.SendWait(keyPress);
        }
    }
}

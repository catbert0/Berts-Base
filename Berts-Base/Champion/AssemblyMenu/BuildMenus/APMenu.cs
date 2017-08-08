using Berts_Base.SetupHelpers;

namespace Berts_Base.Champion.AssemblyMenu.BuildMenus
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Class to controll and populate all menu options for AP
    /// </summary>
    /// <seealso cref="Berts_Base.Champion.Menu.BuildMenus.BasicSettings" />
    class APMenu : BasicSettings
    {
        public APMenu(ref MenuManager menu, string build) : base(ref menu,  build)
        {
        }
    }
}

using Berts_Base.SetupHelpers;

namespace Berts_Base.Champion.Menu.BuildMenus
{
    /// <summary>
    /// Author: Robert - catbert
    /// 
    /// Class to controll and populate all menu options for General
    /// </summary>
    /// <seealso cref="Berts_Base.Champion.Menu.BuildMenus.BasicSettings" />
    class GeneralMenu : BasicSettings
    {
        public GeneralMenu(ref MenuManager menu, string build) : base(ref menu, build)
        {
        }
    }
}

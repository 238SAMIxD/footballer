using BTD_Mod_Helper;
using Footballer;
using MelonLoader;

[assembly: MelonInfo(typeof(FootballerMod), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace Footballer
{
    public class FootballerMod : BloonsTD6Mod
    {
        // No Harmony Patches or hooks required for this whole tower!
    }
}
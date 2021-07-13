using HarmonyLib;
using Verse;

namespace SnowClearanceSanity
{
    internal class SnowClearanceSanity : Mod
    {
        public SnowClearanceSanity(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("net.marvinkosh.rimworld.mod.snowclearancesanity");
            harmony.PatchAll();
        }
    }
}
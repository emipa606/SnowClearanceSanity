using System.Reflection;
using HarmonyLib;
using Verse;

namespace SnowClearanceSanity;

internal class SnowClearanceSanity : Mod
{
    public SnowClearanceSanity(ModContentPack content) : base(content)
    {
        new Harmony("net.marvinkosh.rimworld.mod.snowclearancesanity").PatchAll(Assembly.GetExecutingAssembly());
    }
}
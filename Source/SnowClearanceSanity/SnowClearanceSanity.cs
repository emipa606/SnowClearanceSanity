using HarmonyLib;
using RimWorld;
using Verse;

namespace SnowClearanceSanity
{
    class SnowClearanceSanity : Mod
    {
        public SnowClearanceSanity(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("net.marvinkosh.rimworld.mod.snowclearancesanity");
            harmony.PatchAll();
        }
    }

    [HarmonyPatch(typeof(WorkGiver_ClearSnow), "HasJobOnCell")]
    class ClearanceSanity
    {
        public static void Postfix(ref bool __result, Pawn pawn, IntVec3 c, bool forced)
        {

            if (!__result)
            {
                return;
            }
            if (forced)
            {
                return;
            }
            if (pawn.Map.weatherManager.SnowRate >= SnowGentleRate && !c.Roofed(pawn.Map))
            {
                __result = false;
            }
        }

        private const float SnowGentleRate = 0.8f;
    }

}

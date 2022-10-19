using HarmonyLib;
using RimWorld;
using Verse;

namespace SnowClearanceSanity;

[HarmonyPatch(typeof(WorkGiver_ClearSnow), "HasJobOnCell")]
internal class ClearanceSanity
{
    private const float SnowGentleRate = 0.8f;

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
}
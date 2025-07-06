using HarmonyLib;
using RimWorld;
using Verse;

namespace SnowClearanceSanity;

[HarmonyPatch(typeof(WorkGiver_ClearSnowOrSand), nameof(WorkGiver_ClearSnowOrSand.HasJobOnCell))]
internal class WorkGiver_ClearSnowOrSand_HasJobOnCell
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

        if ((pawn.Map.weatherManager.SnowRate >= SnowGentleRate ||
             pawn.Map.weatherManager.SandRate >= SnowGentleRate) && !c.Roofed(pawn.Map))
        {
            __result = false;
        }
    }
}
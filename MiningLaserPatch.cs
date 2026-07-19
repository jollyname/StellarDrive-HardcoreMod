using HarmonyLib;
using Tools.MiningLaser;
using System.Reflection;

[HarmonyPatch(typeof(MiningLaser))]
public static class MiningLaserPatch
{
    [HarmonyPatch("Start")]
    [HarmonyPostfix]
    private static void StartPostfix(MiningLaser __instance)
    {
        FieldInfo dps = AccessTools.Field(typeof(MiningLaser), "dps");

        float value = (float)dps.GetValue(__instance);
        dps.SetValue(__instance, value * 0.5f);
    }
}
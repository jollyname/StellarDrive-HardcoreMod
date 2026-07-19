using MelonLoader;
using UnityEngine;
using Ship.Interface.Settings;

public static class HardcoreThrusterSettings
{
    public static void Apply()
    {
        ThrusterSettings[] thrusterList = Resources.FindObjectsOfTypeAll<ThrusterSettings>();
        // We expect 3 thrusters, for the 3 types, floor, ceiling, wall
        MelonLogger.Msg($"Found {thrusterList.Length} ThrusterSettings assets");

        foreach (ThrusterSettings settings in thrusterList)
        {
            settings.thrustStrength *= 0.5f;
            settings.fuelDurationPerUnit *= 0.4f;
            //settings.maxFuel *= 0.75f; Smaller tank, should I?
        }

        MelonLogger.Msg("Applied hardcore thruster settings");
    }
}
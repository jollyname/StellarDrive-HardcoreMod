using MelonLoader;
using UnityEngine;
using Player.Values;
using Player.Interface.Values;

public static class HardcoreSettings
{
    public static void Apply()
    {
        PlayerProperties[] propertiesList = Resources.FindObjectsOfTypeAll<PlayerProperties>();

        if (propertiesList.Length > 0)
        {
            PlayerProperties properties = propertiesList[0];

            properties.collisionDamageMultiplier = 0.1f;
            properties.collisionDamageThreshold = 350f;

            MelonLogger.Msg("Applied hardcore player properties");

            if (properties.movementSettings != null)
            {
                properties.movementSettings.walkingSpeed = 3.2f;
                properties.movementSettings.walkingAcceleration = 6f;
                properties.movementSettings.airControlAcceleration = 1f;
                properties.movementSettings.jumpVelocity = 4.5f;

                MelonLogger.Msg("Applied hardcore movement settings");
            }
        }

        PlayerStatusSettings[] statusList = Resources.FindObjectsOfTypeAll<PlayerStatusSettings>();

        if (statusList.Length > 0)
        {
            PlayerStatusSettings status = statusList[0];

            status.oxygenConsumptionRate = 4f;
            status.oxygenReplenishRate = 8f;
            status.healthRegenRate = 2f;

            MelonLogger.Msg("Applied hardcore status settings");
        }
    }
}
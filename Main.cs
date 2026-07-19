using MelonLoader;

namespace HardcoreMod
{
    public static class BuildInfo
    {
        public const string Name = "Hardcore mod";
        public const string Description = "Makes the game much harder";
        public const string Author = "Jollyname";
        public const string Company = null;
        public const string Version = "1.1.0";
        public const string DownloadLink = null;
    }

    public class HardcoreMod : MelonMod
    {
        public static MelonPreferences_Category Category =
            MelonPreferences.CreateCategory("Hardcore mod");

        public override void OnLateInitializeMelon()
        {

        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (buildIndex != 1) return;

            HardcoreSettings.Apply();
            HardcoreThrusterSettings.Apply();
        }

        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            if (buildIndex != 1) return;
        }
    }
}
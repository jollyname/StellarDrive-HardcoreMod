using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(HardcoreMod.BuildInfo.Description)]
[assembly: AssemblyDescription(HardcoreMod.BuildInfo.Description)]
[assembly: AssemblyCompany(HardcoreMod.BuildInfo.Company)]
[assembly: AssemblyProduct(HardcoreMod.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + HardcoreMod.BuildInfo.Author)]
[assembly: AssemblyTrademark(HardcoreMod.BuildInfo.Company)]
[assembly: AssemblyVersion(HardcoreMod.BuildInfo.Version)]
[assembly: AssemblyFileVersion(HardcoreMod.BuildInfo.Version)]
[assembly: MelonInfo(typeof(HardcoreMod.HardcoreMod), HardcoreMod.BuildInfo.Name, HardcoreMod.BuildInfo.Version, HardcoreMod.BuildInfo.Author, HardcoreMod.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("CuriousOwlGames", "StellarDrive")]
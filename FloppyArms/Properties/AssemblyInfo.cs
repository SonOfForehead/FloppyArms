using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using MelonLoader;

[assembly: AssemblyTitle(FloppyArms.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(FloppyArms.BuildInfo.Company)]
[assembly: AssemblyProduct(FloppyArms.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + FloppyArms.BuildInfo.Author)]
[assembly: AssemblyTrademark(FloppyArms.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(FloppyArms.BuildInfo.Version)]
[assembly: AssemblyFileVersion(FloppyArms.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(FloppyArms.FloppyArms), FloppyArms.BuildInfo.Name, FloppyArms.BuildInfo.Version, FloppyArms.BuildInfo.Author, FloppyArms.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]
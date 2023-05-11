using System;
using MelonLoader;
using UnityEngine;
using SLZ.Rig;
using BoneLib.BoneMenu;
using BoneLib.BoneMenu.Elements;
using BoneLib;

namespace FloppyArms
{
    public static class BuildInfo
    {
        public const string Name = "FloppyArms"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "Son of Forehead"; // Author of the Mod.  (Set as null if none)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)
    }

    public class FloppyArms : MelonMod
    {

        public static bool IsEnabled { get; private set; }
        public static void OnSetEnabled(bool value)
        {
            Player.physicsRig.leftHand.physHand.forceMultiplier = 0;
            Player.physicsRig.rightHand.physHand.forceMultiplier = 0;
        }

        private MelonPreferences_Category FloppyArmsCategory;
        private MelonPreferences_Entry<bool> MogToggle;

        public override void OnInitializeMelon()
        {
            FloppyArms.SetupBoneMenu();
        }

        public static void SetupBoneMenu()
        {
            MenuCategory menuCategory = MenuManager.CreateCategory("Floppy Arms", Color.blue);
            menuCategory.CreateBoolElement("Mog Toggle", Color.cyan, FloppyArms.IsEnabled, new Action<bool>(FloppyArms.OnSetEnabled));
        }

    }
}

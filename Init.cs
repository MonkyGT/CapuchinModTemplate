using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

using CapuchinTemplate.Patches;
using UnityEngine;
using BepInEx.Logging;

namespace CapuchinTemplate
{
    [BepInPlugin("yourname.modname", "Mod", "1.0.0")]
    public class Init : BasePlugin
    {
        public Harmony harmonyInstance;
        public Plugin pluginInstance;
        public static Init initInstance;

        public override void Load()
        {
            harmonyInstance = HarmonyPatcher.Patch("yourname.modname");
            initInstance = this;

            pluginInstance = new GameObject().AddComponent<Plugin>();
        }

        public override bool Unload()
        {
            if (harmonyInstance != null)
                HarmonyPatcher.Unpatch(harmonyInstance);

            return true;
        }
    }
}

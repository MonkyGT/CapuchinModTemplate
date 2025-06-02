using BepInEx.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace CapuchinTemplate
{
    public class Plugin : MonoBehaviour
    {
        public static Plugin instance;

        void Start()
        {
            instance = this;

            Caputilla.CaputillaManager.Instance.OnModdedJoin += OnJoin;
            Caputilla.CaputillaManager.Instance.OnModdedLeave += OnLeave;
            
            Caputilla.CaputillaManager.Instance.OnGameInitialized += Initialize;
            
            // Add your startup code here, initialize assets, check configurations, etc.
            WriteLine("Hello world");
        }

        void Initialize()
        {
            // Put anything that start when the player is spawned here
        }

        void OnJoin()
        {
            // Activate mod here
        }

        void OnLeave()
        {
            //Deactivate mod here
        }

        public void WriteLine(string text, LogLevel severity = LogLevel.Debug) => Init.initInstance.Log.Log(severity, text);
    }
}

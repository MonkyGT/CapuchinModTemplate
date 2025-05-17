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

            // Add your startup code here, initialize assets, check configurations, etc.
            WriteLine("Hello world");
        }

        public void WriteLine(string text, LogLevel severity = LogLevel.Debug) => Init.initInstance.Log.Log(severity, text);
    }
}

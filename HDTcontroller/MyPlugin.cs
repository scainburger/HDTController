using System;
using System.Windows.Controls;

using Hearthstone_Deck_Tracker.Plugins;

namespace HDTcontroller
{
    public class MyPlugin : IPlugin
    {
        public string Author
        {
            get { return "scainburger"; }
        }

        public string ButtonText
        {
            get { return null; }
        }

        public string Description
        {
            get { return "Allows you to control HS with a DirectInput controller (Xbox 360 etc)"; }
        }

        public MenuItem MenuItem
        {
            get { return null; }
        }

        public string Name
        {
            get { return "HDTcontroller"; }
        }

        public void OnButtonPress()
        {
        }

        public void OnLoad()
        {
        }

        public void OnUnload()
        {
        }

        public void OnUpdate()
        {
            Main.Update();
        }

        public Version Version
        {
            get { return new Version(0, 1, 0); }
        }
    }
}

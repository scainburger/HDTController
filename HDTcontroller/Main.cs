using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Hearthstone_Deck_Tracker;
using API = Hearthstone_Deck_Tracker.API.Core;
using Logger = Hearthstone_Deck_Tracker.Logger;


namespace HDTcontroller
{
    public class Main
    {
        
        private static Boolean debug = true;

        private static int playerHandCount;
        private static int playerMinionCount;
        private static int opponentHandCount;
        private static int opponentMinionCount;

        private static System.Windows.Point cardPos;

        public static void Update()
        {
            // Don't do anything if not in a game
            if (API.Game.IsInMenu || !API.Game.IsRunning)
                return;

            System.Windows.Point firstCardInHand = new System.Windows.Point(0.0d, 0.0d);
            firstCardInHand = Hearthstone_Deck_Tracker.Windows.OverlayWindow.GetPlayerCardPosition(1, 1);


            
            int count = API.Game.Entities.Count;
            int[] playerMinionPositions = { 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < count; i++)
            {   
                if (API.Game.Entities[0].IsPlayer)
                {

                }
            }

            // Compare with old value and update with new value simultaneously
            // Print to debug log if changed and if program is in debug mode
            if (playerHandCount != (playerHandCount = API.Game.Player.HandCount) && debug)
                Logger.WriteLine("Player now has " + playerHandCount + " in hand.");
            if (playerMinionCount != (playerMinionCount = API.Game.PlayerMinionCount) && debug)
                Logger.WriteLine("Player now has " + playerMinionCount + " minions.");

            if (opponentHandCount != (opponentHandCount = API.Game.Opponent.HandCount) && debug)
                Logger.WriteLine("Opponent now has " + opponentHandCount + " in hand.");
            if (opponentMinionCount != (opponentMinionCount = API.Game.OpponentMinionCount) && debug)
                Logger.WriteLine("Opponent now has " + opponentMinionCount + " minions.");


            /* 
                TODO
                -

                NOTES
                - if player.goingFirst mulligancards = 4
                - else mulligancards = 3
            */
        }
    }
}

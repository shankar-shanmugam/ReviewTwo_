using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewTwo
{
    internal class SnakeAndLadder
    {
        private int playerPosition;
        private int WINNING_POSITION = 100;

        public SnakeAndLadder()
        {
            playerPosition = 0;
        }
        public void Start()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            Console.WriteLine($"Player starting position: {playerPosition}");
            Console.WriteLine("Press any key to continue...");
        }

        public int GetPlayerPosition()
        {
            return playerPosition;
        }

        public void SetPlayerPosition(int newPosition)
        {
            playerPosition = newPosition;
        }

    }
}

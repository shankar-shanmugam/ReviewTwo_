using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewTwo
{
    internal class SnakeAndLadder
    {
        private int playerPosition;
     

        public SnakeAndLadder()
        {
            playerPosition = 0;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            Console.WriteLine($"Player starting position: {playerPosition}");
          

            Console.WriteLine("player rolling the dice !!!!");

            int dice_no = Rolldice();
            Console.WriteLine("Player getting the dice as "+dice_no);

        }

        public int Rolldice()
        {
            Random r= new Random();
             return  r.Next( 1,7 );
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

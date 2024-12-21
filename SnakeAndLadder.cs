using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReviewTwo
{
    internal class SnakeAndLadder
    {
        private static int playerPosition;
        private static int Count;
        public SnakeAndLadder()
        {
            playerPosition = 0;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            Console.WriteLine($"Player starting position: {playerPosition}");

            while (playerPosition < 100)
            {

                Console.WriteLine("player rolling the dice !!!!");

                int dice_no = Rolldice();
                Count++;
                Console.WriteLine("Player getting the dice as " + dice_no);

                int optionGetByPlayer = Options();

                switch (optionGetByPlayer)
                {
                    case 0:

                        Console.WriteLine("player getting option as no play ");
                        Console.WriteLine("current player position is " + playerPosition);
                        break;

                    case 1:

                        Console.WriteLine(" player getting ladder ");
                        int set = dice_no + GetPlayerPosition();
                        if(set > 100) SetPlayerPosition(GetPlayerPosition());
                        else SetPlayerPosition(set);
                        Console.WriteLine("current player position is " + playerPosition);
                        break;

                    case 2:
                        Console.WriteLine(" player getting snake ");
                        int set1 = GetPlayerPosition() - dice_no;
                        if (set1 > 0)
                            SetPlayerPosition(set1);
                        else
                            SetPlayerPosition(0);
                        Console.WriteLine("current player position is " + playerPosition);
                        break;
                }

            }
            Console.WriteLine("total no of times the dice rolled is " + Count);
        }

        public int Rolldice()
        {
            Random r= new Random();
             return  r.Next( 1,7 );
        }
        public int Options()
        {
            Random r = new Random();
            return r.Next(0,3);
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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReviewTwo
{
    internal class SnakeAndLadder
    {
        private static int Count;
       
        public void Start()
        {
            Console.WriteLine("Welcome to Snake and Ladder Game!");
            Player player_1 = new Player() { Name="shankar"};
            Player player_2 = new Player() { Name =" Dinesh" };

            Console.WriteLine($"Player starting position: {player_1.playerPosition}");
            Console.WriteLine($"Player starting position: {player_2.playerPosition}");

            while (player_1.playerPosition < 100 && player_2.playerPosition < 100)
            {
               MoveByPlayer(player_1);
               MoveByPlayer(player_2);
              
            }
            Console.WriteLine("total no of times the dice rolled in the game is : " + Count);

            if (player_1.playerPosition == 100)
                Console.WriteLine($"{player_1.Name} is winner!!! 🔥🔥🔥🔥🔥🔥😍😍 ");
            else if (player_2.playerPosition == 100)
                Console.WriteLine($"{player_2.Name} is winner!!! 🔥🔥🔥🔥🔥🔥😍😍 ");
        }

        public void MoveByPlayer(Player p)
        {
            Console.WriteLine(" rolling the dice for the player ----> "+p.Name);
            int dice_no = Rolldice();
            Count++;
            Console.WriteLine($"player :{p.Name} getting the dice as------->{dice_no}\n");

            Console.Write("Player going to choose the options:");
            int optionGetByPlayer = Options();
            switch (optionGetByPlayer)
            {
                case 0:
                    Console.WriteLine($"player : {p.Name} getting option as : no play ");
                    Console.WriteLine(" player position is " + p.playerPosition);
                    break;

                case 1:
                    Console.WriteLine($" player :'{p.Name}' getting ladder!!! 🪜🪜🪜🪜🪜🪜🪜🪜 ");
                    int set = dice_no + p.playerPosition;

                    if (set > 100)
                        p.playerPosition = p.playerPosition;
                    else
                        p.playerPosition = set;

                    Console.WriteLine("current player position is " + p.playerPosition);
                    break;

                case 2:
                    Console.WriteLine( $" player :'{p.Name}' caught by snake 🐍🐍🐍🐍🐍🐍🐍🐍 ");
                    int set1 = p.playerPosition - dice_no;
                    if (set1 > 0)
                        p.playerPosition = set1;
                    else
                        p.playerPosition = 0;
                    Console.WriteLine("current player position After 🐍🐍🐍🐍🐍 bite : " +p.playerPosition);
                    break;
            }
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
    }
}

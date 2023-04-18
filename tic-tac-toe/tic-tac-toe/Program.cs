﻿namespace Tic_Tac_Toe
{
    class Program
    {


        //playfield
       static char[,] playField =
{
    { '1', '2', '3' },//row 0
    { '4', '5', '6' },//row1
    { '7', '8', '9' }//row3
};

        static void Main(string[] args)
        {
            int player = 2;//player 1 starts
            int input = 0;
            bool inputCorrect = true;

            SetField();
            Console.ReadKey();



            //run code as long as program runs
            do
            {
                if (player == 2)
                {

                    player = 1;
                    EnterXorO(player, input);
                }

                else if (player == 1)
                {

                    player = 2;
                    EnterXorO(player, input);
                }

                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field!");
                    input = Convert.ToInt32(Console.ReadLine());

                } while (!inputCorrect);
                
                
            } while (true);
        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0,0] , playField[0, 1],playField[0, 2]);//row0, 
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);//row 1
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);//row 2
            Console.WriteLine("     |     |     ");
        }

        public static void EnterXorO(int player, int input)
        {


            char playerSign = ' ';


            if(player== 1)
            {
                playerSign = 'x';
            } else if (playerSign == 2)
            {
                playerSign = '0';
            }

            switch (input)
            {
                case 1: playField[0, 0] = playerSign; break;
                case 2: playField[0, 1] = playerSign; break;
                case 3: playField[0, 2] = playerSign; break;
                case 4: playField[1, 0] = playerSign; break;
                case 5: playField[1, 1] = playerSign; break;
                case 6: playField[1, 2] = playerSign; break;
                case 7: playField[2, 0] = playerSign; break;
                case 8: playField[2, 1] = playerSign; break;
                case 9: playField[2, 2] = playerSign; break;
            }
        }
                     
        }
    }


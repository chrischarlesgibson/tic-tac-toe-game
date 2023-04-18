namespace Tic_Tac_Toe
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
            int player = 1;//player 1 starts
            int input = 0;
            bool inputCorrect = true;

           




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


                SetField();
                #region

                //check winner

                char[] playerChars = { 'X', 'O' };

                foreach (char playerChar in playerChars)
                {
                    if (((playField[0,0] ==playerChar) && (playField[0,1]== playerChar)&& (playField[0, 2] == playerChar))
                        || ((playField[1, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[2, 0] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 0] == playerChar) && (playField[2, 0] == playerChar))
                        || ((playField[0, 1] == playerChar) && (playField[1, 1] == playerChar) && (playField[1, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[2, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 0] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 2] == playerChar))
                        || ((playField[0, 2] == playerChar) && (playField[1, 1] == playerChar) && (playField[2, 0] == playerChar)))
                    {


                        if (playerChar == 'X')
                        {
                            Console.WriteLine("player 1 has won");
                        }else
                            Console.WriteLine("player 2 has won");
                    }
                    break;
                }

                #endregion
                #region
                //region- test if field is already taken
                do
                {
                    Console.Write($"\nPlayer {player}: Choose your field!");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch 
                    {
                        Console.WriteLine("please enter a number");
                    }


                    if((input ==1) && (playField[0,0] == '1'))
                    {
                        inputCorrect = true; 
                    } else if ((input == 2) && (playField[0, 1] == '2')){
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (playField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input. Please use another field");
                        inputCorrect = false;
                    }


                } while (!inputCorrect);
                #endregion

            } while (true);
        }

        public static void SetField()
        {
            Console.Clear();
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
                playerSign = 'X';
            } else if (player == 2)
            {
                playerSign = 'O';
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


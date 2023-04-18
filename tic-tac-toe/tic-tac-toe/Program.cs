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
            SetField();
            Console.ReadKey();
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
    }
}

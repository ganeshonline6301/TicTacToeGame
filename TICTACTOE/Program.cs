using System;
using System.Threading;
using TICTACTOE;

namespace TIC_TAC_TOE
{
    internal class Program
    {
        
       
        
        static void Main(string[] args)
        {
            Play();
        }     

        public static void Play()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");
                if (BoardGame.player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");
                BoardGame.Board();
                BoardGame.PositionNumber = int.Parse(Console.ReadLine());
                if (BoardGame.arr[BoardGame.PositionNumber] != 'X' && BoardGame.arr[BoardGame.PositionNumber] != 'O')
                {
                    if (BoardGame.player % 2 == 0)
                    {
                        BoardGame.arr[BoardGame.PositionNumber] = 'O';
                        BoardGame.player++;
                    }
                    else
                    {
                        BoardGame.arr[BoardGame.PositionNumber] = 'X';
                        BoardGame.player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", BoardGame.PositionNumber, BoardGame.arr[BoardGame.PositionNumber]);
                    Console.WriteLine("\n");
                    Console.WriteLine("Please wait 2 second board is loading again.....");
                    Console.ReadKey();
                }
                BoardGame.flag = CheckGame.CheckWin();
            }
            while (BoardGame.flag != 1 && BoardGame.flag != -1);
            Console.Clear();
            BoardGame.Board();
            CheckGame.Flag();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOE
{
    public class CheckGame
    {
        BoardGame board=new BoardGame();
        public static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row
            if (BoardGame.arr[1] == BoardGame.arr[2] && BoardGame.arr[2] == BoardGame.arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row
            else if (BoardGame.arr[4] == BoardGame.arr[5] && BoardGame.arr[5] == BoardGame.arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row
            else if (BoardGame.arr[6] == BoardGame.arr[7] && BoardGame.arr[7] == BoardGame.arr[8])
            {
                return 1;
            }
            #endregion
            #region vertical Winning Condtion
            //Winning Condition For First Column
            else if (BoardGame.arr[1] == BoardGame.arr[4] && BoardGame.arr[4] == BoardGame.arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column
            else if (BoardGame.arr[2] == BoardGame.arr[5] && BoardGame.arr[5] == BoardGame.arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column
            else if (BoardGame.arr[3] == BoardGame.arr[6] && BoardGame.arr[6] == BoardGame.arr[9])
            {
                return 1;
            }
            #endregion
            #region Diagonal Winning Condition
            else if (BoardGame.arr[1] == BoardGame.arr[5] && BoardGame.arr[5] == BoardGame.arr[9])
            {
                return 1;
            }
            else if (BoardGame.arr[3] == BoardGame.arr[5] && BoardGame.arr[5] == BoardGame.arr[7])
            {
                return 1;
            }
            #endregion
            #region Checking For Draw
            else if (BoardGame.arr[1] != '1' && BoardGame.arr[2] != '2' && BoardGame.arr[3] != '3' && BoardGame.arr[4] != '4' && BoardGame.arr[5] != '5' && BoardGame.arr[6] != '6' && BoardGame.arr[7] != '7' && BoardGame.arr[8] != '8' && BoardGame.arr[9] != '9')
            {
                return -1;
            }
            #endregion
            else
            {
                return 0;
            }
        }
        public static void Flag()
        {
            if (BoardGame.flag == 1)
            {
                Console.WriteLine("Player {0} has won", (BoardGame.player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
        }
    }
}

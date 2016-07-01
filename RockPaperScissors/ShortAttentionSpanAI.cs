using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class ShortAttentionSpanAI : IPlayer
    {
        public int LastMoveOfOtherPlayer;

        public int NextMove()
        {
            int nextMove = 0;

            switch (LastMoveOfOtherPlayer)

            {
                case 0:                                // 0 is rock, 1, paper 2 scissors
                    nextMove = 1;
                    break;

                case 1:
                    nextMove = 2;
                    break;

                case 2:
                    nextMove = 0;
                    break;

                default:
                    nextMove = 2;
                    break;

            }
            return nextMove;
        }
          
            public void SaveResult(int myMove, int otherMove)
        {
            LastMoveOfOtherPlayer = otherMove;
        }
    }
}

   
  
 




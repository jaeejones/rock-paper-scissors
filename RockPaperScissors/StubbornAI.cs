using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        int FavoriteMove;

        public StubbornAI(int favoriteMove)
        {
            FavoriteMove = favoriteMove;
        }

        public int NextMove() // method
        {
            return FavoriteMove;
        }
        public void SaveResult(int myMove, int otherMove)
        {

        }


    }
}

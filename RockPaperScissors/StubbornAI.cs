using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class StubbornAI : IPlayer
    {
        int FavoriteMove; // my move intialized 

        public StubbornAI(int favoriteMove) // the constuctor
        {
            FavoriteMove = favoriteMove; 
        }

        public int NextMove() // method that is called for next move
        {
            return FavoriteMove; //retured what was intialzed from the int. 
        }
        public void SaveResult(int myMove, int otherMove)
        {

        }


    }
}

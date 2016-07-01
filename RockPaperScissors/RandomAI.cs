using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RandomAI : IPlayer
    {
        Random random = new Random();

        public int NextMove()
        {
            // 0 for rock, 1 for paper, 2 for scissors
           return random.Next(0, 3); //this returns the items from 0 to 2
          
        }

        public void SaveResult(int myMove, int otherMove)
        {
            //Method Intetionally left blank
        }
    }
}

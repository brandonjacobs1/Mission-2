using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIssion_2
{
    class Dice
    {
        public int RollDice()
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int roll = rnd.Next(1, 7);

            return roll;
        }
        
    }
}

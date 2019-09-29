using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis.Helpers
{
    class Constants
    {
        //has deuce
        public const bool HasNoAdvantage = false;
        public const bool HasAdvantage = true;

        //is deuce
        public const bool IsNotDeuce = false;
        public const bool IsDeuce = true;

        //game result
        public const int NextRound = 0;
        public const int WinMatch = 1;

        //round result
        public const bool WinRound = true;
        public const bool LoseRound = false;
    }
}

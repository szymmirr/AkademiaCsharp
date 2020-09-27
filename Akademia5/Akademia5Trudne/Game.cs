using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace akademia5trudne
{
    class Game
    {
        public static List<int> listRound = new List<int>();
        public static List<int> listPlayerOne = new List<int>();
        public static List<int> listPlayerTwo = new List<int>();
        public enum Player
        {
            Player1,
            Player2
        }
        public static int round = 0;
    }
}

using System;
using System.Collections.Generic;

namespace SoccerStats
{
    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            // the -1 sorts by descending order
            return -1 * x.PointsPerGame.CompareTo(y.PointsPerGame);
        }
    }
}

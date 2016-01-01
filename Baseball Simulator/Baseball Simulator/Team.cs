using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Simulator
{
    class Team
    {
        private Player[] playerList;
        public Player startingPitcher { get; set; }
        public Team()
        {
            playerList = new Player[9];
            startingPitcher = new Player();
        }

        public void addPlayerToRoster(Player toBeAdded, int lineUpPosition)
        {
            playerList[lineUpPosition - 1] = toBeAdded;
        }

        public Player getPlayerAtLineupPosition(int lineUpPosition)
        {
            return playerList[lineUpPosition - 1];
        }
    }
}

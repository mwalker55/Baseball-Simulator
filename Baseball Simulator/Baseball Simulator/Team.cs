using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Simulator
{
    public class Team
    {
        public Player[] playerList { get; set; }
        public Player startingPitcher { get; set; }
        public string teamName { get; set; }
        public Team()
        {
            playerList = new Player[9];
            for (int i = 0; i < 9; i++)
                playerList[i] = new Player();
            startingPitcher = new Player();
            teamName = "";
        }
    }
}

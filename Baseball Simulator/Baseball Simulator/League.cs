﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// MODEL TO REPRESENT A BASEBALL LEAGUE CONSISTING OF TEAMS

namespace Baseball_Simulator
{
    class League
    {
        private List<Team> leagueTeams;

        public League()
        {
            leagueTeams = new List<Team> { };
        }

        public void addTeamToLeague(Team toBeAdded)
        {
            leagueTeams.Add(toBeAdded);
        }
    }
}

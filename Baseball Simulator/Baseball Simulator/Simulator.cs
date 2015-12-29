using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Simulator
{
    class Simulator
    {
        private Player[] team1Players;
        private Player[] team2Players;
        private Player team1Pitcher, team2Pitcher, leagueAveragePlayer;
        private Random rand;
        public Simulator(Player[] Team1Players, Player[] Team2Players, Player Team1Pitcher, Player Team2Pitcher)
        {
            team1Players = Team1Players;
            team2Players = Team2Players;
            team1Pitcher = Team1Pitcher;
            team2Pitcher = Team2Pitcher;
            leagueAveragePlayer = new Player();
            computeLeagueAverage();
            normalizeTeamStats();
            rand = new Random();
        }

        private void computeLeagueAverage()
        {
            leagueAveragePlayer.walk_percentage = (team1Players.Average(item => item.walk_percentage)+team2Players.Average(item => item.walk_percentage))/2;
            leagueAveragePlayer.single_percentage = (team1Players.Average(item => item.single_percentage) + team2Players.Average(item => item.single_percentage)) / 2;
            leagueAveragePlayer.double_percentage = (team1Players.Average(item => item.double_percentage) + team2Players.Average(item => item.double_percentage)) / 2;
            leagueAveragePlayer.triple_percentage = (team1Players.Average(item => item.triple_percentage) + team2Players.Average(item => item.triple_percentage)) / 2;
            leagueAveragePlayer.HR_percentage = (team1Players.Average(item => item.HR_percentage) + team2Players.Average(item => item.HR_percentage)) / 2;
        }
        private void normalizeTeamStats()
        {
            for(int i = 0; i < team1Players.Length; i++)
            {
                convertToLog5(ref team1Players[i], team2Pitcher);
                convertToLog5(ref team2Players[i], team1Pitcher);
            }
        }

        private void convertToLog5(ref Player toBeConverted, Player pitcherFacing)
        {
            toBeConverted.walk_percentage = log5Function(toBeConverted.walk_percentage, pitcherFacing.walk_percentage, leagueAveragePlayer.walk_percentage);
            toBeConverted.single_percentage = log5Function(toBeConverted.single_percentage, pitcherFacing.single_percentage, leagueAveragePlayer.single_percentage);
            toBeConverted.double_percentage = log5Function(toBeConverted.double_percentage, pitcherFacing.double_percentage, leagueAveragePlayer.double_percentage);
            toBeConverted.triple_percentage = log5Function(toBeConverted.triple_percentage, pitcherFacing.triple_percentage, leagueAveragePlayer.triple_percentage);
            toBeConverted.HR_percentage = log5Function(toBeConverted.HR_percentage, pitcherFacing.HR_percentage, leagueAveragePlayer.HR_percentage);
        }

        private decimal log5Function(decimal playerValue, decimal pitcherValue, decimal leagueAverage)
        {
            return (playerValue * pitcherValue / leagueAverage) / ((playerValue * pitcherValue / leagueAverage) + (1 - playerValue) * (1 - pitcherValue) / (1 - leagueAverage));
        }

        public Tuple<int, int> simulateGames(int numGamesToSimulate)
        {
            int numGamesWonByTeam1 = 0;
            int numInnings = 0;
            for(int game = 0; game < numGamesToSimulate; game++)
            {
                int team1AB = 0;
                int team2AB = 0;
                int team1Score = 0;
                int team2Score = 0;
                int inning = 1;
                while(inning <= 9 || team1Score == team2Score)
                {
                    team1Score += halfInning(team1Players, ref team1AB);
                    if (inning == 9 && team2Score > team1Score)
                        break;
                    team2Score += halfInning(team2Players, ref team2AB);
                    inning++;
                }
                if (team1Score > team2Score)
                    numGamesWonByTeam1++;
                numInnings += inning;
            }
            return Tuple.Create(numGamesWonByTeam1, numInnings);
        }

        private int halfInning(Player[] players, ref int currAB)
        {
            int runsScored = 0;
            int[] bases = { 0, 0, 0 };
            int numOuts = 0;
            while (numOuts < 3)
            {
                   int numBaseDetermination = rand.Next(1000);
                   if (numBaseDetermination < (int)(players[currAB].walk_percentage * 1000))
                   {
                       if (bases.Sum() == 3)
                       {
                           runsScored++;
                       }
                       else if (bases[0] == 1)
                       {
                           if (bases[1] == 1)
                               bases[2] = 1;
                           bases[1] = 1;
                       }
                       bases[0] = 1;
                   }
                   else if (numBaseDetermination < (int)((players[currAB].single_percentage+players[currAB].walk_percentage) * 1000))
                   {
                       runsScored += (bases[1] + bases[2]);
                       bases[1] = 0;
                       if (bases[0] != 1)
                           bases[2] = 0;
                       bases[0] = 1;
                   }
                   else if (numBaseDetermination < (int)((players[currAB].double_percentage+players[currAB].single_percentage+players[currAB].walk_percentage) * 1000))
                   {
                       runsScored += bases.Sum();
                       Array.Clear(bases, 0, 3);
                       bases[1] = 1;
                   }
                   else if (numBaseDetermination < (int)((players[currAB].triple_percentage+players[currAB].double_percentage + players[currAB].single_percentage + players[currAB].walk_percentage) * 1000))
                   {
                       runsScored += bases.Sum();
                       Array.Clear(bases, 0, 3);
                       bases[2] = 1;
                   }
                   else if (numBaseDetermination < (int)(players[currAB].HR_percentage+ players[currAB].double_percentage + players[currAB].single_percentage + players[currAB].walk_percentage+players[currAB].triple_percentage))
                   {
                       runsScored += bases.Sum() + 1;
                       Array.Clear(bases, 0, 3);
                   }
                   else
                   {
                       numOuts++;
                   }
                   currAB = (currAB + 1) % 9;
            }
            return runsScored;
        }
    }
}

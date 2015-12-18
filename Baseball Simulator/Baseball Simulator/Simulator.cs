using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball_Simulator
{
    class Simulator
    {
        private decimal[] Team1;
        private decimal[] Team2;
        private decimal[] Pitchers;
        private decimal leagueOBP;
        private Random rand;
        public Simulator(decimal[] team1, decimal[] team2, decimal[] pitchers)
        {
            Team1 = team1;
            Team2 = team2;
            Pitchers = pitchers;
            leagueOBP = (Team1.Average() + Team2.Average()) / 2;
            rand = new Random();
        }

        public Tuple<List<int>, List<int>> runGame()
        {
            List<int> team1_scores = new List<int>();
            List<int> team2_scores = new List<int>();
            decimal[] team1_log5 = new decimal[9];
            decimal[] team2_log5 = new decimal[9];
            log5Calculator(ref team1_log5, Team1, Pitchers[1]);
            log5Calculator(ref team2_log5, Team2, Pitchers[0]);
            simulateGame(ref team1_scores, ref team2_scores, team1_log5, team2_log5);
            return Tuple.Create(team1_scores, team2_scores);
        }

        private void log5Calculator(ref decimal[] log5, decimal[] teamOBP, decimal pitcherOBPA)
        {
            for(int i = 0; i < log5.Length; i++)
            {
                log5[i] = (teamOBP[i] * pitcherOBPA / leagueOBP) / ((teamOBP[i] * pitcherOBPA / leagueOBP) + ((1 - teamOBP[i])*(1 - pitcherOBPA) / (1 - leagueOBP)));
            }
        }

        private void simulateGame(ref List<int> team1_scores, ref List<int> team2_scores, decimal[] team1_log5, decimal[] team2_log5)
        {
            int inning = 1;
            int currTeam1AB = 0;
            int currTeam2AB = 0;
            while (inning <= 9 || (team1_scores.Sum() == team2_scores.Sum()))
            {
                team1_scores.Add(halfInning(ref currTeam1AB, team1_log5));
                if (inning == 9 && team2_scores.Sum() > team1_scores.Sum())
                    break;
                team2_scores.Add(halfInning(ref currTeam2AB, team2_log5));
                inning++;
            }
        }

        private int halfInning(ref int currBatter, decimal[] log5)
        {
            int[] current_base = { 0, 0, 0 };
            int tmInningScore = 0;
            int numOuts = 0;
            while (numOuts < 3)
            {
                decimal compare = (decimal)rand.NextDouble();
                if (compare.CompareTo(log5[currBatter]) >= 0)
                    numOuts++;
                else
                {
                    int hitType = (int)(rand.NextDouble() * 10);
                    if (hitType >= 0 && hitType <= 5)
                    {
                        tmInningScore += current_base[1];
                        current_base[1] = 0;
                        tmInningScore += current_base[2];
                        current_base[2] = 0;
                        if (current_base[0] == 1)
                            current_base[2] = 1;
                        current_base[0] = 1;
                    }
                    else if (hitType == 6 || hitType == 7)
                    {
                        tmInningScore += current_base.Sum();
                        for (int i = 0; i <= 2; i++)
                            current_base[i] = 0;
                        current_base[1] = 1;
                    }
                    else if (hitType == 8)
                    {
                        tmInningScore += current_base.Sum();
                        for (int i = 0; i <= 2; i++)
                            current_base[i] = 0;
                        current_base[2] = 1;
                    }
                    else
                    {
                        tmInningScore += current_base.Sum() + 1;
                        for (int i = 0; i <= 2; i++)
                            current_base[i] = 0;
                    }
                }
                currBatter++;
                currBatter %= 9;
            }
            return tmInningScore;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baseball_Simulator
{
    public partial class Home_Page : Form
    {
        private Player[] team1Players;
        private Player[] team2Players;
        private Player team1Pitcher;
        private Player team2Pitcher;
        public Home_Page()
        {
            InitializeComponent();
            team1Pitcher = new Player();
            team2Pitcher = new Player();
            team1Players = new Player[9];
            team2Players = new Player[9];
            for (int i = 0; i < 9; i++)
            {
                team1Players[i] = new Player();
                team2Players[i] = new Player();
            }
        }

        private void team1Player1_Click(object sender, EventArgs e)
        {
            team1Players[0].ShowDialog();
            team1Player1.Text = team1Players[0].name;
        }

        private void team1Player2_Click(object sender, EventArgs e)
        {
            team1Players[1].ShowDialog();
            team1Player2.Text = team1Players[1].name;
        }

        private void team1Player3_Click(object sender, EventArgs e)
        {
            team1Players[2].ShowDialog();
            team1Player3.Text = team1Players[2].name;
        }

        private void team1Player4_Click(object sender, EventArgs e)
        {
            team1Players[3].ShowDialog();
            team1Player4.Text = team1Players[3].name;
        }

        private void team1Player5_Click(object sender, EventArgs e)
        {
            team1Players[4].ShowDialog();
            team1Player5.Text = team1Players[4].name;
        }

        private void team1Player6_Click(object sender, EventArgs e)
        {
            team1Players[5].ShowDialog();
            team1Player6.Text = team1Players[5].name;
        }

        private void team1Player7_Click(object sender, EventArgs e)
        {
            team1Players[6].ShowDialog();
            team1Player7.Text = team1Players[6].name;
        }

        private void team1Player8_Click(object sender, EventArgs e)
        {
            team1Players[7].ShowDialog();
            team1Player8.Text = team1Players[7].name;
        }

        private void team1Player9_Click(object sender, EventArgs e)
        {
            team1Players[8].ShowDialog();
            team1Player9.Text = team1Players[8].name;
        }

        private void team2Player1_Click(object sender, EventArgs e)
        {
            team2Players[0].ShowDialog();
            team2Player1.Text = team2Players[0].name;
        }

        private void team2Player2_Click(object sender, EventArgs e)
        {
            team2Players[1].ShowDialog();
            team2Player2.Text = team2Players[1].name;
        }

        private void team2Player3_Click(object sender, EventArgs e)
        {
            team2Players[2].ShowDialog();
            team2Player3.Text = team2Players[2].name;
        }

        private void team2Player4_Click(object sender, EventArgs e)
        {
            team2Players[3].ShowDialog();
            team2Player4.Text = team2Players[3].name;
        }

        private void team2Player5_Click(object sender, EventArgs e)
        {
            team2Players[4].ShowDialog();
            team2Player5.Text = team2Players[4].name;
        }

        private void team2Player6_Click(object sender, EventArgs e)
        {
            team2Players[5].ShowDialog();
            team2Player6.Text = team2Players[5].name;
        }

        private void team2Player7_Click(object sender, EventArgs e)
        {
            team2Players[6].ShowDialog();
            team2Player7.Text = team2Players[6].name;
        }

        private void team2Player8_Click(object sender, EventArgs e)
        {
            team2Players[7].ShowDialog();
            team2Player8.Text = team2Players[7].name;
        }

        private void team2Player9_Click(object sender, EventArgs e)
        {
            team2Players[8].ShowDialog();
            team2Player9.Text = team2Players[8].name;
        }

        private void team1PitcherButton_Click(object sender, EventArgs e)
        {
            team1Pitcher.ShowDialog();
            team1PitcherButton.Text = team1Pitcher.name;
        }

        private void team2PitcherButton_Click(object sender, EventArgs e)
        {
            team2Pitcher.ShowDialog();
            team2PitcherButton.Text = team2Pitcher.name;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!checkIfAllPlayersSet())
            {
                MessageBox.Show("Error: Not every player has been set!", "Error");
                return;
            }
            Simulator game = new Simulator(deepCopyArray(team1Players), deepCopyArray(team2Players), team1Pitcher, team2Pitcher);
            Tuple<int, int> result = game.simulateGames((int)numGamesToSimulate.Value);
            MessageBox.Show("Team 1 won " + result.Item1 + " games!  Average innings per game was " + result.Item2/(int)numGamesToSimulate.Value);
        }

        private Player[] deepCopyArray(Player[] toBeCopied)
        {
            Player[] clonedArray = new Player[toBeCopied.Length];
            for(int i = 0; i < toBeCopied.Length; i++)
            {
                clonedArray[i] = new Player();
                clonedArray[i].name = toBeCopied[i].name;
                clonedArray[i].walk_percentage = toBeCopied[i].walk_percentage;
                clonedArray[i].single_percentage = toBeCopied[i].single_percentage;
                clonedArray[i].double_percentage = toBeCopied[i].double_percentage;
                clonedArray[i].triple_percentage = toBeCopied[i].triple_percentage;
                clonedArray[i].HR_percentage = toBeCopied[i].HR_percentage;
            }
            return clonedArray;
        }
        private bool checkIfAllPlayersSet()
        {
            if (!team1Pitcher.set || !team2Pitcher.set)
                return false;
            for(int i = 0; i < team1Players.Length; i++)
            {
                if (!team1Players[i].set || !team2Players[i].set)
                    return false;
            }
            return true;
        }
    }
}

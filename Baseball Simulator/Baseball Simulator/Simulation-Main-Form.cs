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
            for(int i = 0; i < 9; i++)
            {
                team1Players[i] = new Player();
                team2Players[i] = new Player();
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
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
            Simulator game = new Simulator(team1Players, team2Players, team1Pitcher, team2Pitcher);
            int numGamesWonByTeam1 = game.simulateGames(10);
            MessageBox.Show("Team 1 won " + numGamesWonByTeam1 + "% of their games!", "Results");
        }
    }
}

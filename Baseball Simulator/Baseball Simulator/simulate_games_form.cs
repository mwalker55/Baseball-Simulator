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
    public partial class simulate_page : Form
    {
        private Form homePage;
        private teamMakerForm awayTeam, homeTeam;
        public simulate_page(Form HomePage)
        {
            awayTeam = new teamMakerForm();
            homeTeam = new teamMakerForm();
            homePage = HomePage;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(!awayTeam.teamSet || !homeTeam.teamSet)
            {
                MessageBox.Show("One of the teams has not been set!", "Error");
                return;
            }
            Simulator game = new Simulator(deepCopyArray(awayTeam.myTeam.playerList), deepCopyArray(homeTeam.myTeam.playerList), awayTeam.myTeam.startingPitcher, homeTeam.myTeam.startingPitcher);
            Tuple<int, int> result = game.simulateGames((int)numGamesToSimulate.Value);
            MessageBox.Show("Away team won " + result.Item1 + " games!  Average innings per game was " + result.Item2/(int)numGamesToSimulate.Value);
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

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homePage.Visible = true;
        }

        private void createHomeTeam_Click(object sender, EventArgs e)
        {
            homeTeam.ShowDialog();
            if (homeTeam.teamSet)
                createHomeTeam.Text = "Edit Team";
        }

        private void homeTeamClearButton_Click(object sender, EventArgs e)
        {
            teamMakerForm temp = homeTeam;
            homeTeam = new teamMakerForm();
            createHomeTeam.Text = "Create Team";
        }

        private void awayTeamClearButton_Click(object sender, EventArgs e)
        {
            teamMakerForm temp = awayTeam;
            awayTeam = new teamMakerForm();
            createAwayTeam.Text = "Create Team";
        }

        private void createAwayTeam_Click(object sender, EventArgs e)
        {
            awayTeam.ShowDialog();
            if (awayTeam.teamSet)
                createAwayTeam.Text = "Edit Team";
        }
    }
}

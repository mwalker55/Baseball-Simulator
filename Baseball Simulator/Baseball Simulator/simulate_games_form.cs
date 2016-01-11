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
        private teamMakerForm awayTeamForm, homeTeamForm;
        private Team awayTeam, homeTeam;
        public simulate_page(Form HomePage)
        {
            awayTeamForm = new teamMakerForm();
            homeTeamForm = new teamMakerForm();
            awayTeam = null;
            homeTeam = null;
            homePage = HomePage;
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(awayTeam == null || homeTeam == null)
            {
                MessageBox.Show("One of the teams has not been set!", "Error");
                return;
            }
            Simulator game = new Simulator(awayTeam.playerList, homeTeam.playerList, awayTeam.startingPitcher, homeTeam.startingPitcher, awayTeam.closer, homeTeam.closer);
            Tuple<int, int> result = game.simulateGames((int)numGamesToSimulate.Value);
            MessageBox.Show("Away team won " + result.Item1 + " games!  Average innings per game was " + result.Item2/(int)numGamesToSimulate.Value);
        }

        private void home_button_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            homePage.Visible = true;
        }

        private void createHomeTeam_Click(object sender, EventArgs e)
        {
            homeTeamForm.ShowDialog();
            homeTeam = homeTeamForm.getTeam();
            if (homeTeam != null)
                createHomeTeam.Text = "Edit " + homeTeam.teamName;
        }

        private void homeTeamClearButton_Click(object sender, EventArgs e)
        {
            teamMakerForm temp = homeTeamForm;
            homeTeamForm = new teamMakerForm();
            createHomeTeam.Text = "Create Team";
            homeTeam = null;
        }

        private void awayTeamClearButton_Click(object sender, EventArgs e)
        {
            teamMakerForm temp = awayTeamForm;
            awayTeamForm = new teamMakerForm();
            createAwayTeam.Text = "Create Team";
            awayTeam = null;
        }

        private void createAwayTeam_Click(object sender, EventArgs e)
        {
            awayTeamForm.ShowDialog();
            awayTeam = awayTeamForm.getTeam();
            if (awayTeam != null)
                createAwayTeam.Text = "Edit " + awayTeam.teamName;
        }
    }
}

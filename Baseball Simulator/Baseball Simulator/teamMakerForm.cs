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
    public partial class teamMakerForm : Form
    {
        public Team myTeam { get; }
        public bool teamSet;
        public teamMakerForm()
        {
            InitializeComponent();
            myTeam = new Team();
            teamSet = false;
        }

        private void player1Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[0].ShowDialog();
            player1Button.Text = myTeam.playerList[0].name;
        }

        private void player2Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[1].ShowDialog();
            player2Button.Text = myTeam.playerList[1].name;
        }

        private void player3Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[2].ShowDialog();
            player3Button.Text = myTeam.playerList[2].name;
        }

        private void player4Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[3].ShowDialog();
            player4Button.Text = myTeam.playerList[3].name;
        }

        private void player5Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[4].ShowDialog();
            player5Button.Text = myTeam.playerList[4].name;
        }

        private void player6Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[5].ShowDialog();
            player6Button.Text = myTeam.playerList[5].name;
        }

        private void player7Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[6].ShowDialog();
            player7Button.Text = myTeam.playerList[6].name;
        }

        private void player8Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[7].ShowDialog();
            player8Button.Text = myTeam.playerList[7].name;
        }

        private void player9Button_Click(object sender, EventArgs e)
        {
            myTeam.playerList[8].ShowDialog();
            player9Button.Text = myTeam.playerList[8].name;
        }

        private void pitcherButton_Click(object sender, EventArgs e)
        {
            myTeam.startingPitcher.ShowDialog();
            pitcherButton.Text = myTeam.startingPitcher.name;
        }

        private void setTeamButton_Click(object sender, EventArgs e)
        {
            if(!myTeam.startingPitcher.setFlag)
            {
                MessageBox.Show("Not every player has been set!", "Error");
                return;
            }
            foreach(Player thisPlayer in myTeam.playerList)
            {
                if(!thisPlayer.setFlag)
                {
                    MessageBox.Show("Not every player has been set!", "Error");
                    return;
                }
            }
            MessageBox.Show("Team successfully set!", "Complete");
            teamSet = true;
            this.Close();
        }
    }
}

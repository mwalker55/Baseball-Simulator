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
    public partial class main_page : Form
    {
        private Form games_simulator;
        public main_page()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }


        // open up Simulate Games form
        private void simulate_games_button_Click(object sender, EventArgs e)
        {
            // if a Simulate Games form does not already exist, make a new one
            if(games_simulator == null)
                games_simulator = new simulate_page(this);
            // make the Simulate Games form visible
            games_simulator.Visible = true;
            // Hide the main menu rather than delete it - makes it faster to return to
            this.Visible = false;
        }
    }
}

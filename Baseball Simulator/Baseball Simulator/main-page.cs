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

        private void simulate_games_button_Click(object sender, EventArgs e)
        {
            if(games_simulator == null)
                games_simulator = new simulate_page(this);
            games_simulator.Visible = true;
            this.Visible = false;
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal[] team1_hitters = { numericUpDown1.Value, numericUpDown2.Value, numericUpDown3.Value, numericUpDown4.Value, numericUpDown5.Value, numericUpDown6.Value,
                numericUpDown7.Value, numericUpDown8.Value, numericUpDown9.Value };
            decimal[] team2_hitters = { numericUpDown20.Value, numericUpDown19.Value, numericUpDown18.Value, numericUpDown17.Value, numericUpDown16.Value,
                numericUpDown15.Value, numericUpDown14.Value, numericUpDown13.Value, numericUpDown12.Value };
            decimal[] pitchersOBPA = { numericUpDown10.Value, numericUpDown11.Value };
            Simulator simulation = new Simulator(team1_hitters, team2_hitters, pitchersOBPA);
            Tuple<List<int>, List<int>> collection = simulation.runGame();
            textBox1.Text = "" + collection.Item1.Sum();
            textBox2.Text = "" + collection.Item2.Sum();
        }
    }
}

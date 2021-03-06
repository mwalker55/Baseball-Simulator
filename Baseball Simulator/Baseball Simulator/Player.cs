﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: SEPARATE THE ACTUAL PLAYER CLASS FROM THIS FORM

namespace Baseball_Simulator
{
    public partial class Player : Form
    {
        // Various statistics for player
        #region Declarations
        public decimal walk_percentage { get; set; }
        public decimal single_percentage { get; set; }
        public decimal double_percentage { get; set; }
        public decimal triple_percentage { get; set; }
        public decimal HR_percentage { get; set; }
        public decimal OBP { get; set; }
        public string name { get; set;  }
        // USED TO INDICATE IF PLAYER'S VALUES ARE INITIALIZED OR NOT FOR CHECK
        public bool setFlag { get; set; }
        #endregion
        public Player()
        {
            InitializeComponent();
            OBP = 0;
            setFlag = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = name_of_player.Text;
            walk_percentage = BBPerc.Value;
            single_percentage = singlePerc.Value;
            double_percentage = doublePerc.Value;
            triple_percentage = triplePerc.Value;
            HR_percentage = HRPerc.Value;
            if((walk_percentage+single_percentage+double_percentage+triple_percentage+HR_percentage) > 1)
            {
                MessageBox.Show("Note: Percentages cannot add to above 1.  Please fix your values.", "Error");
            }
            else
            {
                setFlag = true;
                this.Close();
            }
        }
    }
}

using System.Windows.Forms;

namespace Baseball_Simulator
{
    partial class main_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exit_button = new System.Windows.Forms.Button();
            this.simulate_games_button = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(136, 446);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(176, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // simulate_games_button
            // 
            this.simulate_games_button.Location = new System.Drawing.Point(136, 267);
            this.simulate_games_button.Name = "simulate_games_button";
            this.simulate_games_button.Size = new System.Drawing.Size(176, 23);
            this.simulate_games_button.TabIndex = 2;
            this.simulate_games_button.Text = "Simulate Games";
            this.simulate_games_button.UseVisualStyleBackColor = true;
            this.simulate_games_button.Click += new System.EventHandler(this.simulate_games_button_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(98, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(259, 246);
            this.title.TabIndex = 3;
            this.title.Text = "Mark\'s\nBaseball\nSimulator\n2016";
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 514);
            this.Controls.Add(this.title);
            this.Controls.Add(this.simulate_games_button);
            this.Controls.Add(this.exit_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_page";
            this.Text = "Mark\'s Baseball Simulator 2016";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button simulate_games_button;
        private Label title;
    }
}
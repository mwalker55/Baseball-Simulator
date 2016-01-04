namespace Baseball_Simulator
{
    partial class simulate_page
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numGamesToSimulate = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.home_button = new System.Windows.Forms.Button();
            this.createAwayTeam = new System.Windows.Forms.Button();
            this.createHomeTeam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numGamesToSimulate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Away";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "Run!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // numGamesToSimulate
            // 
            this.numGamesToSimulate.Location = new System.Drawing.Point(267, 139);
            this.numGamesToSimulate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGamesToSimulate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGamesToSimulate.Name = "numGamesToSimulate";
            this.numGamesToSimulate.Size = new System.Drawing.Size(75, 21);
            this.numGamesToSimulate.TabIndex = 103;
            this.numGamesToSimulate.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 15);
            this.label3.TabIndex = 104;
            this.label3.Text = "Number of Games to Simulate";
            // 
            // home_button
            // 
            this.home_button.Location = new System.Drawing.Point(528, 166);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(75, 23);
            this.home_button.TabIndex = 105;
            this.home_button.Text = "Home";
            this.home_button.UseVisualStyleBackColor = true;
            this.home_button.Click += new System.EventHandler(this.home_button_Click);
            // 
            // createAwayTeam
            // 
            this.createAwayTeam.Location = new System.Drawing.Point(12, 81);
            this.createAwayTeam.Name = "createAwayTeam";
            this.createAwayTeam.Size = new System.Drawing.Size(140, 23);
            this.createAwayTeam.TabIndex = 106;
            this.createAwayTeam.Text = "Create Team";
            this.createAwayTeam.UseVisualStyleBackColor = true;
            this.createAwayTeam.Click += new System.EventHandler(this.createAwayTeam_Click);
            // 
            // createHomeTeam
            // 
            this.createHomeTeam.Location = new System.Drawing.Point(463, 81);
            this.createHomeTeam.Name = "createHomeTeam";
            this.createHomeTeam.Size = new System.Drawing.Size(140, 23);
            this.createHomeTeam.TabIndex = 107;
            this.createHomeTeam.Text = "Create Team";
            this.createHomeTeam.UseVisualStyleBackColor = true;
            this.createHomeTeam.Click += new System.EventHandler(this.createHomeTeam_Click);
            // 
            // simulate_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 197);
            this.ControlBox = false;
            this.Controls.Add(this.createHomeTeam);
            this.Controls.Add(this.createAwayTeam);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numGamesToSimulate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "simulate_page";
            this.Text = "Simulate Games";
            ((System.ComponentModel.ISupportInitialize)(this.numGamesToSimulate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numGamesToSimulate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button home_button;
        private System.Windows.Forms.Button createAwayTeam;
        private System.Windows.Forms.Button createHomeTeam;
    }
}


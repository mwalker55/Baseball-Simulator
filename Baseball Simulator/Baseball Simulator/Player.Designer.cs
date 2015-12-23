namespace Baseball_Simulator
{
    partial class Player
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BBPerc = new System.Windows.Forms.NumericUpDown();
            this.singlePerc = new System.Windows.Forms.NumericUpDown();
            this.doublePerc = new System.Windows.Forms.NumericUpDown();
            this.triplePerc = new System.Windows.Forms.NumericUpDown();
            this.HRPerc = new System.Windows.Forms.NumericUpDown();
            this.name_of_player = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BBPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlePerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doublePerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.triplePerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRPerc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "BB%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "1B%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "2B%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(282, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "3B%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "HR%";
            // 
            // BBPerc
            // 
            this.BBPerc.DecimalPlaces = 3;
            this.BBPerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.BBPerc.Location = new System.Drawing.Point(51, 71);
            this.BBPerc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BBPerc.Name = "BBPerc";
            this.BBPerc.Size = new System.Drawing.Size(50, 20);
            this.BBPerc.TabIndex = 5;
            this.BBPerc.Value = new decimal(new int[] {
            155,
            0,
            0,
            196608});
            // 
            // singlePerc
            // 
            this.singlePerc.DecimalPlaces = 3;
            this.singlePerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.singlePerc.Location = new System.Drawing.Point(121, 71);
            this.singlePerc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.singlePerc.Name = "singlePerc";
            this.singlePerc.Size = new System.Drawing.Size(50, 20);
            this.singlePerc.TabIndex = 6;
            this.singlePerc.Value = new decimal(new int[] {
            136,
            0,
            0,
            196608});
            // 
            // doublePerc
            // 
            this.doublePerc.DecimalPlaces = 3;
            this.doublePerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.doublePerc.Location = new System.Drawing.Point(189, 71);
            this.doublePerc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.doublePerc.Name = "doublePerc";
            this.doublePerc.Size = new System.Drawing.Size(50, 20);
            this.doublePerc.TabIndex = 7;
            this.doublePerc.Value = new decimal(new int[] {
            47,
            0,
            0,
            196608});
            // 
            // triplePerc
            // 
            this.triplePerc.DecimalPlaces = 3;
            this.triplePerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.triplePerc.Location = new System.Drawing.Point(268, 71);
            this.triplePerc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.triplePerc.Name = "triplePerc";
            this.triplePerc.Size = new System.Drawing.Size(50, 20);
            this.triplePerc.TabIndex = 8;
            this.triplePerc.Value = new decimal(new int[] {
            9,
            0,
            0,
            196608});
            // 
            // HRPerc
            // 
            this.HRPerc.DecimalPlaces = 3;
            this.HRPerc.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.HRPerc.Location = new System.Drawing.Point(338, 71);
            this.HRPerc.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HRPerc.Name = "HRPerc";
            this.HRPerc.Size = new System.Drawing.Size(50, 20);
            this.HRPerc.TabIndex = 9;
            this.HRPerc.Value = new decimal(new int[] {
            6,
            0,
            0,
            131072});
            // 
            // name_of_player
            // 
            this.name_of_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_player.Location = new System.Drawing.Point(92, 12);
            this.name_of_player.Name = "name_of_player";
            this.name_of_player.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_of_player.Size = new System.Drawing.Size(258, 24);
            this.name_of_player.TabIndex = 10;
            this.name_of_player.Text = "Player Name";
            this.name_of_player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 147);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name_of_player);
            this.Controls.Add(this.HRPerc);
            this.Controls.Add(this.triplePerc);
            this.Controls.Add(this.doublePerc);
            this.Controls.Add(this.singlePerc);
            this.Controls.Add(this.BBPerc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Player";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.BBPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singlePerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doublePerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.triplePerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HRPerc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BBPerc;
        private System.Windows.Forms.NumericUpDown singlePerc;
        private System.Windows.Forms.NumericUpDown doublePerc;
        private System.Windows.Forms.NumericUpDown triplePerc;
        private System.Windows.Forms.NumericUpDown HRPerc;
        private System.Windows.Forms.TextBox name_of_player;
        private System.Windows.Forms.Button button1;
    }
}
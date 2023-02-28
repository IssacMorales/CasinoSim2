namespace CasinoSim
{
    partial class Craps
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
            this.PL = new System.Windows.Forms.Button();
            this.DPL = new System.Windows.Forms.Button();
            this.lblRoll = new System.Windows.Forms.Label();
            this.CB = new System.Windows.Forms.Button();
            this.DCB = new System.Windows.Forms.Button();
            this.Points = new System.Windows.Forms.Label();
            this.OddsBTN = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PL
            // 
            this.PL.Location = new System.Drawing.Point(574, 463);
            this.PL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(149, 38);
            this.PL.TabIndex = 0;
            this.PL.Text = "Pass Line";
            this.PL.UseVisualStyleBackColor = true;
            this.PL.Click += new System.EventHandler(this.PL_Click);
            // 
            // DPL
            // 
            this.DPL.Location = new System.Drawing.Point(574, 540);
            this.DPL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DPL.Name = "DPL";
            this.DPL.Size = new System.Drawing.Size(149, 38);
            this.DPL.TabIndex = 1;
            this.DPL.Text = "Don\'t Pass Line";
            this.DPL.UseVisualStyleBackColor = true;
            this.DPL.Click += new System.EventHandler(this.DPL_Click);
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(461, 158);
            this.lblRoll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(77, 25);
            this.lblRoll.TabIndex = 2;
            this.lblRoll.Text = "Number";
            // 
            // CB
            // 
            this.CB.Enabled = false;
            this.CB.Location = new System.Drawing.Point(757, 463);
            this.CB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(149, 38);
            this.CB.TabIndex = 3;
            this.CB.Text = "Come Bet";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // DCB
            // 
            this.DCB.Enabled = false;
            this.DCB.Location = new System.Drawing.Point(757, 540);
            this.DCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DCB.Name = "DCB";
            this.DCB.Size = new System.Drawing.Size(149, 38);
            this.DCB.TabIndex = 4;
            this.DCB.Text = "Don\'t Come Bet";
            this.DCB.UseVisualStyleBackColor = true;
            this.DCB.Click += new System.EventHandler(this.DCB_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(87, 87);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(69, 25);
            this.Points.TabIndex = 5;
            this.Points.Text = "Points: ";
            this.Points.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OddsBTN
            // 
            this.OddsBTN.Enabled = false;
            this.OddsBTN.Location = new System.Drawing.Point(427, 540);
            this.OddsBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OddsBTN.Name = "OddsBTN";
            this.OddsBTN.Size = new System.Drawing.Size(107, 38);
            this.OddsBTN.TabIndex = 6;
            this.OddsBTN.Text = "Odds";
            this.OddsBTN.UseVisualStyleBackColor = true;
            this.OddsBTN.Click += new System.EventHandler(this.OddsBTN_Click);
            // 
            // pb
            // 
            this.pb.Enabled = false;
            this.pb.Location = new System.Drawing.Point(431, 463);
            this.pb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(107, 38);
            this.pb.TabIndex = 7;
            this.pb.Text = "Place Bet";
            this.pb.UseVisualStyleBackColor = true;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.OddsBTN);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.DCB);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.DPL);
            this.Controls.Add(this.PL);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Craps";
            this.Text = "Craps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button PL;
        private Button DPL;
        private Label lblRoll;
        private Button CB;
        private Button DCB;
        private Label Points;
        private Button OddsBTN;
        private Button pb;
    }
}
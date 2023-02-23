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
            this.SuspendLayout();
            // 
            // PL
            // 
            this.PL.Location = new System.Drawing.Point(402, 278);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(104, 23);
            this.PL.TabIndex = 0;
            this.PL.Text = "Pass Line";
            this.PL.UseVisualStyleBackColor = true;
            this.PL.Click += new System.EventHandler(this.PL_Click);
            // 
            // DPL
            // 
            this.DPL.Location = new System.Drawing.Point(402, 324);
            this.DPL.Name = "DPL";
            this.DPL.Size = new System.Drawing.Size(104, 23);
            this.DPL.TabIndex = 1;
            this.DPL.Text = "Don\'t Pass Line";
            this.DPL.UseVisualStyleBackColor = true;
            this.DPL.Click += new System.EventHandler(this.DPL_Click);
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Location = new System.Drawing.Point(323, 95);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(51, 15);
            this.lblRoll.TabIndex = 2;
            this.lblRoll.Text = "Number";
            // 
            // CB
            // 
            this.CB.Enabled = false;
            this.CB.Location = new System.Drawing.Point(530, 278);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(104, 23);
            this.CB.TabIndex = 3;
            this.CB.Text = "Come Bet";
            this.CB.UseVisualStyleBackColor = true;
            this.CB.Click += new System.EventHandler(this.CB_Click);
            // 
            // DCB
            // 
            this.DCB.Enabled = false;
            this.DCB.Location = new System.Drawing.Point(530, 324);
            this.DCB.Name = "DCB";
            this.DCB.Size = new System.Drawing.Size(104, 23);
            this.DCB.TabIndex = 4;
            this.DCB.Text = "Don\'t Come Bet";
            this.DCB.UseVisualStyleBackColor = true;
            this.DCB.Click += new System.EventHandler(this.DCB_Click);
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Location = new System.Drawing.Point(61, 52);
            this.Points.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(46, 15);
            this.Points.TabIndex = 5;
            this.Points.Text = "Points: ";
            this.Points.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OddsBTN
            // 
            this.OddsBTN.Location = new System.Drawing.Point(299, 324);
            this.OddsBTN.Name = "OddsBTN";
            this.OddsBTN.Size = new System.Drawing.Size(75, 23);
            this.OddsBTN.TabIndex = 6;
            this.OddsBTN.Text = "Odds";
            this.OddsBTN.UseVisualStyleBackColor = true;
            this.OddsBTN.Click += new System.EventHandler(this.OddsBTN_Click);
            // 
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OddsBTN);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.DCB);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.DPL);
            this.Controls.Add(this.PL);
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
    }
}
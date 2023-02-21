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
            // Craps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
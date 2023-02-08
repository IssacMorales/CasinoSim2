namespace CasinoSim
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Crapsbtn = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.bJackbtn = new System.Windows.Forms.Button();
            this.Roulettebtn = new System.Windows.Forms.Button();
            this.Slotbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Crapsbtn
            // 
            this.Crapsbtn.Location = new System.Drawing.Point(127, 377);
            this.Crapsbtn.Name = "Crapsbtn";
            this.Crapsbtn.Size = new System.Drawing.Size(264, 76);
            this.Crapsbtn.TabIndex = 0;
            this.Crapsbtn.Text = "Craps (coming soon)";
            this.Crapsbtn.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(407, 54);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(416, 54);
            this.Title.TabIndex = 1;
            this.Title.Text = "Casino-Man Simulator";
            // 
            // bJackbtn
            // 
            this.bJackbtn.Location = new System.Drawing.Point(864, 377);
            this.bJackbtn.Name = "bJackbtn";
            this.bJackbtn.Size = new System.Drawing.Size(264, 76);
            this.bJackbtn.TabIndex = 2;
            this.bJackbtn.Text = "black Jack (coming soon)";
            this.bJackbtn.UseVisualStyleBackColor = true;
            // 
            // Roulettebtn
            // 
            this.Roulettebtn.Location = new System.Drawing.Point(127, 511);
            this.Roulettebtn.Name = "Roulettebtn";
            this.Roulettebtn.Size = new System.Drawing.Size(264, 76);
            this.Roulettebtn.TabIndex = 3;
            this.Roulettebtn.Text = "Roulette (coming soon)";
            this.Roulettebtn.UseVisualStyleBackColor = true;
            // 
            // Slotbtn
            // 
            this.Slotbtn.Location = new System.Drawing.Point(864, 511);
            this.Slotbtn.Name = "Slotbtn";
            this.Slotbtn.Size = new System.Drawing.Size(264, 76);
            this.Slotbtn.TabIndex = 4;
            this.Slotbtn.Text = "Slots (coming soon)";
            this.Slotbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 652);
            this.Controls.Add(this.Slotbtn);
            this.Controls.Add(this.Roulettebtn);
            this.Controls.Add(this.bJackbtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Crapsbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Crapsbtn;
        private Label Title;
        private Button bJackbtn;
        private Button Roulettebtn;
        private Button Slotbtn;
    }
}
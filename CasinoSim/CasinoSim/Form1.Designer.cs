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
            this.money = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pokerbtn = new System.Windows.Forms.Button();
            this.Creditbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Crapsbtn
            // 
            this.Crapsbtn.Location = new System.Drawing.Point(125, 324);
            this.Crapsbtn.Name = "Crapsbtn";
            this.Crapsbtn.Size = new System.Drawing.Size(264, 76);
            this.Crapsbtn.TabIndex = 0;
            this.Crapsbtn.Text = "Craps (coming soon)";
            this.Crapsbtn.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(310, 44);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(626, 81);
            this.Title.TabIndex = 1;
            this.Title.Text = "Casino-Man Simulator";
            // 
            // bJackbtn
            // 
            this.bJackbtn.Location = new System.Drawing.Point(862, 324);
            this.bJackbtn.Name = "bJackbtn";
            this.bJackbtn.Size = new System.Drawing.Size(264, 76);
            this.bJackbtn.TabIndex = 2;
            this.bJackbtn.Text = "Black Jack (coming soon)";
            this.bJackbtn.UseVisualStyleBackColor = true;
            // 
            // Roulettebtn
            // 
            this.Roulettebtn.Location = new System.Drawing.Point(125, 458);
            this.Roulettebtn.Name = "Roulettebtn";
            this.Roulettebtn.Size = new System.Drawing.Size(264, 76);
            this.Roulettebtn.TabIndex = 3;
            this.Roulettebtn.Text = "Roulette (coming soon)";
            this.Roulettebtn.UseVisualStyleBackColor = true;
            this.Roulettebtn.Click += new System.EventHandler(this.Roulettebtn_Click);
            // 
            // Slotbtn
            // 
            this.Slotbtn.Location = new System.Drawing.Point(862, 458);
            this.Slotbtn.Name = "Slotbtn";
            this.Slotbtn.Size = new System.Drawing.Size(264, 76);
            this.Slotbtn.TabIndex = 4;
            this.Slotbtn.Text = "Slots (coming soon)";
            this.Slotbtn.UseVisualStyleBackColor = true;
            this.Slotbtn.Click += new System.EventHandler(this.Slotbtn_Click);
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.money.Location = new System.Drawing.Point(713, 196);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(34, 41);
            this.money.TabIndex = 8;
            this.money.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(453, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Money Available: $";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Pokerbtn
            // 
            this.Pokerbtn.Location = new System.Drawing.Point(494, 397);
            this.Pokerbtn.Name = "Pokerbtn";
            this.Pokerbtn.Size = new System.Drawing.Size(264, 76);
            this.Pokerbtn.TabIndex = 9;
            this.Pokerbtn.Text = "Poker (coming soon)";
            this.Pokerbtn.UseVisualStyleBackColor = true;
            // 
            // Creditbtn
            // 
            this.Creditbtn.Location = new System.Drawing.Point(1115, 606);
            this.Creditbtn.Name = "Creditbtn";
            this.Creditbtn.Size = new System.Drawing.Size(112, 34);
            this.Creditbtn.TabIndex = 10;
            this.Creditbtn.Text = "Credits";
            this.Creditbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 652);
            this.Controls.Add(this.Creditbtn);
            this.Controls.Add(this.Pokerbtn);
            this.Controls.Add(this.money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Slotbtn);
            this.Controls.Add(this.Roulettebtn);
            this.Controls.Add(this.bJackbtn);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Crapsbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Crapsbtn;
        private Label Title;
        private Button bJackbtn;
        private Button Roulettebtn;
        private Button Slotbtn;
        private Label money;
        private Label label1;
        private Button Pokerbtn;
        private Button Creditbtn;
    }
}
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
            Crapsbtn = new Button();
            Title = new Label();
            bJackbtn = new Button();
            Roulettebtn = new Button();
            Slotbtn = new Button();
            money = new Label();
            label1 = new Label();
            Pokerbtn = new Button();
            Creditbtn = new Button();
            SuspendLayout();
            // 
            // Crapsbtn
            // 
            Crapsbtn.Location = new Point(126, 323);
            Crapsbtn.Name = "Crapsbtn";
            Crapsbtn.Size = new Size(264, 77);
            Crapsbtn.TabIndex = 0;
            Crapsbtn.Text = "Craps (coming soon)";
            Crapsbtn.UseVisualStyleBackColor = true;
            Crapsbtn.Click += Crapsbtn_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(310, 43);
            Title.Name = "Title";
            Title.Size = new Size(626, 81);
            Title.TabIndex = 1;
            Title.Text = "Casino-Man Simulator";
            // 
            // bJackbtn
            // 
            bJackbtn.Location = new Point(861, 323);
            bJackbtn.Name = "bJackbtn";
            bJackbtn.Size = new Size(264, 77);
            bJackbtn.TabIndex = 2;
            bJackbtn.Text = "Black Jack (coming soon)";
            bJackbtn.UseVisualStyleBackColor = true;
            bJackbtn.Click += bJackbtn_Click;
            // 
            // Roulettebtn
            // 
            Roulettebtn.Location = new Point(126, 458);
            Roulettebtn.Name = "Roulettebtn";
            Roulettebtn.Size = new Size(264, 77);
            Roulettebtn.TabIndex = 3;
            Roulettebtn.Text = "Roulette (coming soon)";
            Roulettebtn.UseVisualStyleBackColor = true;
            Roulettebtn.Click += Roulettebtn_Click;
            // 
            // Slotbtn
            // 
            Slotbtn.Location = new Point(861, 458);
            Slotbtn.Name = "Slotbtn";
            Slotbtn.Size = new Size(264, 77);
            Slotbtn.TabIndex = 4;
            Slotbtn.Text = "Slots (coming soon)";
            Slotbtn.UseVisualStyleBackColor = true;
            Slotbtn.Click += Slotbtn_Click;
            // 
            // money
            // 
            money.AutoSize = true;
            money.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            money.Location = new Point(713, 197);
            money.Name = "money";
            money.Size = new Size(0, 41);
            money.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(453, 197);
            label1.Name = "label1";
            label1.Size = new Size(267, 41);
            label1.TabIndex = 7;
            label1.Text = "Money Available: $";
            // 
            // Pokerbtn
            // 
            Pokerbtn.Location = new Point(494, 397);
            Pokerbtn.Name = "Pokerbtn";
            Pokerbtn.Size = new Size(264, 77);
            Pokerbtn.TabIndex = 9;
            Pokerbtn.Text = "Poker (coming soon)";
            Pokerbtn.UseVisualStyleBackColor = true;
            // 
            // Creditbtn
            // 
            Creditbtn.Location = new Point(1114, 607);
            Creditbtn.Name = "Creditbtn";
            Creditbtn.Size = new Size(111, 33);
            Creditbtn.TabIndex = 10;
            Creditbtn.Text = "Credits";
            Creditbtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 652);
            Controls.Add(Creditbtn);
            Controls.Add(Pokerbtn);
            Controls.Add(money);
            Controls.Add(label1);
            Controls.Add(Slotbtn);
            Controls.Add(Roulettebtn);
            Controls.Add(bJackbtn);
            Controls.Add(Title);
            Controls.Add(Crapsbtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
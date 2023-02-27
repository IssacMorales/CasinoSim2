namespace CasinoSim
{
    partial class Roulette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roulette));
            pictureBox1 = new PictureBox();
            black = new Button();
            Red = new Button();
            twelve = new Button();
            twenty = new Button();
            thirty = new Button();
            num = new TextBox();
            custom = new Button();
            CB = new Label();
            High = new Button();
            low = new Button();
            BetAmount = new TextBox();
            label1 = new Label();
            WL = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1034, 341);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // black
            // 
            black.Location = new Point(689, 435);
            black.Name = "black";
            black.Size = new Size(112, 34);
            black.TabIndex = 2;
            black.Text = "Black";
            black.UseVisualStyleBackColor = true;
            black.Click += black_Click;
            // 
            // Red
            // 
            Red.Location = new Point(844, 435);
            Red.Name = "Red";
            Red.Size = new Size(112, 34);
            Red.TabIndex = 3;
            Red.Text = "Red";
            Red.UseVisualStyleBackColor = true;
            Red.Click += Red_Click;
            // 
            // twelve
            // 
            twelve.Location = new Point(992, 435);
            twelve.Name = "twelve";
            twelve.Size = new Size(112, 34);
            twelve.TabIndex = 4;
            twelve.Text = "1 - 12";
            twelve.UseVisualStyleBackColor = true;
            twelve.Click += twelve_Click;
            // 
            // twenty
            // 
            twenty.Location = new Point(689, 492);
            twenty.Name = "twenty";
            twenty.Size = new Size(112, 34);
            twenty.TabIndex = 5;
            twenty.Text = "13 - 24";
            twenty.UseVisualStyleBackColor = true;
            twenty.Click += twenty_Click;
            // 
            // thirty
            // 
            thirty.Location = new Point(844, 492);
            thirty.Name = "thirty";
            thirty.Size = new Size(112, 34);
            thirty.TabIndex = 6;
            thirty.Text = "25 - 36";
            thirty.UseVisualStyleBackColor = true;
            thirty.Click += thirty_Click;
            // 
            // num
            // 
            num.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            num.Location = new Point(844, 551);
            num.Name = "num";
            num.Size = new Size(112, 47);
            num.TabIndex = 8;
            num.TextChanged += num_TextChanged;
            // 
            // custom
            // 
            custom.Location = new Point(992, 561);
            custom.Name = "custom";
            custom.Size = new Size(112, 34);
            custom.TabIndex = 9;
            custom.Text = "Single";
            custom.UseVisualStyleBackColor = true;
            custom.Click += custom_Click;
            // 
            // CB
            // 
            CB.AutoSize = true;
            CB.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            CB.Location = new Point(36, 484);
            CB.Name = "CB";
            CB.Size = new Size(176, 41);
            CB.TabIndex = 10;
            CB.Text = "Bet Square: ";
            // 
            // High
            // 
            High.Location = new Point(992, 492);
            High.Name = "High";
            High.Size = new Size(112, 34);
            High.TabIndex = 11;
            High.Text = "High";
            High.UseVisualStyleBackColor = true;
            High.Click += High_Click;
            // 
            // low
            // 
            low.Location = new Point(689, 554);
            low.Name = "low";
            low.Size = new Size(112, 34);
            low.TabIndex = 12;
            low.Text = "Low";
            low.UseVisualStyleBackColor = true;
            low.Click += low_Click;
            // 
            // BetAmount
            // 
            BetAmount.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BetAmount.Location = new Point(233, 554);
            BetAmount.Name = "BetAmount";
            BetAmount.Size = new Size(132, 47);
            BetAmount.TabIndex = 13;
            BetAmount.TextChanged += BetAmount_TextChanged;
            BetAmount.KeyPress += BetAmount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 554);
            label1.Name = "label1";
            label1.Size = new Size(191, 41);
            label1.TabIndex = 14;
            label1.Text = "Bet Amount: ";
            // 
            // WL
            // 
            WL.AutoSize = true;
            WL.Location = new Point(96, 425);
            WL.Name = "WL";
            WL.Size = new Size(0, 25);
            WL.TabIndex = 15;
            // 
            // Roulette
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 642);
            Controls.Add(WL);
            Controls.Add(label1);
            Controls.Add(BetAmount);
            Controls.Add(low);
            Controls.Add(High);
            Controls.Add(CB);
            Controls.Add(custom);
            Controls.Add(num);
            Controls.Add(thirty);
            Controls.Add(twenty);
            Controls.Add(twelve);
            Controls.Add(Red);
            Controls.Add(black);
            Controls.Add(pictureBox1);
            Name = "Roulette";
            Text = "number";
            Load += Roulette_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button black;
        private Button Red;
        private Button twelve;
        private Button twenty;
        private Button thirty;
        private TextBox num;
        private Button custom;
        private Label CB;
        private Button High;
        private Button low;
        private TextBox BetAmount;
        private Label label1;
        private Label WL;
        private Label mny;
    }
}
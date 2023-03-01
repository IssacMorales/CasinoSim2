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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.twelve = new System.Windows.Forms.Button();
            this.twenty = new System.Windows.Forms.Button();
            this.thirty = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.TextBox();
            this.custom = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.Label();
            this.High = new System.Windows.Forms.Button();
            this.low = new System.Windows.Forms.Button();
            this.BetAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WL = new System.Windows.Forms.Label();
            this.cMoney = new System.Windows.Forms.Label();
            this.BACK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 341);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // black
            // 
            this.black.Location = new System.Drawing.Point(689, 435);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(112, 34);
            this.black.TabIndex = 2;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            this.black.Click += new System.EventHandler(this.black_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(844, 435);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(112, 34);
            this.Red.TabIndex = 3;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // twelve
            // 
            this.twelve.Location = new System.Drawing.Point(992, 435);
            this.twelve.Name = "twelve";
            this.twelve.Size = new System.Drawing.Size(112, 34);
            this.twelve.TabIndex = 4;
            this.twelve.Text = "1 - 12";
            this.twelve.UseVisualStyleBackColor = true;
            this.twelve.Click += new System.EventHandler(this.twelve_Click);
            // 
            // twenty
            // 
            this.twenty.Location = new System.Drawing.Point(689, 492);
            this.twenty.Name = "twenty";
            this.twenty.Size = new System.Drawing.Size(112, 34);
            this.twenty.TabIndex = 5;
            this.twenty.Text = "13 - 24";
            this.twenty.UseVisualStyleBackColor = true;
            this.twenty.Click += new System.EventHandler(this.twenty_Click);
            // 
            // thirty
            // 
            this.thirty.Location = new System.Drawing.Point(844, 492);
            this.thirty.Name = "thirty";
            this.thirty.Size = new System.Drawing.Size(112, 34);
            this.thirty.TabIndex = 6;
            this.thirty.Text = "25 - 36";
            this.thirty.UseVisualStyleBackColor = true;
            this.thirty.Click += new System.EventHandler(this.thirty_Click);
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num.Location = new System.Drawing.Point(844, 551);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(112, 47);
            this.num.TabIndex = 8;
            // 
            // custom
            // 
            this.custom.Location = new System.Drawing.Point(992, 561);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(112, 34);
            this.custom.TabIndex = 9;
            this.custom.Text = "Single";
            this.custom.UseVisualStyleBackColor = true;
            this.custom.Click += new System.EventHandler(this.custom_Click);
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB.Location = new System.Drawing.Point(36, 484);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(176, 41);
            this.CB.TabIndex = 10;
            this.CB.Text = "Bet Square: ";
            // 
            // High
            // 
            this.High.Location = new System.Drawing.Point(992, 492);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(112, 34);
            this.High.TabIndex = 11;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            this.High.Click += new System.EventHandler(this.High_Click);
            // 
            // low
            // 
            this.low.Location = new System.Drawing.Point(689, 554);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(112, 34);
            this.low.TabIndex = 12;
            this.low.Text = "Low";
            this.low.UseVisualStyleBackColor = true;
            this.low.Click += new System.EventHandler(this.low_Click);
            // 
            // BetAmount
            // 
            this.BetAmount.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetAmount.Location = new System.Drawing.Point(233, 554);
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(132, 47);
            this.BetAmount.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 41);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bet Amount: ";
            // 
            // WL
            // 
            this.WL.AutoSize = true;
            this.WL.Location = new System.Drawing.Point(96, 425);
            this.WL.Name = "WL";
            this.WL.Size = new System.Drawing.Size(0, 25);
            this.WL.TabIndex = 15;
            // 
            // cMoney
            // 
            this.cMoney.AutoSize = true;
            this.cMoney.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cMoney.Location = new System.Drawing.Point(385, 563);
            this.cMoney.Name = "cMoney";
            this.cMoney.Size = new System.Drawing.Size(101, 32);
            this.cMoney.TabIndex = 16;
            this.cMoney.Text = "Money: ";
            // 
            // BACK
            // 
            this.BACK.Location = new System.Drawing.Point(12, 3);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(73, 45);
            this.BACK.TabIndex = 17;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 642);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.cMoney);
            this.Controls.Add(this.WL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.low);
            this.Controls.Add(this.High);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.num);
            this.Controls.Add(this.thirty);
            this.Controls.Add(this.twenty);
            this.Controls.Add(this.twelve);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.black);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Roulette";
            this.Text = "number";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label cMoney;
        private Button BACK;
    }
}
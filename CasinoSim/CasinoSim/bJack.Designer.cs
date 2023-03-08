namespace CasinoSim
{
    partial class bJack
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
            hitBtn = new Button();
            standBtn = new Button();
            betBtn = new Button();
            DDBtn = new Button();
            splitBtn = new Button();
            cMoney = new Label();
            moneyBox = new TextBox();
            blackjacLlabel = new Label();
            SuspendLayout();
            // 
            // hitBtn
            // 
            hitBtn.Location = new Point(985, 487);
            hitBtn.Name = "hitBtn";
            hitBtn.Size = new Size(112, 34);
            hitBtn.TabIndex = 0;
            hitBtn.Text = "Hit";
            hitBtn.UseVisualStyleBackColor = true;
            hitBtn.Click += hitBtn_Click;
            // 
            // standBtn
            // 
            standBtn.Location = new Point(985, 560);
            standBtn.Name = "standBtn";
            standBtn.Size = new Size(112, 34);
            standBtn.TabIndex = 1;
            standBtn.Text = "Stand";
            standBtn.UseVisualStyleBackColor = true;
            standBtn.Click += standBtn_Click;
            // 
            // betBtn
            // 
            betBtn.Location = new Point(39, 574);
            betBtn.Name = "betBtn";
            betBtn.Size = new Size(112, 34);
            betBtn.TabIndex = 2;
            betBtn.Text = "Bet";
            betBtn.UseVisualStyleBackColor = true;
            betBtn.Click += betBtn_Click;
            // 
            // DDBtn
            // 
            DDBtn.Location = new Point(207, 574);
            DDBtn.Name = "DDBtn";
            DDBtn.Size = new Size(148, 34);
            DDBtn.TabIndex = 3;
            DDBtn.Text = "Dubble Down";
            DDBtn.UseVisualStyleBackColor = true;
            DDBtn.Click += DDBtn_Click;
            // 
            // splitBtn
            // 
            splitBtn.Location = new Point(422, 574);
            splitBtn.Name = "splitBtn";
            splitBtn.Size = new Size(112, 34);
            splitBtn.TabIndex = 4;
            splitBtn.Text = "Split Hand";
            splitBtn.UseVisualStyleBackColor = true;
            splitBtn.Click += splitBtn_Click;
            // 
            // cMoney
            // 
            cMoney.AutoSize = true;
            cMoney.Location = new Point(568, 579);
            cMoney.Name = "cMoney";
            cMoney.Size = new Size(71, 25);
            cMoney.TabIndex = 5;
            cMoney.Text = "Money:";
            // 
            // moneyBox
            // 
            moneyBox.Location = new Point(652, 579);
            moneyBox.Name = "moneyBox";
            moneyBox.Size = new Size(150, 31);
            moneyBox.TabIndex = 6;
            // 
            // blackjacLlabel
            // 
            blackjacLlabel.AutoSize = true;
            blackjacLlabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            blackjacLlabel.Location = new Point(425, 482);
            blackjacLlabel.Name = "blackjacLlabel";
            blackjacLlabel.Size = new Size(0, 54);
            blackjacLlabel.TabIndex = 7;
            // 
            // bJack
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 652);
            Controls.Add(blackjacLlabel);
            Controls.Add(moneyBox);
            Controls.Add(cMoney);
            Controls.Add(splitBtn);
            Controls.Add(DDBtn);
            Controls.Add(betBtn);
            Controls.Add(standBtn);
            Controls.Add(hitBtn);
            Name = "bJack";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button hitBtn;
        private Button standBtn;
        private Button betBtn;
        private Button DDBtn;
        private Button splitBtn;
        private Label cMoney;
        private TextBox moneyBox;
        private Label blackjacLlabel;
    }
}
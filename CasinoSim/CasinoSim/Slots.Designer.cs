namespace CasinoSim
{
    partial class Slots
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Pullbar = new System.Windows.Forms.TrackBar();
            this.BetBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Mons = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pullbar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 138);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(268, 151);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(172, 138);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(471, 151);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(172, 138);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Pullbar
            // 
            this.Pullbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pullbar.BackColor = System.Drawing.Color.Red;
            this.Pullbar.Location = new System.Drawing.Point(685, 12);
            this.Pullbar.Name = "Pullbar";
            this.Pullbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Pullbar.RightToLeftLayout = true;
            this.Pullbar.Size = new System.Drawing.Size(69, 415);
            this.Pullbar.TabIndex = 3;
            this.Pullbar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Pullbar.UseWaitCursor = true;
            this.Pullbar.Value = 10;
            this.Pullbar.Scroll += new System.EventHandler(this.Pullbar_Scroll);
            // 
            // BetBox
            // 
            this.BetBox.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BetBox.Location = new System.Drawing.Point(256, 340);
            this.BetBox.Name = "BetBox";
            this.BetBox.PlaceholderText = "Bet Amount";
            this.BetBox.Size = new System.Drawing.Size(219, 47);
            this.BetBox.TabIndex = 4;
            this.BetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Keypress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "MONEY:";
            // 
            // Mons
            // 
            this.Mons.AutoSize = true;
            this.Mons.Location = new System.Drawing.Point(97, 29);
            this.Mons.Name = "Mons";
            this.Mons.Size = new System.Drawing.Size(0, 25);
            this.Mons.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(39, 388);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(112, 34);
            this.Back.TabIndex = 7;
            this.Back.Text = "Home";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Mons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetBox);
            this.Controls.Add(this.Pullbar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Slots";
            this.Text = "Slots";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pullbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TrackBar Pullbar;
        private TextBox BetBox;
        private Label label1;
        private Label Mons;
        private Button Back;
    }
}
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.black = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.twelve = new System.Windows.Forms.Button();
            this.twenty = new System.Windows.Forms.Button();
            this.thirty = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.custom = new System.Windows.Forms.Button();
            this.CB = new System.Windows.Forms.Label();
            this.High = new System.Windows.Forms.Button();
            this.low = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "This do seem like Roulette";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 341);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // black
            // 
            this.black.Location = new System.Drawing.Point(556, 454);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(112, 34);
            this.black.TabIndex = 2;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(711, 454);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(112, 34);
            this.Red.TabIndex = 3;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = true;
            // 
            // twelve
            // 
            this.twelve.Location = new System.Drawing.Point(556, 510);
            this.twelve.Name = "twelve";
            this.twelve.Size = new System.Drawing.Size(112, 34);
            this.twelve.TabIndex = 4;
            this.twelve.Text = "1 - 12";
            this.twelve.UseVisualStyleBackColor = true;
            // 
            // twenty
            // 
            this.twenty.Location = new System.Drawing.Point(711, 510);
            this.twenty.Name = "twenty";
            this.twenty.Size = new System.Drawing.Size(112, 34);
            this.twenty.TabIndex = 5;
            this.twenty.Text = "13 - 24";
            this.twenty.UseVisualStyleBackColor = true;
            // 
            // thirty
            // 
            this.thirty.Location = new System.Drawing.Point(860, 454);
            this.thirty.Name = "thirty";
            this.thirty.Size = new System.Drawing.Size(112, 34);
            this.thirty.TabIndex = 6;
            this.thirty.Text = "25 - 36";
            this.thirty.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(532, 569);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 47);
            this.textBox1.TabIndex = 8;
            // 
            // custom
            // 
            this.custom.Location = new System.Drawing.Point(710, 567);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(112, 34);
            this.custom.TabIndex = 9;
            this.custom.Text = "Single";
            this.custom.UseVisualStyleBackColor = true;
            // 
            // CB
            // 
            this.CB.AutoSize = true;
            this.CB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CB.Location = new System.Drawing.Point(57, 522);
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(76, 41);
            this.CB.TabIndex = 10;
            this.CB.Text = "Bet: ";
            // 
            // High
            // 
            this.High.Location = new System.Drawing.Point(860, 510);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(112, 34);
            this.High.TabIndex = 11;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            // 
            // low
            // 
            this.low.Location = new System.Drawing.Point(859, 567);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(112, 34);
            this.low.TabIndex = 12;
            this.low.Text = "Low";
            this.low.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 501);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 13;
            // 
            // Roulette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 642);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.low);
            this.Controls.Add(this.High);
            this.Controls.Add(this.CB);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.thirty);
            this.Controls.Add(this.twenty);
            this.Controls.Add(this.twelve);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.black);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Roulette";
            this.Text = "Roulette";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button black;
        private Button Red;
        private Button twelve;
        private Button twenty;
        private Button thirty;
        private TextBox textBox1;
        private Button custom;
        private Label CB;
        private Button High;
        private Button low;
        private TextBox textBox2;
    }
}
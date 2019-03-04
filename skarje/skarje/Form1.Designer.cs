namespace skarje
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.scoreLabel1 = new System.Windows.Forms.Label();
            this.scoreLabel2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.highScoreLabel1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highScoreLabel2 = new System.Windows.Forms.Label();
            this.highScoreNaNicBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Igričar 1:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Igričar 2:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(203, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 165);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(61, 258);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 14;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(219, 258);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 15;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // scoreLabel1
            // 
            this.scoreLabel1.AutoSize = true;
            this.scoreLabel1.Location = new System.Drawing.Point(96, 30);
            this.scoreLabel1.Name = "scoreLabel1";
            this.scoreLabel1.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel1.TabIndex = 16;
            this.scoreLabel1.Text = "0";
            // 
            // scoreLabel2
            // 
            this.scoreLabel2.AutoSize = true;
            this.scoreLabel2.Location = new System.Drawing.Point(254, 30);
            this.scoreLabel2.Name = "scoreLabel2";
            this.scoreLabel2.Size = new System.Drawing.Size(13, 13);
            this.scoreLabel2.TabIndex = 17;
            this.scoreLabel2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Igričar 1 max:";
            // 
            // highScoreLabel1
            // 
            this.highScoreLabel1.AutoSize = true;
            this.highScoreLabel1.Location = new System.Drawing.Point(118, 302);
            this.highScoreLabel1.Name = "highScoreLabel1";
            this.highScoreLabel1.Size = new System.Drawing.Size(13, 13);
            this.highScoreLabel1.TabIndex = 19;
            this.highScoreLabel1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Igričar 2 max:";
            // 
            // highScoreLabel2
            // 
            this.highScoreLabel2.AutoSize = true;
            this.highScoreLabel2.Location = new System.Drawing.Point(290, 302);
            this.highScoreLabel2.Name = "highScoreLabel2";
            this.highScoreLabel2.Size = new System.Drawing.Size(13, 13);
            this.highScoreLabel2.TabIndex = 21;
            this.highScoreLabel2.Text = "0";
            // 
            // highScoreNaNicBtn
            // 
            this.highScoreNaNicBtn.Location = new System.Drawing.Point(45, 333);
            this.highScoreNaNicBtn.Name = "highScoreNaNicBtn";
            this.highScoreNaNicBtn.Size = new System.Drawing.Size(258, 23);
            this.highScoreNaNicBtn.TabIndex = 22;
            this.highScoreNaNicBtn.Text = "Resetiraj High Score";
            this.highScoreNaNicBtn.UseVisualStyleBackColor = true;
            this.highScoreNaNicBtn.Visible = false;
            this.highScoreNaNicBtn.Click += new System.EventHandler(this.highScoreNaNicBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 368);
            this.Controls.Add(this.highScoreNaNicBtn);
            this.Controls.Add(this.highScoreLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.highScoreLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLabel2);
            this.Controls.Add(this.scoreLabel1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label scoreLabel1;
        private System.Windows.Forms.Label scoreLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label highScoreLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label highScoreLabel2;
        private System.Windows.Forms.Button highScoreNaNicBtn;
    }
}


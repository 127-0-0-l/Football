namespace Builder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.scoreLeft = new System.Windows.Forms.Label();
            this.scoreRight = new System.Windows.Forms.Label();
            this.goalR = new System.Windows.Forms.PictureBox();
            this.goalL = new System.Windows.Forms.PictureBox();
            this.gamer2 = new System.Windows.Forms.PictureBox();
            this.box = new System.Windows.Forms.PictureBox();
            this.gamer1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goalR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamer1)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreLeft
            // 
            this.scoreLeft.AutoSize = true;
            this.scoreLeft.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLeft.Location = new System.Drawing.Point(228, 0);
            this.scoreLeft.Name = "scoreLeft";
            this.scoreLeft.Size = new System.Drawing.Size(21, 25);
            this.scoreLeft.TabIndex = 5;
            this.scoreLeft.Text = "0";
            // 
            // scoreRight
            // 
            this.scoreRight.AutoSize = true;
            this.scoreRight.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold);
            this.scoreRight.Location = new System.Drawing.Point(388, 0);
            this.scoreRight.Name = "scoreRight";
            this.scoreRight.Size = new System.Drawing.Size(21, 25);
            this.scoreRight.TabIndex = 6;
            this.scoreRight.Text = "0";
            // 
            // goalR
            // 
            this.goalR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goalR.Location = new System.Drawing.Point(600, 150);
            this.goalR.Name = "goalR";
            this.goalR.Size = new System.Drawing.Size(30, 150);
            this.goalR.TabIndex = 4;
            this.goalR.TabStop = false;
            // 
            // goalL
            // 
            this.goalL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.goalL.Location = new System.Drawing.Point(0, 150);
            this.goalL.Name = "goalL";
            this.goalL.Size = new System.Drawing.Size(30, 150);
            this.goalL.TabIndex = 3;
            this.goalL.TabStop = false;
            // 
            // gamer2
            // 
            this.gamer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gamer2.BackgroundImage = global::Builder.Properties.Resources.player2;
            this.gamer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamer2.Location = new System.Drawing.Point(570, 210);
            this.gamer2.Name = "gamer2";
            this.gamer2.Size = new System.Drawing.Size(30, 30);
            this.gamer2.TabIndex = 2;
            this.gamer2.TabStop = false;
            // 
            // box
            // 
            this.box.BackgroundImage = global::Builder.Properties.Resources.ball2;
            this.box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.box.Location = new System.Drawing.Point(300, 210);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(30, 30);
            this.box.TabIndex = 1;
            this.box.TabStop = false;
            // 
            // gamer1
            // 
            this.gamer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gamer1.BackgroundImage = global::Builder.Properties.Resources.player1;
            this.gamer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamer1.Location = new System.Drawing.Point(30, 210);
            this.gamer1.Name = "gamer1";
            this.gamer1.Size = new System.Drawing.Size(30, 30);
            this.gamer1.TabIndex = 0;
            this.gamer1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.scoreRight);
            this.Controls.Add(this.scoreLeft);
            this.Controls.Add(this.goalR);
            this.Controls.Add(this.goalL);
            this.Controls.Add(this.gamer2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.gamer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.goalR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goalL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gamer1;
        private System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.PictureBox gamer2;
        private System.Windows.Forms.PictureBox goalL;
        private System.Windows.Forms.PictureBox goalR;
        private System.Windows.Forms.Label scoreLeft;
        private System.Windows.Forms.Label scoreRight;
    }
}


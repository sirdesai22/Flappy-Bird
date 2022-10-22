namespace Flappy_Bird
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
            this.components = new System.ComponentModel.Container();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.BottomPipe = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.TopPipe = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // Ground
            // 
            this.Ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-34, 733);
            this.Ground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(850, 184);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // BottomPipe
            // 
            this.BottomPipe.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.BottomPipe.Location = new System.Drawing.Point(521, 503);
            this.BottomPipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BottomPipe.Name = "BottomPipe";
            this.BottomPipe.Size = new System.Drawing.Size(114, 393);
            this.BottomPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomPipe.TabIndex = 1;
            this.BottomPipe.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Transparent;
            this.Bird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.Bird.Location = new System.Drawing.Point(88, 317);
            this.Bird.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(83, 84);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 2;
            this.Bird.TabStop = false;
            // 
            // TopPipe
            // 
            this.TopPipe.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.TopPipe.Location = new System.Drawing.Point(586, -115);
            this.TopPipe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPipe.Name = "TopPipe";
            this.TopPipe.Size = new System.Drawing.Size(114, 369);
            this.TopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopPipe.TabIndex = 3;
            this.TopPipe.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Wheat;
            this.scoretext.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoretext.Location = new System.Drawing.Point(243, 776);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(160, 50);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score: 0";
            this.scoretext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvents);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(782, 881);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.TopPipe);
            this.Controls.Add(this.BottomPipe);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Flappy Bird Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gamerestart);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TopPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Ground;
        private PictureBox BottomPipe;
        private PictureBox Bird;
        private PictureBox TopPipe;
        private Label scoretext;
        private System.Windows.Forms.Timer GameTimer;
    }
}
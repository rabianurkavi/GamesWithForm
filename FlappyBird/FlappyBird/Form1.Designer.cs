
namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_control = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_floor = new System.Windows.Forms.PictureBox();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.pictureBox_top = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_control
            // 
            this.timer_control.Enabled = true;
            this.timer_control.Interval = 20;
            this.timer_control.Tick += new System.EventHandler(this.gameTimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "SCORE:";
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Image = global::FlappyBird.Properties.Resources.flappy_bird;
            this.pictureBox_bird.Location = new System.Drawing.Point(16, 236);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(100, 63);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_bird.TabIndex = 5;
            this.pictureBox_bird.TabStop = false;
            this.pictureBox_bird.Click += new System.EventHandler(this.pictureBox_bird_Click);
            // 
            // pictureBox_floor
            // 
            this.pictureBox_floor.Image = global::FlappyBird.Properties.Resources.flappybirdfloor;
            this.pictureBox_floor.Location = new System.Drawing.Point(0, 495);
            this.pictureBox_floor.Name = "pictureBox_floor";
            this.pictureBox_floor.Size = new System.Drawing.Size(804, 140);
            this.pictureBox_floor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_floor.TabIndex = 3;
            this.pictureBox_floor.TabStop = false;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.Image = global::FlappyBird.Properties.Resources.pipe_uup;
            this.pictureBox_down.Location = new System.Drawing.Point(295, 348);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(116, 151);
            this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_down.TabIndex = 2;
            this.pictureBox_down.TabStop = false;
            // 
            // pictureBox_top
            // 
            this.pictureBox_top.Image = global::FlappyBird.Properties.Resources.pipe_180;
            this.pictureBox_top.Location = new System.Drawing.Point(442, -1);
            this.pictureBox_top.Name = "pictureBox_top";
            this.pictureBox_top.Size = new System.Drawing.Size(116, 157);
            this.pictureBox_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_top.TabIndex = 1;
            this.pictureBox_top.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(375, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox_bird);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_floor);
            this.Controls.Add(this.pictureBox_down);
            this.Controls.Add(this.pictureBox_top);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_Down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_Up);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_top;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_floor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.Timer timer_control;
        private System.Windows.Forms.Label label2;
    }
}


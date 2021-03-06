
namespace SosGames
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1oyuncu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2oyuncu = new System.Windows.Forms.Label();
            this.lbltplmsos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsiraoyuncu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Baştan Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birinci Oyuncu Puanı:";
            // 
            // lbl1oyuncu
            // 
            this.lbl1oyuncu.AutoSize = true;
            this.lbl1oyuncu.Location = new System.Drawing.Point(126, 510);
            this.lbl1oyuncu.Name = "lbl1oyuncu";
            this.lbl1oyuncu.Size = new System.Drawing.Size(35, 13);
            this.lbl1oyuncu.TabIndex = 2;
            this.lbl1oyuncu.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "İkinci Oyuncu Puanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 510);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toplam SOS Sayısı:";
            // 
            // lbl2oyuncu
            // 
            this.lbl2oyuncu.AutoSize = true;
            this.lbl2oyuncu.Location = new System.Drawing.Point(326, 510);
            this.lbl2oyuncu.Name = "lbl2oyuncu";
            this.lbl2oyuncu.Size = new System.Drawing.Size(10, 13);
            this.lbl2oyuncu.TabIndex = 5;
            this.lbl2oyuncu.Text = ".";
            // 
            // lbltplmsos
            // 
            this.lbltplmsos.AutoSize = true;
            this.lbltplmsos.Location = new System.Drawing.Point(460, 510);
            this.lbltplmsos.Name = "lbltplmsos";
            this.lbltplmsos.Size = new System.Drawing.Size(29, 13);
            this.lbltplmsos.TabIndex = 6;
            this.lbltplmsos.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sıradaki Oyuncu:";
            // 
            // lblsiraoyuncu
            // 
            this.lblsiraoyuncu.AutoSize = true;
            this.lblsiraoyuncu.Location = new System.Drawing.Point(616, 510);
            this.lblsiraoyuncu.Name = "lblsiraoyuncu";
            this.lblsiraoyuncu.Size = new System.Drawing.Size(35, 13);
            this.lblsiraoyuncu.TabIndex = 8;
            this.lblsiraoyuncu.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 548);
            this.Controls.Add(this.lblsiraoyuncu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbltplmsos);
            this.Controls.Add(this.lbl2oyuncu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1oyuncu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1oyuncu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2oyuncu;
        private System.Windows.Forms.Label lbltplmsos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsiraoyuncu;
    }
}


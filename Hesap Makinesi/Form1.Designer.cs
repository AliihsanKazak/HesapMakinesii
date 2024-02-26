namespace Hesap_Makinesi
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
            this.lblsonuc = new System.Windows.Forms.Label();
            this.lsayi1 = new System.Windows.Forms.Label();
            this.mtsayi2 = new System.Windows.Forms.MaskedTextBox();
            this.mtsayi1 = new System.Windows.Forms.MaskedTextBox();
            this.bolme = new System.Windows.Forms.Button();
            this.carpma = new System.Windows.Forms.Button();
            this.cikarma = new System.Windows.Forms.Button();
            this.toplama = new System.Windows.Forms.Button();
            this.lsayi2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsonuc
            // 
            this.lblsonuc.BackColor = System.Drawing.SystemColors.Control;
            this.lblsonuc.Location = new System.Drawing.Point(43, 73);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(241, 35);
            this.lblsonuc.TabIndex = 0;
            // 
            // lsayi1
            // 
            this.lsayi1.AutoSize = true;
            this.lsayi1.ForeColor = System.Drawing.Color.White;
            this.lsayi1.Location = new System.Drawing.Point(43, 139);
            this.lsayi1.Name = "lsayi1";
            this.lsayi1.Size = new System.Drawing.Size(47, 16);
            this.lsayi1.TabIndex = 2;
            this.lsayi1.Text = "Sayi 1:";
            // 
            // mtsayi2
            // 
            this.mtsayi2.Location = new System.Drawing.Point(128, 165);
            this.mtsayi2.Mask = "00000000";
            this.mtsayi2.Name = "mtsayi2";
            this.mtsayi2.Size = new System.Drawing.Size(63, 22);
            this.mtsayi2.TabIndex = 10;
            // 
            // mtsayi1
            // 
            this.mtsayi1.Location = new System.Drawing.Point(128, 136);
            this.mtsayi1.Mask = "00000000";
            this.mtsayi1.Name = "mtsayi1";
            this.mtsayi1.Size = new System.Drawing.Size(63, 22);
            this.mtsayi1.TabIndex = 9;
            // 
            // bolme
            // 
            this.bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme.Location = new System.Drawing.Point(229, 199);
            this.bolme.Name = "bolme";
            this.bolme.Size = new System.Drawing.Size(55, 55);
            this.bolme.TabIndex = 8;
            this.bolme.Text = "/\r\n";
            this.bolme.UseVisualStyleBackColor = true;
            this.bolme.Click += new System.EventHandler(this.bolme_Click);
            // 
            // carpma
            // 
            this.carpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma.Location = new System.Drawing.Point(168, 199);
            this.carpma.Name = "carpma";
            this.carpma.Size = new System.Drawing.Size(55, 55);
            this.carpma.TabIndex = 7;
            this.carpma.Text = "*";
            this.carpma.UseVisualStyleBackColor = true;
            this.carpma.Click += new System.EventHandler(this.carpma_Click);
            // 
            // cikarma
            // 
            this.cikarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarma.Location = new System.Drawing.Point(107, 200);
            this.cikarma.Name = "cikarma";
            this.cikarma.Size = new System.Drawing.Size(55, 55);
            this.cikarma.TabIndex = 6;
            this.cikarma.Text = "-";
            this.cikarma.UseVisualStyleBackColor = true;
            this.cikarma.Click += new System.EventHandler(this.cikarma_Click);
            // 
            // toplama
            // 
            this.toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama.Location = new System.Drawing.Point(46, 200);
            this.toplama.Name = "toplama";
            this.toplama.Size = new System.Drawing.Size(55, 55);
            this.toplama.TabIndex = 5;
            this.toplama.Text = "+";
            this.toplama.UseVisualStyleBackColor = true;
            this.toplama.Click += new System.EventHandler(this.toplama_Click);
            // 
            // lsayi2
            // 
            this.lsayi2.AutoSize = true;
            this.lsayi2.ForeColor = System.Drawing.Color.White;
            this.lsayi2.Location = new System.Drawing.Point(43, 168);
            this.lsayi2.Name = "lsayi2";
            this.lsayi2.Size = new System.Drawing.Size(47, 16);
            this.lsayi2.TabIndex = 4;
            this.lsayi2.Text = "Sayi 2:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(348, 441);
            this.Controls.Add(this.bolme);
            this.Controls.Add(this.mtsayi2);
            this.Controls.Add(this.carpma);
            this.Controls.Add(this.cikarma);
            this.Controls.Add(this.mtsayi1);
            this.Controls.Add(this.toplama);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.lsayi1);
            this.Controls.Add(this.lsayi2);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Label lsayi1;
        private System.Windows.Forms.Label lsayi2;
        private System.Windows.Forms.Button bolme;
        private System.Windows.Forms.Button carpma;
        private System.Windows.Forms.Button cikarma;
        private System.Windows.Forms.Button toplama;
        private System.Windows.Forms.MaskedTextBox mtsayi2;
        private System.Windows.Forms.MaskedTextBox mtsayi1;
    }
}


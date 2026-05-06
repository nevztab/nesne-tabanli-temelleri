namespace nesne_tabanli_temelleri
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
            this.tbAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbNot = new System.Windows.Forms.TextBox();
            this.tbYas = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.Label();
            this.Yas = new System.Windows.Forms.Label();
            this.NotOrt = new System.Windows.Forms.Label();
            this.Soyad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(231, 68);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(138, 22);
            this.tbAd.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbNot
            // 
            this.tbNot.Location = new System.Drawing.Point(231, 305);
            this.tbNot.Name = "tbNot";
            this.tbNot.Size = new System.Drawing.Size(138, 22);
            this.tbNot.TabIndex = 2;
            // 
            // tbYas
            // 
            this.tbYas.Location = new System.Drawing.Point(231, 222);
            this.tbYas.Name = "tbYas";
            this.tbYas.Size = new System.Drawing.Size(138, 22);
            this.tbYas.TabIndex = 3;
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(232, 144);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(138, 22);
            this.tbSoyad.TabIndex = 4;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(151, 384);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(137, 29);
            this.Kaydet.TabIndex = 5;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ad
            // 
            this.Ad.AutoSize = true;
            this.Ad.Location = new System.Drawing.Point(65, 74);
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(24, 16);
            this.Ad.TabIndex = 6;
            this.Ad.Text = "Ad";
            this.Ad.Click += new System.EventHandler(this.label1_Click);
            // 
            // Yas
            // 
            this.Yas.AutoSize = true;
            this.Yas.Location = new System.Drawing.Point(65, 228);
            this.Yas.Name = "Yas";
            this.Yas.Size = new System.Drawing.Size(31, 16);
            this.Yas.TabIndex = 7;
            this.Yas.Text = "Yaş";
            // 
            // NotOrt
            // 
            this.NotOrt.AutoSize = true;
            this.NotOrt.Location = new System.Drawing.Point(65, 311);
            this.NotOrt.Name = "NotOrt";
            this.NotOrt.Size = new System.Drawing.Size(96, 16);
            this.NotOrt.TabIndex = 8;
            this.NotOrt.Text = "Not Ortalaması";
            // 
            // Soyad
            // 
            this.Soyad.AutoSize = true;
            this.Soyad.Location = new System.Drawing.Point(65, 150);
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(47, 16);
            this.Soyad.TabIndex = 9;
            this.Soyad.Text = "Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.NotOrt);
            this.Controls.Add(this.Yas);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.tbSoyad);
            this.Controls.Add(this.tbYas);
            this.Controls.Add(this.tbNot);
            this.Controls.Add(this.tbAd);
            this.Name = "Form1";
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbNot;
        private System.Windows.Forms.TextBox tbYas;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Label Ad;
        private System.Windows.Forms.Label Yas;
        private System.Windows.Forms.Label NotOrt;
        private System.Windows.Forms.Label Soyad;
    }
}


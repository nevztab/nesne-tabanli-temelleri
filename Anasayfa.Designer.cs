namespace nesne_tabanli_temelleri
{
    partial class Anasayfa
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
            this.listele = new System.Windows.Forms.Button();
            this.kayitAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(663, 12);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(125, 23);
            this.listele.TabIndex = 0;
            this.listele.Text = "Öğrencileri listele";
            this.listele.UseVisualStyleBackColor = true;
            // 
            // kayitAc
            // 
            this.kayitAc.Location = new System.Drawing.Point(663, 45);
            this.kayitAc.Name = "kayitAc";
            this.kayitAc.Size = new System.Drawing.Size(125, 23);
            this.kayitAc.TabIndex = 1;
            this.kayitAc.Text = "kayıt ekranı";
            this.kayitAc.UseVisualStyleBackColor = true;
            this.kayitAc.Click += new System.EventHandler(this.button2_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kayitAc);
            this.Controls.Add(this.listele);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listele;
        private System.Windows.Forms.Button kayitAc;
    }
}
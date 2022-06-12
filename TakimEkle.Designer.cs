namespace Superlig
{
    partial class TakimEkle
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
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_renk = new System.Windows.Forms.Label();
            this.txt_TakimAdi = new System.Windows.Forms.TextBox();
            this.txt_Renkleri = new System.Windows.Forms.TextBox();
            this.btn_kayit = new System.Windows.Forms.Button();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(36, 49);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(71, 16);
            this.lbl_ad.TabIndex = 0;
            this.lbl_ad.Text = "Takım Adı:";
            // 
            // lbl_renk
            // 
            this.lbl_renk.AutoSize = true;
            this.lbl_renk.Location = new System.Drawing.Point(12, 85);
            this.lbl_renk.Name = "lbl_renk";
            this.lbl_renk.Size = new System.Drawing.Size(101, 16);
            this.lbl_renk.TabIndex = 1;
            this.lbl_renk.Text = "Takım Renkleri:";
            // 
            // txt_TakimAdi
            // 
            this.txt_TakimAdi.Location = new System.Drawing.Point(128, 46);
            this.txt_TakimAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TakimAdi.Name = "txt_TakimAdi";
            this.txt_TakimAdi.Size = new System.Drawing.Size(100, 22);
            this.txt_TakimAdi.TabIndex = 2;
            this.txt_TakimAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Renkleri
            // 
            this.txt_Renkleri.Location = new System.Drawing.Point(128, 82);
            this.txt_Renkleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Renkleri.Name = "txt_Renkleri";
            this.txt_Renkleri.Size = new System.Drawing.Size(100, 22);
            this.txt_Renkleri.TabIndex = 3;
            // 
            // btn_kayit
            // 
            this.btn_kayit.Location = new System.Drawing.Point(39, 150);
            this.btn_kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_kayit.Name = "btn_kayit";
            this.btn_kayit.Size = new System.Drawing.Size(100, 33);
            this.btn_kayit.TabIndex = 4;
            this.btn_kayit.Text = "Kaydet";
            this.btn_kayit.UseVisualStyleBackColor = true;
            this.btn_kayit.Click += new System.EventHandler(this.btn_kayit_Click);
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Location = new System.Drawing.Point(163, 150);
            this.btn_Kapat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(100, 33);
            this.btn_Kapat.TabIndex = 5;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // TakimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 242);
            this.Controls.Add(this.btn_Kapat);
            this.Controls.Add(this.btn_kayit);
            this.Controls.Add(this.txt_Renkleri);
            this.Controls.Add(this.txt_TakimAdi);
            this.Controls.Add(this.lbl_renk);
            this.Controls.Add(this.lbl_ad);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TakimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Takım Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_renk;
        private System.Windows.Forms.TextBox txt_TakimAdi;
        private System.Windows.Forms.TextBox txt_Renkleri;
        private System.Windows.Forms.Button btn_kayit;
        private System.Windows.Forms.Button btn_Kapat;
    }
}
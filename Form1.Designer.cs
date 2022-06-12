namespace Superlig
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cikis = new System.Windows.Forms.Button();
            this.btn_lstle = new System.Windows.Forms.Button();
            this.btn_gnclle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.takimlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.superligDBDataSet = new Superlig.SuperligDBDataSet();
            this.takimlarTableAdapter = new Superlig.SuperligDBDataSetTableAdapters.TakimlarTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TakimAd = new System.Windows.Forms.TextBox();
            this.txt_Renk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TakimID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takimlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.superligDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Cikis);
            this.panel1.Controls.Add(this.btn_lstle);
            this.panel1.Controls.Add(this.btn_gnclle);
            this.panel1.Controls.Add(this.btn_Sil);
            this.panel1.Controls.Add(this.btn_Ekle);
            this.panel1.Location = new System.Drawing.Point(355, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 219);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.Location = new System.Drawing.Point(21, 149);
            this.btn_Cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(229, 57);
            this.btn_Cikis.TabIndex = 6;
            this.btn_Cikis.Text = "Çıkış Tuşu";
            this.btn_Cikis.UseVisualStyleBackColor = true;
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_lstle
            // 
            this.btn_lstle.Location = new System.Drawing.Point(21, 18);
            this.btn_lstle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lstle.Name = "btn_lstle";
            this.btn_lstle.Size = new System.Drawing.Size(91, 57);
            this.btn_lstle.TabIndex = 5;
            this.btn_lstle.Text = "Listele";
            this.btn_lstle.UseVisualStyleBackColor = true;
            this.btn_lstle.Click += new System.EventHandler(this.btn_lstle_Click);
            // 
            // btn_gnclle
            // 
            this.btn_gnclle.Location = new System.Drawing.Point(160, 18);
            this.btn_gnclle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_gnclle.Name = "btn_gnclle";
            this.btn_gnclle.Size = new System.Drawing.Size(91, 57);
            this.btn_gnclle.TabIndex = 4;
            this.btn_gnclle.Text = "Güncelle";
            this.btn_gnclle.UseVisualStyleBackColor = true;
            this.btn_gnclle.Click += new System.EventHandler(this.btn_gnclle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(160, 80);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(91, 57);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(21, 80);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(91, 57);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 297);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(597, 223);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // takimlarBindingSource
            // 
            this.takimlarBindingSource.DataMember = "Takimlar";
            this.takimlarBindingSource.DataSource = this.superligDBDataSet;
            // 
            // superligDBDataSet
            // 
            this.superligDBDataSet.DataSetName = "SuperligDBDataSet";
            this.superligDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // takimlarTableAdapter
            // 
            this.takimlarTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Takım Adı: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım Renkleri: ";
            // 
            // txt_TakimAd
            // 
            this.txt_TakimAd.Location = new System.Drawing.Point(141, 92);
            this.txt_TakimAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TakimAd.Name = "txt_TakimAd";
            this.txt_TakimAd.Size = new System.Drawing.Size(136, 22);
            this.txt_TakimAd.TabIndex = 4;
            // 
            // txt_Renk
            // 
            this.txt_Renk.Location = new System.Drawing.Point(141, 138);
            this.txt_Renk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Renk.Name = "txt_Renk";
            this.txt_Renk.Size = new System.Drawing.Size(136, 22);
            this.txt_Renk.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Takım No: ";
            // 
            // txt_TakimID
            // 
            this.txt_TakimID.Enabled = false;
            this.txt_TakimID.HideSelection = false;
            this.txt_TakimID.Location = new System.Drawing.Point(140, 47);
            this.txt_TakimID.Name = "txt_TakimID";
            this.txt_TakimID.Size = new System.Drawing.Size(137, 22);
            this.txt_TakimID.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 542);
            this.Controls.Add(this.txt_TakimID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Renk);
            this.Controls.Add(this.txt_TakimAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Süperlig Takım Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takimlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.superligDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_lstle;
        private System.Windows.Forms.Button btn_gnclle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private SuperligDBDataSet superligDBDataSet;
        private System.Windows.Forms.BindingSource takimlarBindingSource;
        private SuperligDBDataSetTableAdapters.TakimlarTableAdapter takimlarTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TakimAd;
        private System.Windows.Forms.TextBox txt_Renk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Cikis;
        private System.Windows.Forms.TextBox txt_TakimID;
    }
}


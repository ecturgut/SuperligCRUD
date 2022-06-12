using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superlig
{
    public partial class TakimEkle : Form
    {
        SqlConnection sql;
        SqlDataAdapter adapter;
        SqlCommand sqlCommand;
        public TakimEkle()
        {
            InitializeComponent();
        }
      
        private void btn_kayit_Click(object sender, EventArgs e)
        {   sql = new SqlConnection("Data Source=.;Database=SuperligDB;Trusted_Connection=True");
            string sorgu = "INSERT INTO Takimlar(TakimAdi,Renkleri) values (@TakimAdi,@Renkleri)";
            sqlCommand = new SqlCommand(sorgu, sql);
            sqlCommand.Parameters.AddWithValue("@TakimAdi", txt_TakimAdi.Text);
            sqlCommand.Parameters.AddWithValue("@Renkleri", txt_Renkleri.Text);
            sql.Open(); string msg = "Kayıt işlemi Başarılı !";
            MessageBox.Show(msg);
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            this.Close();
            VeriYenile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void VeriYenile()
        {

            SqlConnection sql = new SqlConnection("Data Source=.;Database=SuperligDB;Trusted_Connection=True");
            sql.Open();
            adapter = new SqlDataAdapter("select * from Takimlar", sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sql.Close();
        }

        private void btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

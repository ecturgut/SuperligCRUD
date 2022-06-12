using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Superlig
{
    public partial class Form1 : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.;Initial Catalog=SuperligDB;Integrated Security=True");
        SqlDataAdapter adapter;
        SqlCommand sqlCommand;
        public Form1()
        {
            
            InitializeComponent();
           
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            TakimEkle tkEkle = new TakimEkle();
            tkEkle.ShowDialog();
            VeriYenile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void VeriYenile()
        {

            SqlConnection sql = new SqlConnection("Data Source=.;Database=SuperligDB;Trusted_Connection=True");
            sql.Open();
            adapter = new SqlDataAdapter("select * from Takimlar", sql);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            sql.Close();
        }    

        private void btn_lstle_Click(object sender, EventArgs e)
        {
            VeriYenile();
        }

        private void btn_gnclle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE Takimlar SET  TakimAdi=@TakimAdi,Renkleri=@Renkleri where TakimID=@TakimID";
            sqlCommand = new SqlCommand(sorgu, sql);
            sqlCommand.Parameters.AddWithValue("@TakimID", Convert.ToInt32(txt_TakimID.Text));
            sqlCommand.Parameters.AddWithValue("@TakimAdi", txt_TakimAd.Text);
            sqlCommand.Parameters.AddWithValue("@Renkleri",txt_Renk.Text);
            sql.Open();
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            VeriYenile();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            string sorgu = "delete Takimlar  where TakimID=@TakimID";
            sqlCommand = new SqlCommand(sorgu, sql);
            sqlCommand.Parameters.AddWithValue("@TakimID", Convert.ToInt32(txt_TakimID.Text));
            sql.Open();
            string msg = "Silme İşlemi Başarılı !";
            MessageBox.Show(msg);          
            sqlCommand.ExecuteNonQuery();
            sql.Close();
            VeriYenile();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txt_TakimID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_TakimAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_Renk.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

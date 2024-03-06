using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kasir_caffe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string koneksi = "Data Source=COE2;Initial Catalog = bixstore; Integrated Security = True";
            SqlConnection conn = new SqlConnection(koneksi);
            string query = "SELECT ProdukID, nama, stok, harga FROM produk";
            SqlCommand cmd = new SqlCommand(query, conn);


            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataGridView1= new DataTable();


            adapter.Fill(dataGridView1);


            dataGridView1.DataSource = dataGridView1;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
           
            string koneksi = "Data Source=COE2\\sqlexpress01;Initial Catalog=bixstore;Integrated Security=True";
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string harga = textBox2.Text;
            string stok = textBox3.Text;


            if (nama != "" && harga != "" && stok != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO produk(nama, harga, stok) VALUES(@nama, @harga, @stok)", conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@stok", stok);
                conn.Open();

                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Data " + nama + " Berhasil di simpan");
                    cleardata();
                    loadData();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 MenuUtama = new Form2();
            this.Hide();
            MenuUtama.ShowDialog();
            this.Close();
        }
    }
}

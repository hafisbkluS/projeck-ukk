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

namespace kasir_caffe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            //validasi bila form tidak kosong
            if (username != "" && password != "")
            {
                //membuat koneksi ke database
                string koneksi = "Data Source=COE2;Initial Catalog = bixstore; Integrated Security = True";
                SqlConnection conn = new SqlConnection(koneksi);
                //query untuk mengecek adakan nama dan password yang dinputkan user di dabtase
                string query = "SELECT * FROM admin WHERE username = '" + username + "'AND password = '" + password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //bila row atau data di ambil lebih dari 0, maka asumsinya ada data pada database
                if (dt.Rows.Count > 0)
                {
                    //Berhasil login

                    //berpindah form ke main menu
                    Form2 Form2 = new Form2();
                    this.Hide();
                    Form2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }
            }
            else
            {
                MessageBox.Show("Username dan password tidak boleh kosong");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
      

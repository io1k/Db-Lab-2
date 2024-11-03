using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;

namespace Db_Lab_1_final
{
    public partial class QueryEdit : Form
    {
        private const string ConnectionString = "Data Source=DESKTOP-LCBASFT;Initial Catalog=OnlineMovieShopLab1Db;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public QueryEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                SqlConnection sqlconn = new SqlConnection(ConnectionString);
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(richTextBox1.Text, sqlconn);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                sqlconn.Close();
            }   
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Select";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
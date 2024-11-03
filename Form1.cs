using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_Lab_1_final
{
    public partial class Form1 : Form
    {
        private bool edit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Purchase);
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Movies);
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Customer);

            dataGridView1.AutoGenerateColumns = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            customerTableAdapter.Update(onlineMovieShopLab1DbDataSet);
            moviesTableAdapter.Update(onlineMovieShopLab1DbDataSet);
            purchaseTableAdapter.Update(onlineMovieShopLab1DbDataSet);
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = customerBindingSource;
            dataGridView1.DataSource = customerBindingSource;
            label1.Text = "Customers";
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = moviesBindingSource;
            dataGridView1.DataSource = moviesBindingSource;
            label1.Text = "Movies";
        }

        private void phurcasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = purchaseBindingSource;
            dataGridView1.DataSource = purchaseBindingSource;
            label1.Text = "Purchases";
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var rs = new Movies();
            rs.ShowDialog();
            customerTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Customer);
            purchaseTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Purchase);
            moviesTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Movies);
        }

        private void queryEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void queryEditToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var qe = new QueryEdit();
            qe.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = false;
            var edt = new EditForm();
            edt.ShowDialog();
            purchaseTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Purchase);
            onlineMovieShopLab1DbDataSet.AcceptChanges();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            var st = new OnlineMovieShopLab1DbDataSet.PurchaseDataTable();
            
            //edt.ShowDialog();
            //purchaseTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Purchase);
            //onlineMovieShopLab1DbDataSet.AcceptChanges();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseTableAdapter.DeleteQuery(
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value)
            );
            purchaseTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Purchase);
            onlineMovieShopLab1DbDataSet.AcceptChanges();
        }
    }
}

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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void moviesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.moviesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.onlineMovieShopLab1DbDataSet);

        }

        private void Movies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Purchase);
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Movies);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want reliable changes ? ", "Data changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                moviesBindingSource.EndEdit();
                moviesTableAdapter.Update(onlineMovieShopLab1DbDataSet);
                purchaseTableAdapter.Update(onlineMovieShopLab1DbDataSet);
            }   
        }
    }
}

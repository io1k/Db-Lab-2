using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_Lab_1_final
{
    public partial class EditForm : Form
    {
        private int id;
        private bool edit;

        public EditForm()
        {
            InitializeComponent();
            customerTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Customer);
            purchaseTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Purchase);
            moviesTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Movies);
        }
        public EditForm(int id, int customer_id, int content_id, DateTime purchase_date, double price) :this()
        {
            customerTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Customer);
            purchaseTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Purchase);
            moviesTableAdapter.Fill(onlineMovieShopLab1DbDataSet.Movies);

            edit = true;
            this.id = id;

            purchase_idtb.Text = id.ToString();
            purchase_datedtp.Value = purchase_date;
            customer_idcom.Text = customer_id.ToString();
            content_idcom.Text = content_id.ToString();
            pricetb.Text = content_id.ToString();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Purchase);
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Customer);
            // TODO: This line of code loads data into the 'onlineMovieShopLab1DbDataSet.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.onlineMovieShopLab1DbDataSet.Movies);

        }

        private void OkBt_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                purchaseTableAdapter.UpdateQuery(Convert.ToInt32(content_idcom.Text), Convert.ToInt32(customer_idcom), purchase_datedtp.Value, Convert.ToDouble(pricetb.Text), id);
            }
            else
            {
                purchaseTableAdapter.InsertQuery(Convert.ToInt32(purchase_idtb.Text),Convert.ToInt32(content_idcom.), Convert.ToInt32(customer_idcom), purchase_datedtp.Value, Convert.ToDouble(pricetb.Text));
            }
            Close();
        }

        private void CancelBt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

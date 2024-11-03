namespace Db_Lab_1_final
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            this.purchase_idtb = new System.Windows.Forms.TextBox();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pricelb = new System.Windows.Forms.Label();
            this.purchase_datedtp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.content_idcom = new System.Windows.Forms.ComboBox();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.onlineMovieShopLab1DbDataSet = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSet();
            this.customer_idcom = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OkBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.moviesTableAdapter = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.MoviesTableAdapter();
            this.customerTableAdapter = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.CustomerTableAdapter();
            this.purchaseTableAdapter = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.PurchaseTableAdapter();
            this.moviesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMovieShopLab1DbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // purchase_idtb
            // 
            this.purchase_idtb.Location = new System.Drawing.Point(151, 55);
            this.purchase_idtb.Name = "purchase_idtb";
            this.purchase_idtb.Size = new System.Drawing.Size(200, 22);
            this.purchase_idtb.TabIndex = 0;
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(151, 206);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(200, 22);
            this.pricetb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Purchase id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer id";
            // 
            // pricelb
            // 
            this.pricelb.AutoSize = true;
            this.pricelb.Location = new System.Drawing.Point(53, 209);
            this.pricelb.Name = "pricelb";
            this.pricelb.Size = new System.Drawing.Size(38, 16);
            this.pricelb.TabIndex = 5;
            this.pricelb.Text = "Price";
            // 
            // purchase_datedtp
            // 
            this.purchase_datedtp.Location = new System.Drawing.Point(151, 169);
            this.purchase_datedtp.Name = "purchase_datedtp";
            this.purchase_datedtp.Size = new System.Drawing.Size(200, 22);
            this.purchase_datedtp.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Purchase date";
            // 
            // content_idcom
            // 
            this.content_idcom.DataSource = this.moviesBindingSource1;
            this.content_idcom.DisplayMember = "title";
            this.content_idcom.FormattingEnabled = true;
            this.content_idcom.Location = new System.Drawing.Point(151, 89);
            this.content_idcom.Name = "content_idcom";
            this.content_idcom.Size = new System.Drawing.Size(200, 24);
            this.content_idcom.TabIndex = 8;
            this.content_idcom.ValueMember = "movie_id";
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Purchase";
            this.bindingSource1.DataSource = this.onlineMovieShopLab1DbDataSet;
            // 
            // onlineMovieShopLab1DbDataSet
            // 
            this.onlineMovieShopLab1DbDataSet.DataSetName = "OnlineMovieShopLab1DbDataSet";
            this.onlineMovieShopLab1DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customer_idcom
            // 
            this.customer_idcom.DataSource = this.customerBindingSource1;
            this.customer_idcom.DisplayMember = "customer_email";
            this.customer_idcom.FormattingEnabled = true;
            this.customer_idcom.Location = new System.Drawing.Point(151, 130);
            this.customer_idcom.Name = "customer_idcom";
            this.customer_idcom.Size = new System.Drawing.Size(200, 24);
            this.customer_idcom.TabIndex = 9;
            this.customer_idcom.ValueMember = "customer_id";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = this.bindingSource1;
            // 
            // OkBt
            // 
            this.OkBt.Location = new System.Drawing.Point(54, 310);
            this.OkBt.Name = "OkBt";
            this.OkBt.Size = new System.Drawing.Size(75, 46);
            this.OkBt.TabIndex = 10;
            this.OkBt.Text = "OK";
            this.OkBt.UseVisualStyleBackColor = true;
            this.OkBt.Click += new System.EventHandler(this.OkBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.Location = new System.Drawing.Point(276, 310);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(75, 46);
            this.CancelBt.TabIndex = 11;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // moviesBindingSource1
            // 
            this.moviesBindingSource1.DataMember = "Movies";
            this.moviesBindingSource1.DataSource = this.onlineMovieShopLab1DbDataSet;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataMember = "Customer";
            this.customerBindingSource1.DataSource = this.onlineMovieShopLab1DbDataSet;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.OkBt);
            this.Controls.Add(this.customer_idcom);
            this.Controls.Add(this.content_idcom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchase_datedtp);
            this.Controls.Add(this.pricelb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.purchase_idtb);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMovieShopLab1DbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox purchase_idtb;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pricelb;
        private System.Windows.Forms.DateTimePicker purchase_datedtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox content_idcom;
        private System.Windows.Forms.ComboBox customer_idcom;
        private System.Windows.Forms.Button OkBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.BindingSource bindingSource1;
        private OnlineMovieShopLab1DbDataSet onlineMovieShopLab1DbDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private OnlineMovieShopLab1DbDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private OnlineMovieShopLab1DbDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private OnlineMovieShopLab1DbDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.BindingSource moviesBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource1;
    }
}
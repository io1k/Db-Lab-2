namespace Db_Lab_1_final
{
    partial class Movies
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
            System.Windows.Forms.Label movie_idLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label production_yearLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label languageLabel;
            System.Windows.Forms.Label purchase_priceLabel;
            System.Windows.Forms.Label availiable_for_purchaseLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies));
            this.onlineMovieShopLab1DbDataSet = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.MoviesTableAdapter();
            this.tableAdapterManager = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.TableAdapterManager();
            this.purchaseTableAdapter = new Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.PurchaseTableAdapter();
            this.moviesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.moviesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.movie_idTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.production_yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.purchase_priceTextBox = new System.Windows.Forms.TextBox();
            this.availiable_for_purchaseCheckBox = new System.Windows.Forms.CheckBox();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            movie_idLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            production_yearLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            languageLabel = new System.Windows.Forms.Label();
            purchase_priceLabel = new System.Windows.Forms.Label();
            availiable_for_purchaseLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMovieShopLab1DbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).BeginInit();
            this.moviesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movie_idLabel
            // 
            movie_idLabel.AutoSize = true;
            movie_idLabel.Location = new System.Drawing.Point(12, 29);
            movie_idLabel.Name = "movie_idLabel";
            movie_idLabel.Size = new System.Drawing.Size(61, 16);
            movie_idLabel.TabIndex = 1;
            movie_idLabel.Text = "movie id:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(12, 57);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(45, 16);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "genre:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(12, 85);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 16);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "title:";
            // 
            // production_yearLabel
            // 
            production_yearLabel.AutoSize = true;
            production_yearLabel.Location = new System.Drawing.Point(12, 114);
            production_yearLabel.Name = "production_yearLabel";
            production_yearLabel.Size = new System.Drawing.Size(103, 16);
            production_yearLabel.TabIndex = 7;
            production_yearLabel.Text = "production year:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(12, 141);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(58, 16);
            durationLabel.TabIndex = 9;
            durationLabel.Text = "duration:";
            // 
            // languageLabel
            // 
            languageLabel.AutoSize = true;
            languageLabel.Location = new System.Drawing.Point(12, 169);
            languageLabel.Name = "languageLabel";
            languageLabel.Size = new System.Drawing.Size(67, 16);
            languageLabel.TabIndex = 11;
            languageLabel.Text = "language:";
            // 
            // purchase_priceLabel
            // 
            purchase_priceLabel.AutoSize = true;
            purchase_priceLabel.Location = new System.Drawing.Point(12, 197);
            purchase_priceLabel.Name = "purchase_priceLabel";
            purchase_priceLabel.Size = new System.Drawing.Size(99, 16);
            purchase_priceLabel.TabIndex = 13;
            purchase_priceLabel.Text = "purchase price:";
            // 
            // availiable_for_purchaseLabel
            // 
            availiable_for_purchaseLabel.AutoSize = true;
            availiable_for_purchaseLabel.Location = new System.Drawing.Point(12, 227);
            availiable_for_purchaseLabel.Name = "availiable_for_purchaseLabel";
            availiable_for_purchaseLabel.Size = new System.Drawing.Size(146, 16);
            availiable_for_purchaseLabel.TabIndex = 15;
            availiable_for_purchaseLabel.Text = "availiable for purchase:";
            // 
            // onlineMovieShopLab1DbDataSet
            // 
            this.onlineMovieShopLab1DbDataSet.DataSetName = "OnlineMovieShopLab1DbDataSet";
            this.onlineMovieShopLab1DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "Movies";
            this.moviesBindingSource.DataSource = this.onlineMovieShopLab1DbDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.MoviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.PurchaseTableAdapter = this.purchaseTableAdapter;
            this.tableAdapterManager.UpdateOrder = Db_Lab_1_final.OnlineMovieShopLab1DbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // purchaseTableAdapter
            // 
            this.purchaseTableAdapter.ClearBeforeFill = true;
            // 
            // moviesBindingNavigator
            // 
            this.moviesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moviesBindingNavigator.BindingSource = this.moviesBindingSource;
            this.moviesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.moviesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moviesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.moviesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.moviesBindingNavigatorSaveItem});
            this.moviesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moviesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moviesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moviesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.moviesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.moviesBindingNavigator.Name = "moviesBindingNavigator";
            this.moviesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.moviesBindingNavigator.Size = new System.Drawing.Size(800, 31);
            this.moviesBindingNavigator.TabIndex = 0;
            this.moviesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // moviesBindingNavigatorSaveItem
            // 
            this.moviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moviesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("moviesBindingNavigatorSaveItem.Image")));
            this.moviesBindingNavigatorSaveItem.Name = "moviesBindingNavigatorSaveItem";
            this.moviesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.moviesBindingNavigatorSaveItem.Text = "Save Data";
            this.moviesBindingNavigatorSaveItem.Click += new System.EventHandler(this.moviesBindingNavigatorSaveItem_Click);
            // 
            // movie_idTextBox
            // 
            this.movie_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "movie_id", true));
            this.movie_idTextBox.Location = new System.Drawing.Point(164, 26);
            this.movie_idTextBox.Name = "movie_idTextBox";
            this.movie_idTextBox.Size = new System.Drawing.Size(200, 22);
            this.movie_idTextBox.TabIndex = 2;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(164, 54);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(200, 22);
            this.genreTextBox.TabIndex = 4;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(164, 82);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 22);
            this.titleTextBox.TabIndex = 6;
            // 
            // production_yearDateTimePicker
            // 
            this.production_yearDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.moviesBindingSource, "production_year", true));
            this.production_yearDateTimePicker.Location = new System.Drawing.Point(164, 110);
            this.production_yearDateTimePicker.Name = "production_yearDateTimePicker";
            this.production_yearDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.production_yearDateTimePicker.TabIndex = 8;
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(164, 138);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(200, 22);
            this.durationTextBox.TabIndex = 10;
            // 
            // languageTextBox
            // 
            this.languageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "language", true));
            this.languageTextBox.Location = new System.Drawing.Point(164, 166);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(200, 22);
            this.languageTextBox.TabIndex = 12;
            // 
            // purchase_priceTextBox
            // 
            this.purchase_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "purchase_price", true));
            this.purchase_priceTextBox.Location = new System.Drawing.Point(164, 194);
            this.purchase_priceTextBox.Name = "purchase_priceTextBox";
            this.purchase_priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.purchase_priceTextBox.TabIndex = 14;
            // 
            // availiable_for_purchaseCheckBox
            // 
            this.availiable_for_purchaseCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.moviesBindingSource, "availiable_for_purchase", true));
            this.availiable_for_purchaseCheckBox.Location = new System.Drawing.Point(164, 222);
            this.availiable_for_purchaseCheckBox.Name = "availiable_for_purchaseCheckBox";
            this.availiable_for_purchaseCheckBox.Size = new System.Drawing.Size(200, 24);
            this.availiable_for_purchaseCheckBox.TabIndex = 16;
            this.availiable_for_purchaseCheckBox.Text = "checkBox1";
            this.availiable_for_purchaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataMember = "Purchase";
            this.purchaseBindingSource.DataSource = this.onlineMovieShopLab1DbDataSet;
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AutoGenerateColumns = false;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.purchaseDataGridView.DataSource = this.purchaseBindingSource;
            this.purchaseDataGridView.Location = new System.Drawing.Point(15, 252);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.RowHeadersWidth = 51;
            this.purchaseDataGridView.RowTemplate.Height = 24;
            this.purchaseDataGridView.Size = new System.Drawing.Size(773, 200);
            this.purchaseDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "purchase_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "purchase_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "content_id";
            this.dataGridViewTextBoxColumn2.HeaderText = "content_id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "customer_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "customer_id";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "purchase_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "purchase_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.purchaseDataGridView);
            this.Controls.Add(movie_idLabel);
            this.Controls.Add(this.movie_idTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(production_yearLabel);
            this.Controls.Add(this.production_yearDateTimePicker);
            this.Controls.Add(durationLabel);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(languageLabel);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(purchase_priceLabel);
            this.Controls.Add(this.purchase_priceTextBox);
            this.Controls.Add(availiable_for_purchaseLabel);
            this.Controls.Add(this.availiable_for_purchaseCheckBox);
            this.Controls.Add(this.moviesBindingNavigator);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.onlineMovieShopLab1DbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).EndInit();
            this.moviesBindingNavigator.ResumeLayout(false);
            this.moviesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OnlineMovieShopLab1DbDataSet onlineMovieShopLab1DbDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private OnlineMovieShopLab1DbDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter;
        private OnlineMovieShopLab1DbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator moviesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton moviesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox movie_idTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.DateTimePicker production_yearDateTimePicker;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.TextBox purchase_priceTextBox;
        private System.Windows.Forms.CheckBox availiable_for_purchaseCheckBox;
        private OnlineMovieShopLab1DbDataSetTableAdapters.PurchaseTableAdapter purchaseTableAdapter;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
    }
}
namespace BestGrill
{
    partial class AdminUi
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
            this.tbManage = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.btnEditDish = new System.Windows.Forms.Button();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.cbDishCategory = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDishPrice = new System.Windows.Forms.TextBox();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.tbDishID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvDishAdmin = new System.Windows.Forms.DataGridView();
            this.dishIDCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbCategory = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteCate = new System.Windows.Forms.Button();
            this.btnEditCate = new System.Windows.Forms.Button();
            this.btnAddCate = new System.Windows.Forms.Button();
            this.tbCateName = new System.Windows.Forms.TextBox();
            this.tbCateId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvCate = new System.Windows.Forms.DataGridView();
            this.cateIdDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateNameDv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbIncome = new System.Windows.Forms.TabPage();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAnalytics = new System.Windows.Forms.Button();
            this.dvProfit = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManage.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDishAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            this.tbCategory.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCate)).BeginInit();
            this.tbIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbManage
            // 
            this.tbManage.Controls.Add(this.tabMenu);
            this.tbManage.Controls.Add(this.tbCategory);
            this.tbManage.Controls.Add(this.tbIncome);
            this.tbManage.Location = new System.Drawing.Point(12, 12);
            this.tbManage.Name = "tbManage";
            this.tbManage.SelectedIndex = 0;
            this.tbManage.Size = new System.Drawing.Size(790, 493);
            this.tbManage.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.panel1);
            this.tabMenu.Controls.Add(this.dvDishAdmin);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(782, 467);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Thực đơn";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteDish);
            this.panel1.Controls.Add(this.btnEditDish);
            this.panel1.Controls.Add(this.btnAddDish);
            this.panel1.Controls.Add(this.cbDishCategory);
            this.panel1.Controls.Add(this.tbDishPrice);
            this.panel1.Controls.Add(this.tbDishName);
            this.panel1.Controls.Add(this.tbDishID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(469, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 377);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.Location = new System.Drawing.Point(207, 292);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteDish.TabIndex = 10;
            this.btnDeleteDish.Text = "Xóa món";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // btnEditDish
            // 
            this.btnEditDish.Location = new System.Drawing.Point(115, 292);
            this.btnEditDish.Name = "btnEditDish";
            this.btnEditDish.Size = new System.Drawing.Size(75, 37);
            this.btnEditDish.TabIndex = 9;
            this.btnEditDish.Text = "Sửa món";
            this.btnEditDish.UseVisualStyleBackColor = true;
            this.btnEditDish.Click += new System.EventHandler(this.btnEditDish_Click);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(14, 292);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(75, 38);
            this.btnAddDish.TabIndex = 8;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // cbDishCategory
            // 
            this.cbDishCategory.DataSource = this.categoryBindingSource;
            this.cbDishCategory.DisplayMember = "Name";
            this.cbDishCategory.FormattingEnabled = true;
            this.cbDishCategory.Location = new System.Drawing.Point(125, 153);
            this.cbDishCategory.Name = "cbDishCategory";
            this.cbDishCategory.Size = new System.Drawing.Size(144, 21);
            this.cbDishCategory.TabIndex = 7;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(BestGrill.Model.Category);
            // 
            // tbDishPrice
            // 
            this.tbDishPrice.Location = new System.Drawing.Point(125, 214);
            this.tbDishPrice.Name = "tbDishPrice";
            this.tbDishPrice.Size = new System.Drawing.Size(144, 20);
            this.tbDishPrice.TabIndex = 6;
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(125, 84);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(144, 20);
            this.tbDishName.TabIndex = 5;
            // 
            // tbDishID
            // 
            this.tbDishID.Enabled = false;
            this.tbDishID.Location = new System.Drawing.Point(125, 32);
            this.tbDishID.Name = "tbDishID";
            this.tbDishID.Size = new System.Drawing.Size(144, 20);
            this.tbDishID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món ăn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // dvDishAdmin
            // 
            this.dvDishAdmin.AutoGenerateColumns = false;
            this.dvDishAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDishAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishIDCol,
            this.DishName,
            this.priceCol,
            this.categoryCol});
            this.dvDishAdmin.DataSource = this.dishBindingSource;
            this.dvDishAdmin.Location = new System.Drawing.Point(6, 22);
            this.dvDishAdmin.MultiSelect = false;
            this.dvDishAdmin.Name = "dvDishAdmin";
            this.dvDishAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDishAdmin.Size = new System.Drawing.Size(404, 386);
            this.dvDishAdmin.TabIndex = 0;
            this.dvDishAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvDishAdmin_CellClick);
            // 
            // dishIDCol
            // 
            this.dishIDCol.DataPropertyName = "ID";
            this.dishIDCol.HeaderText = "ID";
            this.dishIDCol.Name = "dishIDCol";
            this.dishIDCol.Width = 40;
            // 
            // DishName
            // 
            this.DishName.DataPropertyName = "Name";
            this.DishName.HeaderText = "Tên món";
            this.DishName.Name = "DishName";
            this.DishName.Width = 150;
            // 
            // priceCol
            // 
            this.priceCol.DataPropertyName = "Price";
            this.priceCol.HeaderText = "Giá";
            this.priceCol.Name = "priceCol";
            // 
            // categoryCol
            // 
            this.categoryCol.DataPropertyName = "CateName";
            this.categoryCol.HeaderText = "Category";
            this.categoryCol.Name = "categoryCol";
            this.categoryCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(BestGrill.Model.Dish);
            // 
            // tbCategory
            // 
            this.tbCategory.Controls.Add(this.panel2);
            this.tbCategory.Controls.Add(this.dvCate);
            this.tbCategory.Location = new System.Drawing.Point(4, 22);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategory.Size = new System.Drawing.Size(782, 467);
            this.tbCategory.TabIndex = 1;
            this.tbCategory.Text = "Danh mục";
            this.tbCategory.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnDeleteCate);
            this.panel2.Controls.Add(this.btnEditCate);
            this.panel2.Controls.Add(this.btnAddCate);
            this.panel2.Controls.Add(this.tbCateName);
            this.panel2.Controls.Add(this.tbCateId);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(377, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 302);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteCate
            // 
            this.btnDeleteCate.Location = new System.Drawing.Point(233, 209);
            this.btnDeleteCate.Name = "btnDeleteCate";
            this.btnDeleteCate.Size = new System.Drawing.Size(75, 35);
            this.btnDeleteCate.TabIndex = 6;
            this.btnDeleteCate.Text = "Xóa ";
            this.btnDeleteCate.UseVisualStyleBackColor = true;
            this.btnDeleteCate.Click += new System.EventHandler(this.btnDeleteCate_Click);
            // 
            // btnEditCate
            // 
            this.btnEditCate.Location = new System.Drawing.Point(127, 209);
            this.btnEditCate.Name = "btnEditCate";
            this.btnEditCate.Size = new System.Drawing.Size(85, 35);
            this.btnEditCate.TabIndex = 5;
            this.btnEditCate.Text = "Sửa";
            this.btnEditCate.UseVisualStyleBackColor = true;
            this.btnEditCate.Click += new System.EventHandler(this.btnEditCate_Click);
            // 
            // btnAddCate
            // 
            this.btnAddCate.Location = new System.Drawing.Point(18, 209);
            this.btnAddCate.Name = "btnAddCate";
            this.btnAddCate.Size = new System.Drawing.Size(93, 35);
            this.btnAddCate.TabIndex = 4;
            this.btnAddCate.Text = "Thêm danh mục";
            this.btnAddCate.UseVisualStyleBackColor = true;
            this.btnAddCate.Click += new System.EventHandler(this.btnAddCate_Click);
            // 
            // tbCateName
            // 
            this.tbCateName.Location = new System.Drawing.Point(133, 80);
            this.tbCateName.Name = "tbCateName";
            this.tbCateName.Size = new System.Drawing.Size(117, 20);
            this.tbCateName.TabIndex = 3;
            // 
            // tbCateId
            // 
            this.tbCateId.Enabled = false;
            this.tbCateId.Location = new System.Drawing.Point(133, 28);
            this.tbCateId.Name = "tbCateId";
            this.tbCateId.Size = new System.Drawing.Size(117, 20);
            this.tbCateId.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên danh mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            // 
            // dvCate
            // 
            this.dvCate.AutoGenerateColumns = false;
            this.dvCate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cateIdDv,
            this.cateNameDv});
            this.dvCate.DataSource = this.categoryBindingSource;
            this.dvCate.Location = new System.Drawing.Point(23, 33);
            this.dvCate.Name = "dvCate";
            this.dvCate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCate.Size = new System.Drawing.Size(274, 150);
            this.dvCate.TabIndex = 0;
            this.dvCate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvCate_CellClick);
            // 
            // cateIdDv
            // 
            this.cateIdDv.DataPropertyName = "ID";
            this.cateIdDv.HeaderText = "ID";
            this.cateIdDv.Name = "cateIdDv";
            this.cateIdDv.Width = 50;
            // 
            // cateNameDv
            // 
            this.cateNameDv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cateNameDv.DataPropertyName = "Name";
            this.cateNameDv.HeaderText = "Tên danh mục";
            this.cateNameDv.Name = "cateNameDv";
            // 
            // tbIncome
            // 
            this.tbIncome.Controls.Add(this.lbTotalBill);
            this.tbIncome.Controls.Add(this.label9);
            this.tbIncome.Controls.Add(this.btnAnalytics);
            this.tbIncome.Controls.Add(this.dvProfit);
            this.tbIncome.Controls.Add(this.label8);
            this.tbIncome.Controls.Add(this.dtpTo);
            this.tbIncome.Controls.Add(this.label7);
            this.tbIncome.Controls.Add(this.dtpFrom);
            this.tbIncome.Location = new System.Drawing.Point(4, 22);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tbIncome.Size = new System.Drawing.Size(782, 467);
            this.tbIncome.TabIndex = 3;
            this.tbIncome.Text = "Doanh thu";
            this.tbIncome.UseVisualStyleBackColor = true;
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Location = new System.Drawing.Point(486, 381);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(0, 13);
            this.lbTotalBill.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(427, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tổng : ";
            // 
            // btnAnalytics
            // 
            this.btnAnalytics.Location = new System.Drawing.Point(589, 41);
            this.btnAnalytics.Name = "btnAnalytics";
            this.btnAnalytics.Size = new System.Drawing.Size(75, 23);
            this.btnAnalytics.TabIndex = 5;
            this.btnAnalytics.Text = "Thống kê";
            this.btnAnalytics.UseVisualStyleBackColor = true;
            this.btnAnalytics.Click += new System.EventHandler(this.btnAnalytics_Click);
            // 
            // dvProfit
            // 
            this.dvProfit.AutoGenerateColumns = false;
            this.dvProfit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvProfit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.tableIdDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn});
            this.dvProfit.DataSource = this.billBindingSource;
            this.dvProfit.Location = new System.Drawing.Point(63, 111);
            this.dvProfit.Name = "dvProfit";
            this.dvProfit.Size = new System.Drawing.Size(601, 242);
            this.dvProfit.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "STT";
            this.ID.Name = "ID";
            // 
            // tableIdDataGridViewTextBoxColumn
            // 
            this.tableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId";
            this.tableIdDataGridViewTextBoxColumn.HeaderText = "Bàn";
            this.tableIdDataGridViewTextBoxColumn.Name = "tableIdDataGridViewTextBoxColumn";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Giảm giá";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "Created_at";
            this.createdatDataGridViewTextBoxColumn.HeaderText = "Ngày thanh toán";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(BestGrill.Model.Bill);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Đến";
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(351, 41);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Từ";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(101, 40);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            this.dtpFrom.Value = new System.DateTime(2018, 4, 9, 0, 0, 0, 0);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tên món";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tên Bàn";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Ngày xuất hóa đơn";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Hóa đơn";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // AdminUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 508);
            this.Controls.Add(this.tbManage);
            this.Name = "AdminUi";
            this.Text = "Giao diện quản lý";
            this.Load += new System.EventHandler(this.AdminUi_Load);
            this.tbManage.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvDishAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            this.tbCategory.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCate)).EndInit();
            this.tbIncome.ResumeLayout(false);
            this.tbIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbManage;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tbCategory;
        private System.Windows.Forms.TabPage tbIncome;
        private System.Windows.Forms.DataGridView dvDishAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.Button btnEditDish;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.ComboBox cbDishCategory;
        private System.Windows.Forms.TextBox tbDishPrice;
        private System.Windows.Forms.TextBox tbDishName;
        private System.Windows.Forms.TextBox tbDishID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dvCate;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbCateName;
        private System.Windows.Forms.TextBox tbCateId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCate;
        private System.Windows.Forms.Button btnDeleteCate;
        private System.Windows.Forms.Button btnEditCate;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dvProfit;
        private System.Windows.Forms.Button btnAnalytics;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateIdDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateNameDv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
    }
}
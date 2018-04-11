namespace BestGrill
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pListTable = new System.Windows.Forms.Panel();
            this.fltb = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshListTable = new System.Windows.Forms.Button();
            this.pMenus = new System.Windows.Forms.Panel();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.cbEmptyTable = new System.Windows.Forms.ComboBox();
            this.lbDishSelected = new System.Windows.Forms.Label();
            this.dvDish = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.numDish = new System.Windows.Forms.NumericUpDown();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.pBill = new System.Windows.Forms.Panel();
            this.lbEmptyBill = new System.Windows.Forms.Label();
            this.dvBill = new System.Windows.Forms.DataGridView();
            this.dishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbTableSelected = new System.Windows.Forms.Label();
            this.tblResult = new System.Windows.Forms.TableLayoutPanel();
            this.lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.lbVat = new System.Windows.Forms.Label();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pListTable.SuspendLayout();
            this.pMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDish)).BeginInit();
            this.pBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billItemBindingSource)).BeginInit();
            this.tblResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // pListTable
            // 
            this.pListTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pListTable.Controls.Add(this.fltb);
            this.pListTable.Controls.Add(this.btnRefreshListTable);
            this.pListTable.Location = new System.Drawing.Point(12, 27);
            this.pListTable.Name = "pListTable";
            this.pListTable.Size = new System.Drawing.Size(327, 476);
            this.pListTable.TabIndex = 1;
            // 
            // fltb
            // 
            this.fltb.Location = new System.Drawing.Point(4, 40);
            this.fltb.Name = "fltb";
            this.fltb.Size = new System.Drawing.Size(318, 429);
            this.fltb.TabIndex = 1;
            // 
            // btnRefreshListTable
            // 
            this.btnRefreshListTable.Location = new System.Drawing.Point(247, 3);
            this.btnRefreshListTable.Name = "btnRefreshListTable";
            this.btnRefreshListTable.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshListTable.TabIndex = 0;
            this.btnRefreshListTable.Text = "Refresh";
            this.btnRefreshListTable.UseVisualStyleBackColor = true;
            this.btnRefreshListTable.Click += new System.EventHandler(this.btnRefreshListTable_Click);
            // 
            // pMenus
            // 
            this.pMenus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pMenus.Controls.Add(this.btnChangeTable);
            this.pMenus.Controls.Add(this.cbEmptyTable);
            this.pMenus.Controls.Add(this.lbDishSelected);
            this.pMenus.Controls.Add(this.dvDish);
            this.pMenus.Controls.Add(this.label1);
            this.pMenus.Controls.Add(this.cbCategory);
            this.pMenus.Controls.Add(this.numDish);
            this.pMenus.Controls.Add(this.btnAddDish);
            this.pMenus.Location = new System.Drawing.Point(370, 27);
            this.pMenus.Name = "pMenus";
            this.pMenus.Size = new System.Drawing.Size(286, 476);
            this.pMenus.TabIndex = 2;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Location = new System.Drawing.Point(174, 339);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(75, 23);
            this.btnChangeTable.TabIndex = 8;
            this.btnChangeTable.Text = "Chuyển bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.btnChangeTable_Click);
            // 
            // cbEmptyTable
            // 
            this.cbEmptyTable.FormattingEnabled = true;
            this.cbEmptyTable.Location = new System.Drawing.Point(52, 339);
            this.cbEmptyTable.Name = "cbEmptyTable";
            this.cbEmptyTable.Size = new System.Drawing.Size(93, 21);
            this.cbEmptyTable.TabIndex = 7;
            // 
            // lbDishSelected
            // 
            this.lbDishSelected.AutoSize = true;
            this.lbDishSelected.Location = new System.Drawing.Point(49, 379);
            this.lbDishSelected.Name = "lbDishSelected";
            this.lbDishSelected.Size = new System.Drawing.Size(34, 13);
            this.lbDishSelected.TabIndex = 5;
            this.lbDishSelected.Text = "Món :";
            // 
            // dvDish
            // 
            this.dvDish.AutoGenerateColumns = false;
            this.dvDish.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvDish.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDish.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dvDish.DataSource = this.dishBindingSource;
            this.dvDish.Location = new System.Drawing.Point(18, 63);
            this.dvDish.Name = "dvDish";
            this.dvDish.ReadOnly = true;
            this.dvDish.RowHeadersVisible = false;
            this.dvDish.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDish.Size = new System.Drawing.Size(247, 260);
            this.dvDish.TabIndex = 4;
            this.dvDish.SelectionChanged += new System.EventHandler(this.dvDish_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 127.3885F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 72.61147F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(BestGrill.Model.Dish);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh Mục";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(85, 12);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(180, 21);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // numDish
            // 
            this.numDish.Location = new System.Drawing.Point(174, 377);
            this.numDish.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numDish.Name = "numDish";
            this.numDish.Size = new System.Drawing.Size(57, 20);
            this.numDish.TabIndex = 1;
            this.numDish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDish.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDish.Image = ((System.Drawing.Image)(resources.GetObject("btnAddDish.Image")));
            this.btnAddDish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDish.Location = new System.Drawing.Point(52, 416);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(179, 42);
            this.btnAddDish.TabIndex = 0;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // pBill
            // 
            this.pBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pBill.Controls.Add(this.lbEmptyBill);
            this.pBill.Controls.Add(this.dvBill);
            this.pBill.Controls.Add(this.lbTableSelected);
            this.pBill.Controls.Add(this.tblResult);
            this.pBill.Controls.Add(this.btnPrintBill);
            this.pBill.Controls.Add(this.btnPay);
            this.pBill.Location = new System.Drawing.Point(676, 27);
            this.pBill.Name = "pBill";
            this.pBill.Size = new System.Drawing.Size(258, 476);
            this.pBill.TabIndex = 3;
            // 
            // lbEmptyBill
            // 
            this.lbEmptyBill.AutoSize = true;
            this.lbEmptyBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmptyBill.Location = new System.Drawing.Point(43, 72);
            this.lbEmptyBill.Name = "lbEmptyBill";
            this.lbEmptyBill.Size = new System.Drawing.Size(158, 17);
            this.lbEmptyBill.TabIndex = 6;
            this.lbEmptyBill.Text = "Chưa có bàn được chọn";
            // 
            // dvBill
            // 
            this.dvBill.AllowUserToAddRows = false;
            this.dvBill.AllowUserToDeleteRows = false;
            this.dvBill.AutoGenerateColumns = false;
            this.dvBill.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dvBill.DataSource = this.billItemBindingSource;
            this.dvBill.Location = new System.Drawing.Point(9, 40);
            this.dvBill.Name = "dvBill";
            this.dvBill.ReadOnly = true;
            this.dvBill.RowHeadersVisible = false;
            this.dvBill.Size = new System.Drawing.Size(240, 215);
            this.dvBill.TabIndex = 5;
            // 
            // dishNameDataGridViewTextBoxColumn
            // 
            this.dishNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dishNameDataGridViewTextBoxColumn.DataPropertyName = "DishName";
            this.dishNameDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.dishNameDataGridViewTextBoxColumn.Name = "dishNameDataGridViewTextBoxColumn";
            this.dishNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "SL";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Width = 40;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Tổng";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 50;
            // 
            // billItemBindingSource
            // 
            this.billItemBindingSource.DataSource = typeof(BestGrill.Model.BillItem);
            // 
            // lbTableSelected
            // 
            this.lbTableSelected.AutoSize = true;
            this.lbTableSelected.Location = new System.Drawing.Point(18, 16);
            this.lbTableSelected.Name = "lbTableSelected";
            this.lbTableSelected.Size = new System.Drawing.Size(0, 13);
            this.lbTableSelected.TabIndex = 4;
            // 
            // tblResult
            // 
            this.tblResult.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tblResult.ColumnCount = 2;
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblResult.Controls.Add(this.lb, 0, 0);
            this.tblResult.Controls.Add(this.label3, 0, 1);
            this.tblResult.Controls.Add(this.label4, 0, 2);
            this.tblResult.Controls.Add(this.label5, 0, 3);
            this.tblResult.Controls.Add(this.lbTotal, 1, 3);
            this.tblResult.Controls.Add(this.lbSubTotal, 1, 0);
            this.tblResult.Controls.Add(this.lbVat, 1, 1);
            this.tblResult.Controls.Add(this.lbDiscount, 1, 2);
            this.tblResult.Location = new System.Drawing.Point(13, 275);
            this.tblResult.Name = "tblResult";
            this.tblResult.RowCount = 4;
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblResult.Size = new System.Drawing.Size(233, 71);
            this.tblResult.TabIndex = 3;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(5, 2);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(52, 13);
            this.lb.TabIndex = 0;
            this.lb.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thuế VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giảm giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thành tiền";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(120, 53);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(13, 13);
            this.lbTotal.TabIndex = 7;
            this.lbTotal.Text = "0";
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Location = new System.Drawing.Point(120, 2);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(13, 13);
            this.lbSubTotal.TabIndex = 4;
            this.lbSubTotal.Text = "0";
            this.lbSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVat
            // 
            this.lbVat.AutoSize = true;
            this.lbVat.Location = new System.Drawing.Point(120, 19);
            this.lbVat.Name = "lbVat";
            this.lbVat.Size = new System.Drawing.Size(30, 13);
            this.lbVat.TabIndex = 5;
            this.lbVat.Text = "10 %";
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(120, 36);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(13, 13);
            this.lbDiscount.TabIndex = 6;
            this.lbDiscount.Text = "0";
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintBill.Image")));
            this.btnPrintBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBill.Location = new System.Drawing.Point(46, 407);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(166, 38);
            this.btnPrintBill.TabIndex = 1;
            this.btnPrintBill.Text = "In Hóa đơn";
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnPay
            // 
            this.btnPay.Image = ((System.Drawing.Image)(resources.GetObject("btnPay.Image")));
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(46, 370);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(166, 31);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 540);
            this.Controls.Add(this.pBill);
            this.Controls.Add(this.pMenus);
            this.Controls.Add(this.pListTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pListTable.ResumeLayout(false);
            this.pMenus.ResumeLayout(false);
            this.pMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDish)).EndInit();
            this.pBill.ResumeLayout(false);
            this.pBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billItemBindingSource)).EndInit();
            this.tblResult.ResumeLayout(false);
            this.tblResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.Panel pListTable;
        private System.Windows.Forms.Panel pMenus;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Panel pBill;
        private System.Windows.Forms.NumericUpDown numDish;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRefreshListTable;
        private System.Windows.Forms.TableLayoutPanel tblResult;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel fltb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dvDish;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private System.Windows.Forms.Label lbTableSelected;
        private System.Windows.Forms.Label lbDishSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dvBill;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbVat;
        private System.Windows.Forms.Label lbEmptyBill;
        private System.Windows.Forms.BindingSource billItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbEmptyTable;
        private System.Windows.Forms.Button btnChangeTable;
    }
}


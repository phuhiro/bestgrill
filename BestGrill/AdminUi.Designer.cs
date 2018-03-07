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
            this.tabDish = new System.Windows.Forms.TabPage();
            this.tbIncome = new System.Windows.Forms.TabPage();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbManage.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDishAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbManage
            // 
            this.tbManage.Controls.Add(this.tabMenu);
            this.tbManage.Controls.Add(this.tbCategory);
            this.tbManage.Controls.Add(this.tabDish);
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
            // 
            // btnEditDish
            // 
            this.btnEditDish.Location = new System.Drawing.Point(115, 292);
            this.btnEditDish.Name = "btnEditDish";
            this.btnEditDish.Size = new System.Drawing.Size(75, 37);
            this.btnEditDish.TabIndex = 9;
            this.btnEditDish.Text = "Sửa món";
            this.btnEditDish.UseVisualStyleBackColor = true;
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
            this.cbDishCategory.FormattingEnabled = true;
            this.cbDishCategory.Location = new System.Drawing.Point(125, 153);
            this.cbDishCategory.Name = "cbDishCategory";
            this.cbDishCategory.Size = new System.Drawing.Size(144, 21);
            this.cbDishCategory.TabIndex = 7;
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
            this.dvDishAdmin.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
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
            this.categoryCol.DataPropertyName = "Category";
            this.categoryCol.HeaderText = "Category";
            this.categoryCol.Name = "categoryCol";
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataSource = typeof(BestGrill.Model.Dish);
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(4, 22);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategory.Size = new System.Drawing.Size(782, 467);
            this.tbCategory.TabIndex = 1;
            this.tbCategory.Text = "Danh mục";
            this.tbCategory.UseVisualStyleBackColor = true;
            // 
            // tabDish
            // 
            this.tabDish.Location = new System.Drawing.Point(4, 22);
            this.tabDish.Name = "tabDish";
            this.tabDish.Padding = new System.Windows.Forms.Padding(3);
            this.tabDish.Size = new System.Drawing.Size(782, 467);
            this.tabDish.TabIndex = 2;
            this.tabDish.Text = "Bàn ăn";
            this.tabDish.UseVisualStyleBackColor = true;
            // 
            // tbIncome
            // 
            this.tbIncome.Location = new System.Drawing.Point(4, 22);
            this.tbIncome.Name = "tbIncome";
            this.tbIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tbIncome.Size = new System.Drawing.Size(782, 467);
            this.tbIncome.TabIndex = 3;
            this.tbIncome.Text = "Doanh thu";
            this.tbIncome.UseVisualStyleBackColor = true;
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
            // AdminUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 508);
            this.Controls.Add(this.tbManage);
            this.Name = "AdminUi";
            this.Text = "Giao diện quản lý";
            this.Load += new System.EventHandler(this.AdminUi_Load);
            this.tbManage.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDishAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbManage;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tbCategory;
        private System.Windows.Forms.TabPage tabDish;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dishIDCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryCol;
    }
}
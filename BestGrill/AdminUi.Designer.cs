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
            this.tbManage = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.tbCategory = new System.Windows.Forms.TabPage();
            this.tabDish = new System.Windows.Forms.TabPage();
            this.tbIncome = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDishID = new System.Windows.Forms.TextBox();
            this.tbDishName = new System.Windows.Forms.TextBox();
            this.tbDishPrice = new System.Windows.Forms.TextBox();
            this.cbDishCategory = new System.Windows.Forms.ComboBox();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.btnEditDish = new System.Windows.Forms.Button();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.tbManage.SuspendLayout();
            this.tabMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tabMenu.Controls.Add(this.dataGridView1);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(782, 467);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Thực đơn";
            this.tabMenu.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 386);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh mục";
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
            // tbDishID
            // 
            this.tbDishID.Enabled = false;
            this.tbDishID.Location = new System.Drawing.Point(125, 32);
            this.tbDishID.Name = "tbDishID";
            this.tbDishID.Size = new System.Drawing.Size(144, 20);
            this.tbDishID.TabIndex = 4;
            // 
            // tbDishName
            // 
            this.tbDishName.Location = new System.Drawing.Point(125, 84);
            this.tbDishName.Name = "tbDishName";
            this.tbDishName.Size = new System.Drawing.Size(144, 20);
            this.tbDishName.TabIndex = 5;
            // 
            // tbDishPrice
            // 
            this.tbDishPrice.Location = new System.Drawing.Point(125, 214);
            this.tbDishPrice.Name = "tbDishPrice";
            this.tbDishPrice.Size = new System.Drawing.Size(144, 20);
            this.tbDishPrice.TabIndex = 6;
            // 
            // cbDishCategory
            // 
            this.cbDishCategory.FormattingEnabled = true;
            this.cbDishCategory.Location = new System.Drawing.Point(125, 153);
            this.cbDishCategory.Name = "cbDishCategory";
            this.cbDishCategory.Size = new System.Drawing.Size(144, 21);
            this.cbDishCategory.TabIndex = 7;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(14, 292);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(75, 38);
            this.btnAddDish.TabIndex = 8;
            this.btnAddDish.Text = "Thêm món";
            this.btnAddDish.UseVisualStyleBackColor = true;
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
            // btnDeleteDish
            // 
            this.btnDeleteDish.Location = new System.Drawing.Point(207, 292);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(75, 37);
            this.btnDeleteDish.TabIndex = 10;
            this.btnDeleteDish.Text = "Xóa món";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            // 
            // AdminUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 508);
            this.Controls.Add(this.tbManage);
            this.Name = "AdminUi";
            this.Text = "Giao diện quản lý";
            this.tbManage.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbManage;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.TabPage tbCategory;
        private System.Windows.Forms.TabPage tabDish;
        private System.Windows.Forms.TabPage tbIncome;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}
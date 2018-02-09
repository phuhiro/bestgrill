namespace BestGrill
{
    partial class Admin
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
            this.adminManage = new System.Windows.Forms.TabControl();
            this.tbMenus = new System.Windows.Forms.TabPage();
            this.tbCategory = new System.Windows.Forms.TabPage();
            this.tbInsight = new System.Windows.Forms.TabPage();
            this.tbTables = new System.Windows.Forms.TabPage();
            this.adminManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminManage
            // 
            this.adminManage.Controls.Add(this.tbMenus);
            this.adminManage.Controls.Add(this.tbCategory);
            this.adminManage.Controls.Add(this.tbInsight);
            this.adminManage.Controls.Add(this.tbTables);
            this.adminManage.Location = new System.Drawing.Point(13, 13);
            this.adminManage.Name = "adminManage";
            this.adminManage.SelectedIndex = 0;
            this.adminManage.Size = new System.Drawing.Size(870, 514);
            this.adminManage.TabIndex = 0;
            // 
            // tbMenus
            // 
            this.tbMenus.Location = new System.Drawing.Point(4, 22);
            this.tbMenus.Name = "tbMenus";
            this.tbMenus.Padding = new System.Windows.Forms.Padding(3);
            this.tbMenus.Size = new System.Drawing.Size(862, 488);
            this.tbMenus.TabIndex = 0;
            this.tbMenus.Text = "Quản lý Menu";
            this.tbMenus.UseVisualStyleBackColor = true;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(4, 22);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tbCategory.Size = new System.Drawing.Size(862, 488);
            this.tbCategory.TabIndex = 1;
            this.tbCategory.Text = "Quản lý danh mục";
            this.tbCategory.UseVisualStyleBackColor = true;
            // 
            // tbInsight
            // 
            this.tbInsight.Location = new System.Drawing.Point(4, 22);
            this.tbInsight.Name = "tbInsight";
            this.tbInsight.Padding = new System.Windows.Forms.Padding(3);
            this.tbInsight.Size = new System.Drawing.Size(862, 488);
            this.tbInsight.TabIndex = 2;
            this.tbInsight.Text = "Quản lý doanh thu ";
            this.tbInsight.UseVisualStyleBackColor = true;
            // 
            // tbTables
            // 
            this.tbTables.Location = new System.Drawing.Point(4, 22);
            this.tbTables.Name = "tbTables";
            this.tbTables.Padding = new System.Windows.Forms.Padding(3);
            this.tbTables.Size = new System.Drawing.Size(862, 488);
            this.tbTables.TabIndex = 3;
            this.tbTables.Text = "Quản lý bàn";
            this.tbTables.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 529);
            this.Controls.Add(this.adminManage);
            this.Name = "Admin";
            this.Text = "Admin";
            this.adminManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminManage;
        private System.Windows.Forms.TabPage tbMenus;
        private System.Windows.Forms.TabPage tbCategory;
        private System.Windows.Forms.TabPage tbInsight;
        private System.Windows.Forms.TabPage tbTables;
    }
}
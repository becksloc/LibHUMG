namespace LibHUMG
{
    partial class frmCuonSach_List
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
            this.lvwdausach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvwdausach
            // 
            this.lvwdausach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwdausach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvwdausach.FullRowSelect = true;
            this.lvwdausach.GridLines = true;
            this.lvwdausach.Location = new System.Drawing.Point(0, 151);
            this.lvwdausach.Name = "lvwdausach";
            this.lvwdausach.Size = new System.Drawing.Size(875, 291);
            this.lvwdausach.TabIndex = 51;
            this.lvwdausach.UseCompatibleStateImageBehavior = false;
            this.lvwdausach.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Đầu Sách ID";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Đầu Sách";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên Tác Giả";
            this.columnHeader3.Width = 82;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tên Nxb";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên Thể Loại";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên Sách";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tóm Tắt";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Từ Khóa";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Thời Hạn";
            this.columnHeader9.Width = 25;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Tổng Lượt Mượn";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Số Cuốn Còn";
            // 
            // frmCuonSach_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 442);
            this.Controls.Add(this.lvwdausach);
            this.Name = "frmCuonSach_List";
            this.Text = "frmCuonSach_List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwdausach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}
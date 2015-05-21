namespace LibHUMG
{
    partial class frmDocGia_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.dgvdocgia = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mã hoặc Tên độc giả:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(202, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(276, 20);
            this.txtSearch.TabIndex = 33;
            // 
            // btnthoat
            // 
            this.btnthoat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnthoat.Location = new System.Drawing.Point(724, 20);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(48, 34);
            this.btnthoat.TabIndex = 32;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(649, 20);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(48, 34);
            this.btnxoa.TabIndex = 31;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(569, 20);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(48, 34);
            this.btnsua.TabIndex = 30;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(489, 20);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(48, 34);
            this.btnthem.TabIndex = 29;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // dgvdocgia
            // 
            this.dgvdocgia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdocgia.Location = new System.Drawing.Point(77, 60);
            this.dgvdocgia.Name = "dgvdocgia";
            this.dgvdocgia.Size = new System.Drawing.Size(720, 401);
            this.dgvdocgia.TabIndex = 28;
            // 
            // frmDocGia_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dgvdocgia);
            this.Name = "frmDocGia_List";
            this.Text = "frmDocGia_List";
            this.Load += new System.EventHandler(this.frmDocGia_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdocgia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.DataGridView dgvdocgia;
    }
}
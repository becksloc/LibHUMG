using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibHUMG.BusinessLogic;
using LibHUMG.BusinessObjects;

namespace LibHUMG
{
    public partial class frmDocGia_List : Form
    {
        public frmDocGia_List()
        {
            InitializeComponent();
        }

        private void frmDocGia_List_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        public void LoadForm()
        {
            DocGiaBL objDocGiaBL = new DocGiaBL();
            List<DocGia> lstDocGia = objDocGiaBL.GetList();
            dgvdocgia.DataSource = lstDocGia;
            string[] columns = { "DocGiaID", "MaDocGia", "HoTen", "NgaySinh", "QueQuan", "", "DienThoai", "Email", "NgayDangKy", "NgayTaoThe", "Hansd", "TrangThai", "Username", "Password" };
            ControlFormat.DataGridViewFormat(dgvdocgia, columns);
        }
    }
}

using System;
using System.Windows.Forms;
using AnimalManagement.Class;

namespace AnimalManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frmDMChatLieu = new frmDMChatLieu();
            frmDMChatLieu.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frmDMNhanVien = new frmDMNhanVien();
            frmDMNhanVien.MdiParent = this;
            frmDMNhanVien.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frmDMKhachHang = new frmDMKhachHang();
            frmDMKhachHang.MdiParent = this;
            frmDMKhachHang.Show();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frmDMHangHoa = new frmDMHangHoa();
            frmDMHangHoa.MdiParent = this;
            frmDMHangHoa.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frmHoaDonBan = new frmHoaDonBan();
            frmHoaDonBan.MdiParent = this;
            frmHoaDonBan.Show();

        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void mnuFindHang_Click(object sender, EventArgs e)
        {

        }

        private void mnuFindKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void mnuBCHangTon_Click(object sender, EventArgs e)
        {

        }

        private void mnuBCDoanhThu_Click(object sender, EventArgs e)
        {

        }

        private void mnuHienTroGiup_Click(object sender, EventArgs e)
        {

        }
    }
}

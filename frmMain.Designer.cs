namespace AnimalManagement
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tệpTinToolStripMenuItem = new ToolStripMenuItem();
            mnuFile = new ToolStripMenuItem();
            mnuThoat = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            mnuChatLieu = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            mnuKhachHang = new ToolStripMenuItem();
            mnuHangHoa = new ToolStripMenuItem();
            mnuHoaDon = new ToolStripMenuItem();
            mnuHoaDonBan = new ToolStripMenuItem();
            mnuTimKiem = new ToolStripMenuItem();
            mnuFindHoaDon = new ToolStripMenuItem();
            mnuFindHang = new ToolStripMenuItem();
            mnuFindKhachHang = new ToolStripMenuItem();
            hàngToolStripMenuItem1 = new ToolStripMenuItem();
            mnuBaoCao = new ToolStripMenuItem();
            mnuBCHangTon = new ToolStripMenuItem();
            mnuBCDoanhThu = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuHienTroGiup = new ToolStripMenuItem();
            mnuVaiNet = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpTinToolStripMenuItem, mnuFile, danhMụcToolStripMenuItem, mnuHoaDon, mnuTimKiem, mnuBaoCao, mnuTroGiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpTinToolStripMenuItem
            // 
            tệpTinToolStripMenuItem.Name = "tệpTinToolStripMenuItem";
            tệpTinToolStripMenuItem.Size = new Size(14, 24);
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(69, 24);
            mnuFile.Text = "Tệp tin";
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.Size = new Size(130, 26);
            mnuThoat.Text = "Thoát";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuChatLieu, mnuNhanVien, mnuKhachHang, mnuHangHoa });
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(90, 24);
            danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // mnuChatLieu
            // 
            mnuChatLieu.Name = "mnuChatLieu";
            mnuChatLieu.Size = new Size(169, 26);
            mnuChatLieu.Text = "Chất liệu";
            mnuChatLieu.Click += mnuChatLieu_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(169, 26);
            mnuNhanVien.Text = "Nhân viên";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(169, 26);
            mnuKhachHang.Text = "Khách hàng";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuHangHoa
            // 
            mnuHangHoa.Name = "mnuHangHoa";
            mnuHangHoa.Size = new Size(169, 26);
            mnuHangHoa.Text = "Hàng hóa";
            mnuHangHoa.Click += mnuHangHoa_Click;
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.DropDownItems.AddRange(new ToolStripItem[] { mnuHoaDonBan });
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(81, 24);
            mnuHoaDon.Text = "Hóa đơn";
            // 
            // mnuHoaDonBan
            // 
            mnuHoaDonBan.Name = "mnuHoaDonBan";
            mnuHoaDonBan.Size = new Size(224, 26);
            mnuHoaDonBan.Text = "Hóa đơn bán";
            mnuHoaDonBan.Click += mnuHoaDonBan_Click;
            // 
            // mnuTimKiem
            // 
            mnuTimKiem.DropDownItems.AddRange(new ToolStripItem[] { mnuFindHoaDon, mnuFindHang, mnuFindKhachHang, hàngToolStripMenuItem1 });
            mnuTimKiem.Name = "mnuTimKiem";
            mnuTimKiem.Size = new Size(84, 24);
            mnuTimKiem.Text = "Tìm kiếm";
            // 
            // mnuFindHoaDon
            // 
            mnuFindHoaDon.Name = "mnuFindHoaDon";
            mnuFindHoaDon.Size = new Size(224, 26);
            mnuFindHoaDon.Text = "Hoá đơn";
            mnuFindHoaDon.Click += mnuFindHoaDon_Click;
            // 
            // mnuFindHang
            // 
            mnuFindHang.Name = "mnuFindHang";
            mnuFindHang.Size = new Size(224, 26);
            mnuFindHang.Text = "Hàng";
            mnuFindHang.Click += mnuFindHang_Click;
            // 
            // mnuFindKhachHang
            // 
            mnuFindKhachHang.Name = "mnuFindKhachHang";
            mnuFindKhachHang.Size = new Size(224, 26);
            mnuFindKhachHang.Text = "Khách hàng";
            mnuFindKhachHang.Click += mnuFindKhachHang_Click;
            // 
            // hàngToolStripMenuItem1
            // 
            hàngToolStripMenuItem1.Name = "hàngToolStripMenuItem1";
            hàngToolStripMenuItem1.Size = new Size(169, 26);
            // 
            // mnuBaoCao
            // 
            mnuBaoCao.DropDownItems.AddRange(new ToolStripItem[] { mnuBCHangTon, mnuBCDoanhThu });
            mnuBaoCao.Name = "mnuBaoCao";
            mnuBaoCao.Size = new Size(77, 24);
            mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuBCHangTon
            // 
            mnuBCHangTon.Name = "mnuBCHangTon";
            mnuBCHangTon.Size = new Size(224, 26);
            mnuBCHangTon.Text = "Hàng tồn";
            mnuBCHangTon.Click += mnuBCHangTon_Click;
            // 
            // mnuBCDoanhThu
            // 
            mnuBCDoanhThu.Name = "mnuBCDoanhThu";
            mnuBCDoanhThu.Size = new Size(224, 26);
            mnuBCDoanhThu.Text = "Doanh thu";
            mnuBCDoanhThu.Click += mnuBCDoanhThu_Click;
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuHienTroGiup, mnuVaiNet });
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(78, 24);
            mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuHienTroGiup
            // 
            mnuHienTroGiup.Name = "mnuHienTroGiup";
            mnuHienTroGiup.Size = new Size(224, 26);
            mnuHienTroGiup.Text = "Trợ giúp";
            mnuHienTroGiup.Click += mnuHienTroGiup_Click;
            // 
            // mnuVaiNet
            // 
            mnuVaiNet.Name = "mnuVaiNet";
            mnuVaiNet.Size = new Size(147, 26);
            mnuVaiNet.Text = "Vài nét";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Chương trình quản lý bán động vật";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpTinToolStripMenuItem;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem mnuChatLieu;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuHangHoa;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuHoaDonBan;
        private ToolStripMenuItem mnuTimKiem;
        private ToolStripMenuItem mnuFindHoaDon;
        private ToolStripMenuItem mnuFindHang;
        private ToolStripMenuItem mnuFindKhachHang;
        private ToolStripMenuItem hàngToolStripMenuItem1;
        private ToolStripMenuItem mnuBaoCao;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripMenuItem mnuBCHangTon;
        private ToolStripMenuItem mnuBCDoanhThu;
        private ToolStripMenuItem mnuHienTroGiup;
        private ToolStripMenuItem mnuVaiNet;
    }
}

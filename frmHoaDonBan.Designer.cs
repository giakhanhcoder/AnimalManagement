namespace AnimalManagement
{
    partial class frmHoaDonBan
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
            panel1 = new Panel();
            btnTimKiem = new Button();
            cboMaHDBan = new ComboBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            cboMaKhach = new ComboBox();
            txtDiaChi = new TextBox();
            txtTenKhach = new TextBox();
            txtDienThoai = new MaskedTextBox();
            txtTenNhanVien = new TextBox();
            cboMaNhanVien = new ComboBox();
            txtNgayBan = new DateTimePicker();
            txtMaHDBan = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvHDBanHang = new DataGridView();
            pa = new Panel();
            txtTongTien = new TextBox();
            label18 = new Label();
            lblBangChu = new Label();
            label17 = new Label();
            panel3 = new Panel();
            txtThanhTien = new TextBox();
            label16 = new Label();
            txtGiamGia = new TextBox();
            label15 = new Label();
            txtSoLuong = new TextBox();
            label14 = new Label();
            txtDonGiaBan = new TextBox();
            label13 = new Label();
            txtTenHang = new TextBox();
            label12 = new Label();
            cboMaHang = new ComboBox();
            label11 = new Label();
            panel2 = new Panel();
            btnDong = new Button();
            btnInHoaDon = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).BeginInit();
            pa.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(cboMaHDBan);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 552);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 48);
            panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(440, 5);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(182, 31);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cboMaHDBan
            // 
            cboMaHDBan.FormattingEnabled = true;
            cboMaHDBan.Location = new Point(139, 5);
            cboMaHDBan.Margin = new Padding(3, 4, 3, 4);
            cboMaHDBan.Name = "cboMaHDBan";
            cboMaHDBan.Size = new Size(277, 28);
            cboMaHDBan.TabIndex = 1;
            cboMaHDBan.DropDown += cboMaHDBan_DropDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 11);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(914, 552);
            splitContainer1.SplitterDistance = 205;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboMaKhach);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtTenKhach);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(cboMaNhanVien);
            groupBox1.Controls.Add(txtNgayBan);
            groupBox1.Controls.Add(txtMaHDBan);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 49);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(911, 165);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // cboMaKhach
            // 
            cboMaKhach.FormattingEnabled = true;
            cboMaKhach.Location = new Point(640, 22);
            cboMaKhach.Margin = new Padding(3, 4, 3, 4);
            cboMaKhach.Name = "cboMaKhach";
            cboMaKhach.Size = new Size(186, 28);
            cboMaKhach.TabIndex = 15;
            cboMaKhach.TextChanged += cboMaKhach_TextChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(640, 91);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.ReadOnly = true;
            txtDiaChi.Size = new Size(186, 27);
            txtDiaChi.TabIndex = 14;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(640, 57);
            txtTenKhach.Margin = new Padding(3, 4, 3, 4);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.ReadOnly = true;
            txtTenKhach.Size = new Size(186, 27);
            txtTenKhach.TabIndex = 13;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(640, 127);
            txtDienThoai.Margin = new Padding(3, 4, 3, 4);
            txtDienThoai.Mask = "(999) 000-0000";
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.ReadOnly = true;
            txtDienThoai.Size = new Size(186, 27);
            txtDienThoai.TabIndex = 11;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(121, 132);
            txtTenNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.ReadOnly = true;
            txtTenNhanVien.Size = new Size(198, 27);
            txtTenNhanVien.TabIndex = 10;
            // 
            // cboMaNhanVien
            // 
            cboMaNhanVien.FormattingEnabled = true;
            cboMaNhanVien.Location = new Point(121, 97);
            cboMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            cboMaNhanVien.Name = "cboMaNhanVien";
            cboMaNhanVien.Size = new Size(199, 28);
            cboMaNhanVien.TabIndex = 9;
            cboMaNhanVien.TextChanged += cboMaNhanVien_TextChanged;
            // 
            // txtNgayBan
            // 
            txtNgayBan.Format = DateTimePickerFormat.Short;
            txtNgayBan.Location = new Point(121, 60);
            txtNgayBan.Margin = new Padding(3, 4, 3, 4);
            txtNgayBan.Name = "txtNgayBan";
            txtNgayBan.Size = new Size(199, 27);
            txtNgayBan.TabIndex = 8;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(121, 21);
            txtMaHDBan.Margin = new Padding(3, 4, 3, 4);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.ReadOnly = true;
            txtMaHDBan.Size = new Size(199, 27);
            txtMaHDBan.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(498, 136);
            label10.Name = "label10";
            label10.Size = new Size(81, 20);
            label10.TabIndex = 6;
            label10.Text = "Điện thoại:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(498, 101);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 5;
            label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(497, 68);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 4;
            label8.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(498, 28);
            label7.Name = "label7";
            label7.Size = new Size(112, 20);
            label7.TabIndex = 3;
            label7.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 136);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 0;
            label6.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 101);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 2;
            label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 68);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 1;
            label4.Text = "Ngày bán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 25);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(312, 12);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(266, 32);
            label2.TabIndex = 0;
            label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDBanHang);
            groupBox2.Controls.Add(pa);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(914, 342);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            dgvHDBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDBanHang.Dock = DockStyle.Fill;
            dgvHDBanHang.Location = new Point(3, 135);
            dgvHDBanHang.Margin = new Padding(3, 4, 3, 4);
            dgvHDBanHang.Name = "dgvHDBanHang";
            dgvHDBanHang.RowHeadersWidth = 51;
            dgvHDBanHang.Size = new Size(908, 119);
            dgvHDBanHang.TabIndex = 3;
            dgvHDBanHang.DoubleClick += dgvHDBanHang_DoubleClick;
            // 
            // pa
            // 
            pa.Controls.Add(txtTongTien);
            pa.Controls.Add(label18);
            pa.Controls.Add(lblBangChu);
            pa.Controls.Add(label17);
            pa.Dock = DockStyle.Bottom;
            pa.Location = new Point(3, 254);
            pa.Margin = new Padding(3, 4, 3, 4);
            pa.Name = "pa";
            pa.Size = new Size(908, 53);
            pa.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(715, 7);
            txtTongTien.Margin = new Padding(3, 4, 3, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(161, 27);
            txtTongTien.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(640, 7);
            label18.Name = "label18";
            label18.Size = new Size(75, 20);
            label18.TabIndex = 2;
            label18.Text = "Tổng tiền:";
            // 
            // lblBangChu
            // 
            lblBangChu.AutoSize = true;
            lblBangChu.ForeColor = Color.Blue;
            lblBangChu.Location = new Point(23, 29);
            lblBangChu.Name = "lblBangChu";
            lblBangChu.Size = new Size(74, 20);
            lblBangChu.TabIndex = 1;
            lblBangChu.Text = "Bằng chữ:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(23, 7);
            label17.Name = "label17";
            label17.Size = new Size(192, 20);
            label17.TabIndex = 0;
            label17.Text = "Nháy đúp một dòng để xóa";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtThanhTien);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(txtGiamGia);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(txtSoLuong);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(txtDonGiaBan);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtTenHang);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(cboMaHang);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 24);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(908, 111);
            panel3.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(607, 68);
            txtThanhTien.Margin = new Padding(3, 4, 3, 4);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(181, 27);
            txtThanhTien.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(511, 71);
            label16.Name = "label16";
            label16.Size = new Size(81, 20);
            label16.TabIndex = 10;
            label16.Text = "Thành tiền:";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(359, 60);
            txtGiamGia.Margin = new Padding(3, 4, 3, 4);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(138, 27);
            txtGiamGia.TabIndex = 9;
            txtGiamGia.TextChanged += txtGiamGia_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(271, 64);
            label15.Name = "label15";
            label15.Size = new Size(88, 20);
            label15.TabIndex = 8;
            label15.Text = "Giảm giá %:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(104, 57);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(138, 27);
            txtSoLuong.TabIndex = 7;
            txtSoLuong.TextChanged += txtSoLuong_TextChanged;
            txtSoLuong.KeyPress += txtSoLuong_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(34, 68);
            label14.Name = "label14";
            label14.Size = new Size(72, 20);
            label14.TabIndex = 6;
            label14.Text = "Số lượng:";
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(607, 20);
            txtDonGiaBan.Margin = new Padding(3, 4, 3, 4);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.ReadOnly = true;
            txtDonGiaBan.Size = new Size(181, 27);
            txtDonGiaBan.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(513, 20);
            label13.Name = "label13";
            label13.Size = new Size(65, 20);
            label13.TabIndex = 4;
            label13.Text = "Đơn giá:";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(359, 16);
            txtTenHang.Margin = new Padding(3, 4, 3, 4);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.ReadOnly = true;
            txtTenHang.Size = new Size(138, 27);
            txtTenHang.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(270, 20);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 2;
            label12.Text = "Tên hàng:";
            // 
            // cboMaHang
            // 
            cboMaHang.FormattingEnabled = true;
            cboMaHang.Location = new Point(104, 16);
            cboMaHang.Margin = new Padding(3, 4, 3, 4);
            cboMaHang.Name = "cboMaHang";
            cboMaHang.Size = new Size(138, 28);
            cboMaHang.TabIndex = 1;
            cboMaHang.TextChanged += cboMaHang_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 20);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 0;
            label11.Text = "Mã hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDong);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnXoa);
            panel2.Controls.Add(btnLuu);
            panel2.Controls.Add(btnThem);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 307);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(908, 31);
            panel2.TabIndex = 0;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(737, 1);
            btnDong.Margin = new Padding(3, 4, 3, 4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(125, 31);
            btnDong.TabIndex = 8;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(569, 0);
            btnInHoaDon.Margin = new Padding(3, 4, 3, 4);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(139, 31);
            btnInHoaDon.TabIndex = 6;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(370, 0);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(141, 31);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Hủy hóa đơn";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(183, 0);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(153, 31);
            btnLuu.TabIndex = 4;
            btnLuu.Text = "Lưu hóa đơn";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(7, 0);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(154, 31);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm hóa đơn";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // frmHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmHoaDonBan";
            Text = "Hóa đơn bán hàng";
            FormClosing += frmHoaDonBan_FormClosing;
            Load += frmHoaDonBan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDBanHang).EndInit();
            pa.ResumeLayout(false);
            pa.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimKiem;
        private ComboBox cboMaHDBan;
        private Label label1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtTenNhanVien;
        private ComboBox cboMaNhanVien;
        private DateTimePicker txtNgayBan;
        private TextBox txtDiaChi;
        private TextBox txtTenKhach;
        private MaskedTextBox txtDienThoai;
        private GroupBox groupBox2;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtTenHang;
        private Label label12;
        private ComboBox cboMaHang;
        private Label label11;
        private TextBox txtSoLuong;
        private Label label14;
        private TextBox txtDonGiaBan;
        private Label label13;
        private TextBox txtGiamGia;
        private Label label15;
        private TextBox txtThanhTien;
        private Label label16;
        private Panel pa;
        private DataGridView dgvHDBanHang;
        private Label lblBangChu;
        private Label label17;
        private TextBox txtTongTien;
        private Label label18;
        private Button btnDong;
        private Button btnInHoaDon;
        private Button btnXoa;
        private Button btnLuu;
        private Button btnThem;
        private ComboBox cboMaKhach;
    }
}
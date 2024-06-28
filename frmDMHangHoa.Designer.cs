namespace AnimalManagement
{
    partial class frmDMHangHoa
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
            btnHienThi = new Button();
            btnBoQua = new Button();
            btnDong = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            panel = new Panel();
            btnOpen = new Button();
            picAnh = new PictureBox();
            txtGhiChu = new TextBox();
            txtDonGiaBan = new TextBox();
            txtDonGiaNhap = new TextBox();
            label9 = new Label();
            label8 = new Label();
            txtSoLuong = new TextBox();
            label7 = new Label();
            label4 = new Label();
            cboMaChatLieu = new ComboBox();
            txtAnh = new TextBox();
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvHang = new DataGridView();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHang).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(btnHienThi);
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 524);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 76);
            panel1.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(544, 21);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(107, 31);
            btnTimKiem.TabIndex = 16;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(658, 21);
            btnHienThi.Margin = new Padding(3, 4, 3, 4);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(105, 31);
            btnHienThi.TabIndex = 15;
            btnHienThi.Text = "Hiển thị DS";
            btnHienThi.UseVisualStyleBackColor = true;
            btnHienThi.Click += btnHienThi_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(422, 21);
            btnBoQua.Margin = new Padding(3, 4, 3, 4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(107, 31);
            btnBoQua.TabIndex = 14;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(776, 21);
            btnDong.Margin = new Padding(3, 4, 3, 4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(125, 31);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(320, 21);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(96, 31);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(215, 21);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(99, 31);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(114, 21);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 31);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(14, 21);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 31);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel
            // 
            panel.Controls.Add(btnOpen);
            panel.Controls.Add(picAnh);
            panel.Controls.Add(txtGhiChu);
            panel.Controls.Add(txtDonGiaBan);
            panel.Controls.Add(txtDonGiaNhap);
            panel.Controls.Add(label9);
            panel.Controls.Add(label8);
            panel.Controls.Add(txtSoLuong);
            panel.Controls.Add(label7);
            panel.Controls.Add(label4);
            panel.Controls.Add(cboMaChatLieu);
            panel.Controls.Add(txtAnh);
            panel.Controls.Add(txtTenHang);
            panel.Controls.Add(txtMaHang);
            panel.Controls.Add(label6);
            panel.Controls.Add(label5);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(914, 279);
            panel.TabIndex = 5;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(658, 52);
            btnOpen.Margin = new Padding(3, 4, 3, 4);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(61, 31);
            btnOpen.TabIndex = 22;
            btnOpen.Text = "Mở";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(730, 47);
            picAnh.Margin = new Padding(3, 4, 3, 4);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(170, 211);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 21;
            picAnh.TabStop = false;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(422, 169);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(229, 88);
            txtGhiChu.TabIndex = 20;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(110, 233);
            txtDonGiaBan.Margin = new Padding(3, 4, 3, 4);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(180, 27);
            txtDonGiaBan.TabIndex = 19;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(110, 197);
            txtDonGiaNhap.Margin = new Padding(3, 4, 3, 4);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(180, 27);
            txtDonGiaNhap.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 237);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 17;
            label9.Text = "Đơn giá bán";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 201);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 16;
            label8.Text = "Đơn giá nhập";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(110, 159);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(180, 27);
            txtSoLuong.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 169);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 14;
            label7.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 125);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 13;
            label4.Text = "Mã loài vật:";
            // 
            // cboMaChatLieu
            // 
            cboMaChatLieu.FormattingEnabled = true;
            cboMaChatLieu.Location = new Point(110, 120);
            cboMaChatLieu.Margin = new Padding(3, 4, 3, 4);
            cboMaChatLieu.Name = "cboMaChatLieu";
            cboMaChatLieu.Size = new Size(180, 28);
            cboMaChatLieu.TabIndex = 12;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(422, 53);
            txtAnh.Margin = new Padding(3, 4, 3, 4);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(229, 88);
            txtAnh.TabIndex = 10;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(110, 81);
            txtTenHang.Margin = new Padding(3, 4, 3, 4);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(180, 27);
            txtTenHang.TabIndex = 8;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(110, 47);
            txtMaHang.Margin = new Padding(3, 4, 3, 4);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(180, 27);
            txtMaHang.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(344, 173);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(344, 57);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 4;
            label5.Text = "Ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 92);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 47);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(315, 12);
            label1.Name = "label1";
            label1.Size = new Size(281, 32);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC ĐỘNG VẬT";
            // 
            // dgvHang
            // 
            dgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHang.Dock = DockStyle.Fill;
            dgvHang.Location = new Point(0, 279);
            dgvHang.Margin = new Padding(3, 4, 3, 4);
            dgvHang.Name = "dgvHang";
            dgvHang.RowHeadersWidth = 51;
            dgvHang.Size = new Size(914, 245);
            dgvHang.TabIndex = 6;
            dgvHang.CellClick += dgvHang_Click;
            // 
            // frmDMHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvHang);
            Controls.Add(panel);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDMHangHoa";
            Text = "Danh mục hàng hóa";
            Load += frmDMHangHoa_Load;
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHienThi;
        private Button btnBoQua;
        private Button btnDong;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel;
        private MaskedTextBox mtb;
        private TextBox txtAnh;
        private TextBox txtTenHang;
        private TextBox txtMaHang;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvHang;
        private TextBox txtSoLuong;
        private Label label7;
        private Label label4;
        private ComboBox cboMaChatLieu;
        private TextBox txtGhiChu;
        private TextBox txtDonGiaBan;
        private TextBox txtDonGiaNhap;
        private Label label9;
        private Label label8;
        private Button btnOpen;
        private PictureBox picAnh;
        private Button btnTimKiem;
    }
}
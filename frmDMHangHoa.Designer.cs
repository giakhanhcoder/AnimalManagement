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
            btnBoQua = new Button();
            btnDong = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnHienThi = new Button();
            mtbDienThoai = new Panel();
            txtAnh = new TextBox();
            txtTenHang = new TextBox();
            txtMaHang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvHangHoa = new DataGridView();
            cboMaChatLieu = new ComboBox();
            label4 = new Label();
            label7 = new Label();
            txtSoLuong = new TextBox();
            label8 = new Label();
            label9 = new Label();
            txtDonGiaNhap = new TextBox();
            txtDonGiaBan = new TextBox();
            txtGhiChu = new TextBox();
            picAnh = new PictureBox();
            btnMo = new Button();
            panel1.SuspendLayout();
            mtbDienThoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnHienThi);
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 4;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(442, 16);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(111, 23);
            btnBoQua.TabIndex = 14;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(679, 16);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 23);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(336, 16);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 23);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(219, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(108, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(3, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHienThi
            // 
            btnHienThi.Location = new Point(559, 16);
            btnHienThi.Name = "btnHienThi";
            btnHienThi.Size = new Size(111, 23);
            btnHienThi.TabIndex = 15;
            btnHienThi.Text = "Hiển thị DS";
            btnHienThi.UseVisualStyleBackColor = true;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Controls.Add(btnMo);
            mtbDienThoai.Controls.Add(picAnh);
            mtbDienThoai.Controls.Add(txtGhiChu);
            mtbDienThoai.Controls.Add(txtDonGiaBan);
            mtbDienThoai.Controls.Add(txtDonGiaNhap);
            mtbDienThoai.Controls.Add(label9);
            mtbDienThoai.Controls.Add(label8);
            mtbDienThoai.Controls.Add(txtSoLuong);
            mtbDienThoai.Controls.Add(label7);
            mtbDienThoai.Controls.Add(label4);
            mtbDienThoai.Controls.Add(cboMaChatLieu);
            mtbDienThoai.Controls.Add(txtAnh);
            mtbDienThoai.Controls.Add(txtTenHang);
            mtbDienThoai.Controls.Add(txtMaHang);
            mtbDienThoai.Controls.Add(label6);
            mtbDienThoai.Controls.Add(label5);
            mtbDienThoai.Controls.Add(label3);
            mtbDienThoai.Controls.Add(label2);
            mtbDienThoai.Controls.Add(label1);
            mtbDienThoai.Dock = DockStyle.Top;
            mtbDienThoai.Location = new Point(0, 0);
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(800, 209);
            mtbDienThoai.TabIndex = 5;
            // 
            // txtAnh
            // 
            txtAnh.Location = new Point(369, 40);
            txtAnh.Multiline = true;
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(201, 67);
            txtAnh.TabIndex = 10;
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(96, 61);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(158, 23);
            txtTenHang.TabIndex = 8;
            // 
            // txtMaHang
            // 
            txtMaHang.Location = new Point(96, 35);
            txtMaHang.Name = "txtMaHang";
            txtMaHang.Size = new Size(158, 23);
            txtMaHang.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 130);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Ghi chú:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 43);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "Ảnh:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 69);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 35);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 25);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC ĐỘNG VẬT";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Dock = DockStyle.Fill;
            dgvHangHoa.Location = new Point(0, 209);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.Size = new Size(800, 184);
            dgvHangHoa.TabIndex = 6;
            // 
            // cboMaChatLieu
            // 
            cboMaChatLieu.FormattingEnabled = true;
            cboMaChatLieu.Location = new Point(96, 90);
            cboMaChatLieu.Name = "cboMaChatLieu";
            cboMaChatLieu.Size = new Size(158, 23);
            cboMaChatLieu.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 13;
            label4.Text = "Mã loài vật:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 127);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 14;
            label7.Text = "Số lượng:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(96, 119);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(158, 23);
            txtSoLuong.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 151);
            label8.Name = "label8";
            label8.Size = new Size(78, 15);
            label8.TabIndex = 16;
            label8.Text = "Đơn giá nhập";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 178);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 17;
            label9.Text = "Đơn giá bán";
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Location = new Point(96, 148);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(158, 23);
            txtDonGiaNhap.TabIndex = 18;
            // 
            // txtDonGiaBan
            // 
            txtDonGiaBan.Location = new Point(96, 175);
            txtDonGiaBan.Name = "txtDonGiaBan";
            txtDonGiaBan.Size = new Size(158, 23);
            txtDonGiaBan.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(369, 127);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(201, 67);
            txtGhiChu.TabIndex = 20;
            // 
            // picAnh
            // 
            picAnh.Location = new Point(639, 35);
            picAnh.Name = "picAnh";
            picAnh.Size = new Size(149, 158);
            picAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picAnh.TabIndex = 21;
            picAnh.TabStop = false;
            // 
            // btnMo
            // 
            btnMo.Location = new Point(576, 39);
            btnMo.Name = "btnMo";
            btnMo.Size = new Size(53, 23);
            btnMo.TabIndex = 22;
            btnMo.Text = "Mở";
            btnMo.UseVisualStyleBackColor = true;
            // 
            // frmDMHangHoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHangHoa);
            Controls.Add(mtbDienThoai);
            Controls.Add(panel1);
            Name = "frmDMHangHoa";
            Text = "Danh mục hàng hóa";
            panel1.ResumeLayout(false);
            mtbDienThoai.ResumeLayout(false);
            mtbDienThoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)picAnh).EndInit();
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
        private Panel mtbDienThoai;
        private MaskedTextBox mtb;
        private TextBox txtAnh;
        private TextBox txtTenHang;
        private TextBox txtMaHang;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvHangHoa;
        private TextBox txtSoLuong;
        private Label label7;
        private Label label4;
        private ComboBox cboMaChatLieu;
        private TextBox txtGhiChu;
        private TextBox txtDonGiaBan;
        private TextBox txtDonGiaNhap;
        private Label label9;
        private Label label8;
        private Button btnMo;
        private PictureBox picAnh;
    }
}
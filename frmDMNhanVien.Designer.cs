namespace AnimalManagement
{
    partial class frmDMNhanVien
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
            panel = new Panel();
            mskNgaySinh = new DateTimePicker();
            mtbDienThoai = new MaskedTextBox();
            txtDiaChi = new TextBox();
            chkGioiTinh = new CheckBox();
            txtTenNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvNhanVien = new DataGridView();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.TabIndex = 0;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(537, 16);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(111, 23);
            btnBoQua.TabIndex = 14;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(665, 17);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 23);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(413, 17);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 23);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(288, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(164, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(26, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel
            // 
            panel.Controls.Add(mskNgaySinh);
            panel.Controls.Add(mtbDienThoai);
            panel.Controls.Add(txtDiaChi);
            panel.Controls.Add(chkGioiTinh);
            panel.Controls.Add(txtTenNhanVien);
            panel.Controls.Add(txtMaNhanVien);
            panel.Controls.Add(label7);
            panel.Controls.Add(label6);
            panel.Controls.Add(label5);
            panel.Controls.Add(label4);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(800, 166);
            panel.TabIndex = 1;
            // 
            // mskNgaySinh
            // 
            mskNgaySinh.Format = DateTimePickerFormat.Short;
            mskNgaySinh.Location = new Point(500, 127);
            mskNgaySinh.Name = "mskNgaySinh";
            mskNgaySinh.Size = new Size(200, 23);
            mskNgaySinh.TabIndex = 12;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(500, 91);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(200, 23);
            mtbDienThoai.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(500, 51);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 23);
            txtDiaChi.TabIndex = 10;
            // 
            // chkGioiTinh
            // 
            chkGioiTinh.AutoSize = true;
            chkGioiTinh.Checked = true;
            chkGioiTinh.CheckState = CheckState.Checked;
            chkGioiTinh.Location = new Point(164, 131);
            chkGioiTinh.Name = "chkGioiTinh";
            chkGioiTinh.Size = new Size(52, 19);
            chkGioiTinh.TabIndex = 9;
            chkGioiTinh.Text = "Nam";
            chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(164, 86);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(193, 23);
            txtTenNhanVien.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(164, 51);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(193, 23);
            txtMaNhanVien.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 131);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 6;
            label7.Text = "Ngày sinh:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 94);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(413, 56);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 131);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 94);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 25);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 166);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(800, 227);
            dgvNhanVien.TabIndex = 2;
            dgvNhanVien.Click += dgvNhanVien_Click;
            // 
            // frmDMNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNhanVien);
            Controls.Add(panel);
            Controls.Add(panel1);
            Name = "frmDMNhanVien";
            Text = "Danh mục nhân viên";
            Load += frmDMNhanVien_Load;
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvNhanVien;
        private MaskedTextBox mtbDienThoai;
        private TextBox txtDiaChi;
        private CheckBox chkGioiTinh;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private DateTimePicker mskNgaySinh;
        private Button btnBoQua;
        private Button btnDong;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
    }
}
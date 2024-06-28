namespace AnimalManagement
{
    partial class frmDMKhachHang
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
            dgvKhachHang = new DataGridView();
            mtbDienThoai = new MaskedTextBox();
            btnXoa = new Button();
            btnThem = new Button();
            txtDiaChi = new TextBox();
            btnBoQua = new Button();
            btnDong = new Button();
            btnLuu = new Button();
            panel1 = new Panel();
            btnSua = new Button();
            txtTenKhach = new TextBox();
            txtMaKhach = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 221);
            dgvKhachHang.Margin = new Padding(3, 4, 3, 4);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 51;
            dgvKhachHang.Size = new Size(914, 303);
            dgvKhachHang.TabIndex = 5;
            dgvKhachHang.Click += dgvKhachHang_Click;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(571, 121);
            mtbDienThoai.Margin = new Padding(3, 4, 3, 4);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(228, 27);
            mtbDienThoai.TabIndex = 11;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(187, 21);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(109, 31);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(30, 21);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(113, 31);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(571, 68);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(228, 27);
            txtDiaChi.TabIndex = 10;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(614, 21);
            btnBoQua.Margin = new Padding(3, 4, 3, 4);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(127, 31);
            btnBoQua.TabIndex = 14;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(760, 23);
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
            btnLuu.Location = new Point(472, 23);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(114, 31);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
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
            panel1.Location = new Point(0, 524);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 76);
            panel1.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(329, 21);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(114, 31);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtTenKhach
            // 
            txtTenKhach.Location = new Point(187, 115);
            txtTenKhach.Margin = new Padding(3, 4, 3, 4);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(220, 27);
            txtTenKhach.TabIndex = 8;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(187, 68);
            txtMaKhach.Margin = new Padding(3, 4, 3, 4);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(220, 27);
            txtMaKhach.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(472, 125);
            label6.Name = "label6";
            label6.Size = new Size(81, 20);
            label6.TabIndex = 5;
            label6.Text = "Điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 75);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 125);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Tên khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 75);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã khách:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(315, 12);
            label1.Name = "label1";
            label1.Size = new Size(317, 32);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // panel
            // 
            panel.Controls.Add(mtbDienThoai);
            panel.Controls.Add(txtDiaChi);
            panel.Controls.Add(txtTenKhach);
            panel.Controls.Add(txtMaKhach);
            panel.Controls.Add(label6);
            panel.Controls.Add(label5);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(914, 221);
            panel.TabIndex = 4;
            // 
            // frmDMKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel1);
            Controls.Add(panel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDMKhachHang";
            Text = "Danh mục khách hàng";
            Load += frmDMKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker dtpNgaySinh;
        private MaskedTextBox maskedTextBox1;
        private DataGridView dgvKhachHang;
        private MaskedTextBox mtbDienThoai;
        private Button btnXoa;
        private Button btnThem;
        private TextBox txtDiaChi;
        private Button btnBoQua;
        private Button btnDong;
        private Button btnLuu;
        private Panel panel1;
        private Button btnSua;
        private TextBox txtTenKhach;
        private TextBox txtMaKhach;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel;
    }
}
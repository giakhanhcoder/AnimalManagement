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
            btnBoQua = new Button();
            btnXoa = new Button();
            txtDiaChi = new TextBox();
            txtMaKhach = new TextBox();
            label6 = new Label();
            btnDong = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            dgvKhachHang = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnThem = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(537, 16);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(111, 23);
            btnBoQua.TabIndex = 14;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(164, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 23);
            btnXoa.TabIndex = 10;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
           
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(500, 51);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 23);
            txtDiaChi.TabIndex = 10;
            // 
          
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(164, 51);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(193, 23);
            txtMaKhach.TabIndex = 7;
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
            // btnDong
            // 
            btnDong.Location = new Point(665, 17);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 23);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(413, 17);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 23);
            btnLuu.TabIndex = 12;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(288, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 23);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Dock = DockStyle.Fill;
            dgvKhachHang.Location = new Point(0, 166);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.Size = new Size(800, 227);
            dgvKhachHang.TabIndex = 5;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 94);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên khách:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã khách:";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(26, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
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
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(252, 25);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
           
            // frmDMKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKhachHang);
            Controls.Add(panel1);
            Controls.Add(panel);
            Name = "frmDMKhachHang";
            Text = "Danh mục khách hàng";
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBoQua;
        private Button btnXoa;
        private DateTimePicker dtpNgaySinh;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtDiaChi;
        private CheckBox chkGioiTinh;
        private TextBox txtTenNhanVien;
        private TextBox txtMaKhach;
        private Label label7;
        private Label label6;
        private Button btnDong;
        private Button btnLuu;
        private Button btnSua;
        private DataGridView dgvKhachHang;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnThem;
        private Panel panel1;
        private Label label1;
        private Panel panel;
    }
}
namespace AnimalManagement
{
    partial class frmTimKiemHD
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
            btnThem = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaHoaDon = new TextBox();
            txtThang = new TextBox();
            txtNam = new TextBox();
            txtMaNhanVien = new TextBox();
            txtMaKhachHang = new TextBox();
            txtTongTien = new TextBox();
            dgvDanhSachHD = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHD).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBoQua);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnThem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 4;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(353, 17);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(111, 23);
            btnBoQua.TabIndex = 14;
            btnBoQua.Text = "Tìm lại";
            btnBoQua.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(497, 17);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 23);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(205, 17);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 23);
            btnThem.TabIndex = 9;
            btnThem.Text = "Tìm kiếm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 365);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 28);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTongTien);
            panel3.Controls.Add(txtMaKhachHang);
            panel3.Controls.Add(txtMaNhanVien);
            panel3.Controls.Add(txtNam);
            panel3.Controls.Add(txtThang);
            panel3.Controls.Add(txtMaHoaDon);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 124);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(278, 15);
            label1.TabIndex = 0;
            label1.Text = "Nháy đúp vào hóa đơn để hiển thị thông tin chi tiết";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 12);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 12);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 50);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 2;
            label4.Text = "Tháng:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 50);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 3;
            label5.Text = "Năm:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(423, 55);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 4;
            label6.Text = "Tổng tiền:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 88);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 5;
            label7.Text = "Mã nhân viên:";
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(141, 9);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(185, 23);
            txtMaHoaDon.TabIndex = 6;
            txtMaHoaDon.TextChanged += textBox1_TextChanged;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(88, 42);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(82, 23);
            txtThang.TabIndex = 7;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(240, 42);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(86, 23);
            txtNam.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(141, 85);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(185, 23);
            txtMaNhanVien.TabIndex = 9;
            txtMaNhanVien.TextChanged += textBox4_TextChanged;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Location = new Point(538, 9);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(165, 23);
            txtMaKhachHang.TabIndex = 10;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(538, 50);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(165, 23);
            txtTongTien.TabIndex = 11;
            // 
            // dgvDanhSachHD
            // 
            dgvDanhSachHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachHD.Dock = DockStyle.Fill;
            dgvDanhSachHD.Location = new Point(0, 124);
            dgvDanhSachHD.Name = "dgvDanhSachHD";
            dgvDanhSachHD.Size = new Size(800, 241);
            dgvDanhSachHD.TabIndex = 7;
            // 
            // frmTimKiemHD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDanhSachHD);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTimKiemHD";
            Text = "Tìm kiếm hóa đơn";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBoQua;
        private Button btnDong;
        private Button btnThem;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTongTien;
        private TextBox txtMaKhachHang;
        private TextBox txtMaNhanVien;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtMaHoaDon;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvDanhSachHD;
    }
}
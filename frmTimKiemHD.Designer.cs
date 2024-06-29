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
            btnTimLai = new Button();
            btnDong = new Button();
            btnTimKiem = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            txtTongTien = new TextBox();
            txtMaKhach = new TextBox();
            txtMaNhanVien = new TextBox();
            txtNam = new TextBox();
            txtThang = new TextBox();
            txtMaHDBan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dgvTKHoaDon = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKHoaDon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimLai);
            panel1.Controls.Add(btnDong);
            panel1.Controls.Add(btnTimKiem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 524);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 76);
            panel1.TabIndex = 4;
            // 
            // btnTimLai
            // 
            btnTimLai.Location = new Point(403, 23);
            btnTimLai.Margin = new Padding(3, 4, 3, 4);
            btnTimLai.Name = "btnTimLai";
            btnTimLai.Size = new Size(127, 31);
            btnTimLai.TabIndex = 14;
            btnTimLai.Text = "Tìm lại";
            btnTimLai.UseVisualStyleBackColor = true;
            btnTimLai.Click += btnTimLai_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(568, 23);
            btnDong.Margin = new Padding(3, 4, 3, 4);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(125, 31);
            btnDong.TabIndex = 13;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(234, 23);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(113, 31);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 487);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 37);
            panel2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(347, 20);
            label1.TabIndex = 0;
            label1.Text = "Nháy đúp vào hóa đơn để hiển thị thông tin chi tiết";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTongTien);
            panel3.Controls.Add(txtMaKhach);
            panel3.Controls.Add(txtMaNhanVien);
            panel3.Controls.Add(txtNam);
            panel3.Controls.Add(txtThang);
            panel3.Controls.Add(txtMaHDBan);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 165);
            panel3.TabIndex = 6;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(615, 67);
            txtTongTien.Margin = new Padding(3, 4, 3, 4);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(188, 27);
            txtTongTien.TabIndex = 11;
            txtTongTien.KeyPress += txtTongTien_KeyPress;
            // 
            // txtMaKhach
            // 
            txtMaKhach.Location = new Point(615, 12);
            txtMaKhach.Margin = new Padding(3, 4, 3, 4);
            txtMaKhach.Name = "txtMaKhach";
            txtMaKhach.Size = new Size(188, 27);
            txtMaKhach.TabIndex = 10;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(161, 113);
            txtMaNhanVien.Margin = new Padding(3, 4, 3, 4);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(211, 27);
            txtMaNhanVien.TabIndex = 9;
            // 
            // txtNam
            // 
            txtNam.Location = new Point(274, 56);
            txtNam.Margin = new Padding(3, 4, 3, 4);
            txtNam.Name = "txtNam";
            txtNam.Size = new Size(98, 27);
            txtNam.TabIndex = 8;
            // 
            // txtThang
            // 
            txtThang.Location = new Point(101, 56);
            txtThang.Margin = new Padding(3, 4, 3, 4);
            txtThang.Name = "txtThang";
            txtThang.Size = new Size(93, 27);
            txtThang.TabIndex = 7;
            // 
            // txtMaHDBan
            // 
            txtMaHDBan.Location = new Point(161, 12);
            txtMaHDBan.Margin = new Padding(3, 4, 3, 4);
            txtMaHDBan.Name = "txtMaHDBan";
            txtMaHDBan.Size = new Size(211, 27);
            txtMaHDBan.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 117);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 5;
            label7.Text = "Mã nhân viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(483, 73);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 67);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 3;
            label5.Text = "Năm:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 67);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 2;
            label4.Text = "Tháng:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 16);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 16);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã hóa đơn:";
            // 
            // dgvTKHoaDon
            // 
            dgvTKHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTKHoaDon.Dock = DockStyle.Fill;
            dgvTKHoaDon.Location = new Point(0, 165);
            dgvTKHoaDon.Margin = new Padding(3, 4, 3, 4);
            dgvTKHoaDon.Name = "dgvTKHoaDon";
            dgvTKHoaDon.RowHeadersWidth = 51;
            dgvTKHoaDon.Size = new Size(914, 322);
            dgvTKHoaDon.TabIndex = 7;
            dgvTKHoaDon.DoubleClick += dgvTKHoaDon_DoubleClick;
            // 
            // frmTimKiemHD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dgvTKHoaDon);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTimKiemHD";
            Text = "Tìm kiếm hóa đơn";
            Load += frmTimKiemHD_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTKHoaDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimLai;
        private Button btnDong;
        private Button btnTimKiem;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTongTien;
        private TextBox txtMaKhach;
        private TextBox txtMaNhanVien;
        private TextBox txtNam;
        private TextBox txtThang;
        private TextBox txtMaHDBan;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dgvTKHoaDon;
    }
}
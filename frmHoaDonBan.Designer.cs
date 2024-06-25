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
            cboMaHD = new ComboBox();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            mtbDienThoai = new MaskedTextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
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
            dgvHoaDonBanHang = new DataGridView();
            panel4 = new Panel();
            txtTongTien = new TextBox();
            label18 = new Label();
            lblTongTien = new Label();
            label17 = new Label();
            panel3 = new Panel();
            txtThanhTien = new TextBox();
            label16 = new Label();
            txtGiamGia = new TextBox();
            label15 = new Label();
            txtSoLuong = new TextBox();
            label14 = new Label();
            txtDonGia = new TextBox();
            label13 = new Label();
            txtTenHang = new TextBox();
            label12 = new Label();
            cbxMaHang = new ComboBox();
            label11 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            btnInHoaDon = new Button();
            btnHuyHoaDon = new Button();
            btnLuuHoaDon = new Button();
            btnThemHoaDon = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBanHang).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnTimKiem);
            panel1.Controls.Add(cboMaHD);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 36);
            panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(385, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(159, 23);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "&Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += button1_Click;
            // 
            // cboMaHD
            // 
            cboMaHD.FormattingEnabled = true;
            cboMaHD.Location = new Point(122, 4);
            cboMaHD.Name = "cboMaHD";
            cboMaHD.Size = new Size(243, 23);
            cboMaHD.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 8);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
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
            splitContainer1.Size = new Size(800, 414);
            splitContainer1.SplitterDistance = 154;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(mtbDienThoai);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(797, 124);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(560, 68);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(163, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(560, 43);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(163, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(163, 23);
            textBox3.TabIndex = 12;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Location = new Point(560, 95);
            mtbDienThoai.Mask = "(999) 000-0000";
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.ReadOnly = true;
            mtbDienThoai.Size = new Size(163, 23);
            mtbDienThoai.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 99);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(174, 23);
            textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(106, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(106, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(175, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 16);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(175, 23);
            textBox1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(436, 102);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 6;
            label10.Text = "Điện thoại:";
            label10.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(436, 76);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 5;
            label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 51);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 4;
            label8.Text = "Tên khách hàng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(436, 21);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 3;
            label7.Text = "Mã khách hàng:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 102);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 0;
            label6.Text = "Tên nhân viên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 76);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 2;
            label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 51);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 1;
            label4.Text = "Ngày bán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 19);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 0;
            label3.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(273, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(210, 25);
            label2.TabIndex = 0;
            label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHoaDonBanHang);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(panel3);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 256);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHoaDonBanHang
            // 
            dgvHoaDonBanHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoaDonBanHang.Dock = DockStyle.Fill;
            dgvHoaDonBanHang.Location = new Point(3, 102);
            dgvHoaDonBanHang.Name = "dgvHoaDonBanHang";
            dgvHoaDonBanHang.Size = new Size(794, 88);
            dgvHoaDonBanHang.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtTongTien);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(lblTongTien);
            panel4.Controls.Add(label17);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(3, 190);
            panel4.Name = "panel4";
            panel4.Size = new Size(794, 40);
            panel4.TabIndex = 2;
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(626, 5);
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(141, 23);
            txtTongTien.TabIndex = 3;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(560, 5);
            label18.Name = "label18";
            label18.Size = new Size(60, 15);
            label18.TabIndex = 2;
            label18.Text = "Tổng tiền:";
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.ForeColor = Color.Blue;
            lblTongTien.Location = new Point(20, 22);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(60, 15);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Bằng chữ:";
            lblTongTien.Click += label18_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = Color.Red;
            label17.Location = new Point(20, 5);
            label17.Name = "label17";
            label17.Size = new Size(153, 15);
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
            panel3.Controls.Add(txtDonGia);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(txtTenHang);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(cbxMaHang);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 83);
            panel3.TabIndex = 1;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(531, 51);
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.ReadOnly = true;
            txtThanhTien.Size = new Size(159, 23);
            txtThanhTien.TabIndex = 11;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(447, 53);
            label16.Name = "label16";
            label16.Size = new Size(66, 15);
            label16.TabIndex = 10;
            label16.Text = "Thành tiền:";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(314, 45);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(121, 23);
            txtGiamGia.TabIndex = 9;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(237, 48);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 8;
            label15.Text = "Giảm giá %:";
            label15.Click += label15_Click;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(91, 43);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(121, 23);
            txtSoLuong.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(30, 51);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 6;
            label14.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(531, 15);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.ReadOnly = true;
            txtDonGia.Size = new Size(159, 23);
            txtDonGia.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(449, 15);
            label13.Name = "label13";
            label13.Size = new Size(51, 15);
            label13.TabIndex = 4;
            label13.Text = "Đơn giá:";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(314, 12);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.ReadOnly = true;
            txtTenHang.Size = new Size(121, 23);
            txtTenHang.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(236, 15);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 2;
            label12.Text = "Tên hàng:";
            // 
            // cbxMaHang
            // 
            cbxMaHang.FormattingEnabled = true;
            cbxMaHang.Location = new Point(91, 12);
            cbxMaHang.Name = "cbxMaHang";
            cbxMaHang.Size = new Size(121, 23);
            cbxMaHang.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 15);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 0;
            label11.Text = "Mã hàng:";
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(btnInHoaDon);
            panel2.Controls.Add(btnHuyHoaDon);
            panel2.Controls.Add(btnLuuHoaDon);
            panel2.Controls.Add(btnThemHoaDon);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 23);
            panel2.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(645, 1);
            button6.Name = "button6";
            button6.Size = new Size(109, 23);
            button6.TabIndex = 8;
            button6.Text = "Đóng";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Location = new Point(473, 0);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(122, 23);
            btnInHoaDon.TabIndex = 6;
            btnInHoaDon.Text = "In hóa đơn";
            btnInHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnHuyHoaDon
            // 
            btnHuyHoaDon.Location = new Point(324, 0);
            btnHuyHoaDon.Name = "btnHuyHoaDon";
            btnHuyHoaDon.Size = new Size(123, 23);
            btnHuyHoaDon.TabIndex = 5;
            btnHuyHoaDon.Text = "Hủy hóa đơn";
            btnHuyHoaDon.UseVisualStyleBackColor = true;
            btnHuyHoaDon.Click += button3_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Location = new Point(160, 0);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(134, 23);
            btnLuuHoaDon.TabIndex = 4;
            btnLuuHoaDon.Text = "Lưu hóa đơn";
            btnLuuHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThemHoaDon
            // 
            btnThemHoaDon.Location = new Point(6, 0);
            btnThemHoaDon.Name = "btnThemHoaDon";
            btnThemHoaDon.Size = new Size(135, 23);
            btnThemHoaDon.TabIndex = 0;
            btnThemHoaDon.Text = "Thêm hóa đơn";
            btnThemHoaDon.UseVisualStyleBackColor = true;
            // 
            // frmHoaDonBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "frmHoaDonBan";
            Text = "Hóa đơn bán hàng";
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
            ((System.ComponentModel.ISupportInitialize)dgvHoaDonBanHang).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTimKiem;
        private ComboBox cboMaHD;
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
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private MaskedTextBox mtbDienThoai;
        private GroupBox groupBox2;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtTenHang;
        private Label label12;
        private ComboBox cbxMaHang;
        private Label label11;
        private TextBox txtSoLuong;
        private Label label14;
        private TextBox txtDonGia;
        private Label label13;
        private TextBox txtGiamGia;
        private Label label15;
        private TextBox txtThanhTien;
        private Label label16;
        private Panel panel4;
        private DataGridView dgvHoaDonBanHang;
        private Label lblTongTien;
        private Label label17;
        private TextBox txtTongTien;
        private Label label18;
        private Button button6;
        private Button btnInHoaDon;
        private Button btnHuyHoaDon;
        private Button btnLuuHoaDon;
        private Button btnThemHoaDon;
    }
}
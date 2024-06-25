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
            mtbDienThoai = new Panel();
            dgvNhanVien = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            chkGioiTinh = new CheckBox();
            txtDiaChi = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            dtpNgaySinh = new DateTimePicker();
            mtbDienThoai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 393);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 0;
            // 
            // mtbDienThoai
            // 
            mtbDienThoai.Controls.Add(dtpNgaySinh);
            mtbDienThoai.Controls.Add(maskedTextBox1);
            mtbDienThoai.Controls.Add(txtDiaChi);
            mtbDienThoai.Controls.Add(chkGioiTinh);
            mtbDienThoai.Controls.Add(txtTenNhanVien);
            mtbDienThoai.Controls.Add(txtMaNhanVien);
            mtbDienThoai.Controls.Add(label7);
            mtbDienThoai.Controls.Add(label6);
            mtbDienThoai.Controls.Add(label5);
            mtbDienThoai.Controls.Add(label4);
            mtbDienThoai.Controls.Add(label3);
            mtbDienThoai.Controls.Add(label2);
            mtbDienThoai.Controls.Add(label1);
            mtbDienThoai.Dock = DockStyle.Top;
            mtbDienThoai.Location = new Point(0, 0);
            mtbDienThoai.Name = "mtbDienThoai";
            mtbDienThoai.Size = new Size(800, 166);
            mtbDienThoai.TabIndex = 1;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(0, 166);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.Size = new Size(800, 227);
            dgvNhanVien.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên:";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 131);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 94);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 5;
            label6.Text = "Điện thoại:";
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
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(164, 51);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(193, 23);
            txtMaNhanVien.TabIndex = 7;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Location = new Point(164, 86);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(193, 23);
            txtTenNhanVien.TabIndex = 8;
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
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(500, 51);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(200, 23);
            txtDiaChi.TabIndex = 10;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(500, 91);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(200, 23);
            maskedTextBox1.TabIndex = 11;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(500, 127);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 12;
            // 
            // frmDMNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvNhanVien);
            Controls.Add(mtbDienThoai);
            Controls.Add(panel1);
            Name = "frmDMNhanVien";
            Text = "Danh mục nhân viên";
            mtbDienThoai.ResumeLayout(false);
            mtbDienThoai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel mtbDienThoai;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvNhanVien;
        private MaskedTextBox maskedTextBox1;
        private TextBox txtDiaChi;
        private CheckBox chkGioiTinh;
        private TextBox txtTenNhanVien;
        private TextBox txtMaNhanVien;
        private DateTimePicker dtpNgaySinh;
    }
}
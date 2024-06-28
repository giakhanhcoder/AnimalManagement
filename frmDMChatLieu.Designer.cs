namespace AnimalManagement
{
    partial class frmDMChatLieu
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
            txtTenChatLieu = new TextBox();
            txtMaChatLieu = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvChatLieu = new DataGridView();
            panel1.SuspendLayout();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).BeginInit();
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
            panel1.TabIndex = 2;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(537, 16);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(111, 23);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(665, 17);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 23);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(413, 17);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 23);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(288, 16);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 23);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(164, 16);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(95, 23);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(26, 16);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(99, 23);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel
            // 
            panel.Controls.Add(txtTenChatLieu);
            panel.Controls.Add(txtMaChatLieu);
            panel.Controls.Add(label3);
            panel.Controls.Add(label2);
            panel.Controls.Add(label1);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(800, 166);
            panel.TabIndex = 0;
            // 
            // txtTenChatLieu
            // 
            txtTenChatLieu.Location = new Point(164, 86);
            txtTenChatLieu.Name = "txtTenChatLieu";
            txtTenChatLieu.Size = new Size(193, 23);
            txtTenChatLieu.TabIndex = 1;
            // 
            // txtMaChatLieu
            // 
            txtMaChatLieu.Location = new Point(164, 51);
            txtMaChatLieu.Name = "txtMaChatLieu";
            txtMaChatLieu.Size = new Size(193, 23);
            txtMaChatLieu.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 94);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 2;
            label3.Text = "Loài động vật:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 56);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã loài vật:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC LOÀI VẬT";
            // 
            // dgvChatLieu
            // 
            dgvChatLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChatLieu.Dock = DockStyle.Fill;
            dgvChatLieu.Location = new Point(0, 166);
            dgvChatLieu.Name = "dgvChatLieu";
            dgvChatLieu.Size = new Size(800, 227);
            dgvChatLieu.TabIndex = 1;
            dgvChatLieu.Click += dgvChatLieu_Click;
            // 
            // frmDMChatLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvChatLieu);
            Controls.Add(panel);
            Controls.Add(panel1);
            Name = "frmDMChatLieu";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Danh mục chất liệu";
            Load += frmDMChatLieu_Load;
            KeyUp += txtMaChatLieu_KeyUp;
            panel1.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChatLieu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnBoQua;
        private Button btnDong;
        private Button btnLuu;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Panel panel;
        private TextBox txtTenChatLieu;
        private TextBox txtMaChatLieu;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvChatLieu;
    }
}
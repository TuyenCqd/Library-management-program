namespace Quản_Lý_Thư_Viện_1
{
    partial class FormQuanLyTainKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyTainKhoan));
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.GroupBox();
            this.bt_all = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.ra_Email = new System.Windows.Forms.RadioButton();
            this.ra_MaNV = new System.Windows.Forms.RadioButton();
            this.ra_TenDangNhap = new System.Windows.Forms.RadioButton();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_TimKiemTaiKhoan = new System.Windows.Forms.ComboBox();
            this.ra_Quyen = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MaNV = new System.Windows.Forms.ComboBox();
            this.txt_Quyen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.thoat = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.luoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN TÀI KHOẢN";
            // 
            // luoi
            // 
            this.luoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.luoi.Controls.Add(this.bt_all);
            this.luoi.Controls.Add(this.l);
            this.luoi.Controls.Add(this.dataGridView1);
            this.luoi.Controls.Add(this.label7);
            this.luoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luoi.Location = new System.Drawing.Point(0, 54);
            this.luoi.Name = "luoi";
            this.luoi.Size = new System.Drawing.Size(741, 579);
            this.luoi.TabIndex = 4;
            this.luoi.TabStop = false;
            this.luoi.Text = "Kết quả";
            // 
            // bt_all
            // 
            this.bt_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_all.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_all.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_all.Location = new System.Drawing.Point(562, 520);
            this.bt_all.Name = "bt_all";
            this.bt_all.Size = new System.Drawing.Size(173, 44);
            this.bt_all.TabIndex = 11;
            this.bt_all.Text = "Hiển thị tất cả";
            this.bt_all.UseVisualStyleBackColor = false;
            this.bt_all.Click += new System.EventHandler(this.bt_all_Click);
            // 
            // l
            // 
            this.l.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(183, 530);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(0, 18);
            this.l.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 491);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 530);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tổng số tài khoản:";
            // 
            // ra_Email
            // 
            this.ra_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_Email.AutoSize = true;
            this.ra_Email.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_Email.Location = new System.Drawing.Point(12, 123);
            this.ra_Email.Name = "ra_Email";
            this.ra_Email.Size = new System.Drawing.Size(75, 23);
            this.ra_Email.TabIndex = 10;
            this.ra_Email.TabStop = true;
            this.ra_Email.Text = "Email";
            this.ra_Email.UseVisualStyleBackColor = true;
            // 
            // ra_MaNV
            // 
            this.ra_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_MaNV.AutoSize = true;
            this.ra_MaNV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_MaNV.Location = new System.Drawing.Point(12, 85);
            this.ra_MaNV.Name = "ra_MaNV";
            this.ra_MaNV.Size = new System.Drawing.Size(99, 23);
            this.ra_MaNV.TabIndex = 9;
            this.ra_MaNV.TabStop = true;
            this.ra_MaNV.Text = "Họ vè tên";
            this.ra_MaNV.UseVisualStyleBackColor = true;
            // 
            // ra_TenDangNhap
            // 
            this.ra_TenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_TenDangNhap.AutoSize = true;
            this.ra_TenDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_TenDangNhap.Location = new System.Drawing.Point(12, 47);
            this.ra_TenDangNhap.Name = "ra_TenDangNhap";
            this.ra_TenDangNhap.Size = new System.Drawing.Size(135, 23);
            this.ra_TenDangNhap.TabIndex = 8;
            this.ra_TenDangNhap.TabStop = true;
            this.ra_TenDangNhap.Text = "Tên đăng nhập";
            this.ra_TenDangNhap.UseVisualStyleBackColor = true;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_TimKiem.Location = new System.Drawing.Point(302, 101);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(109, 39);
            this.bt_TimKiem.TabIndex = 7;
            this.bt_TimKiem.Text = "Tìm ";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.txt_TimKiemTaiKhoan);
            this.groupBox3.Controls.Add(this.ra_Quyen);
            this.groupBox3.Controls.Add(this.ra_Email);
            this.groupBox3.Controls.Add(this.ra_MaNV);
            this.groupBox3.Controls.Add(this.ra_TenDangNhap);
            this.groupBox3.Controls.Add(this.bt_TimKiem);
            this.groupBox3.Location = new System.Drawing.Point(3, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 220);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txt_TimKiemTaiKhoan
            // 
            this.txt_TimKiemTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiemTaiKhoan.FormattingEnabled = true;
            this.txt_TimKiemTaiKhoan.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.txt_TimKiemTaiKhoan.Location = new System.Drawing.Point(172, 42);
            this.txt_TimKiemTaiKhoan.Name = "txt_TimKiemTaiKhoan";
            this.txt_TimKiemTaiKhoan.Size = new System.Drawing.Size(213, 28);
            this.txt_TimKiemTaiKhoan.TabIndex = 12;
            // 
            // ra_Quyen
            // 
            this.ra_Quyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_Quyen.AutoSize = true;
            this.ra_Quyen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_Quyen.Location = new System.Drawing.Point(12, 164);
            this.ra_Quyen.Name = "ra_Quyen";
            this.ra_Quyen.Size = new System.Drawing.Size(77, 23);
            this.ra_Quyen.TabIndex = 11;
            this.ra_Quyen.TabStop = true;
            this.ra_Quyen.Text = "Quyền";
            this.ra_Quyen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.txt_MaNV);
            this.groupBox1.Controls.Add(this.txt_Quyen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.thoat);
            this.groupBox1.Controls.Add(this.luu);
            this.groupBox1.Controls.Add(this.xoa);
            this.groupBox1.Controls.Add(this.sua);
            this.groupBox1.Controls.Add(this.them);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(747, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 579);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết ";
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNV.FormattingEnabled = true;
            this.txt_MaNV.Location = new System.Drawing.Point(175, 65);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(213, 28);
            this.txt_MaNV.TabIndex = 37;
            // 
            // txt_Quyen
            // 
            this.txt_Quyen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Quyen.FormattingEnabled = true;
            this.txt_Quyen.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.txt_Quyen.Location = new System.Drawing.Point(175, 196);
            this.txt_Quyen.Name = "txt_Quyen";
            this.txt_Quyen.Size = new System.Drawing.Size(213, 28);
            this.txt_Quyen.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Quyền:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MatKhau.Location = new System.Drawing.Point(175, 117);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(213, 24);
            this.txt_MatKhau.TabIndex = 34;
            // 
            // thoat
            // 
            this.thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thoat.BackColor = System.Drawing.Color.Red;
            this.thoat.ForeColor = System.Drawing.Color.White;
            this.thoat.Location = new System.Drawing.Point(298, 299);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(110, 39);
            this.thoat.TabIndex = 32;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // luu
            // 
            this.luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.luu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.luu.Location = new System.Drawing.Point(22, 299);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(110, 39);
            this.luu.TabIndex = 31;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // xoa
            // 
            this.xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.xoa.Location = new System.Drawing.Point(161, 299);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(110, 39);
            this.xoa.TabIndex = 30;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sua.Location = new System.Drawing.Point(161, 244);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(110, 39);
            this.sua.TabIndex = 29;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.them.Location = new System.Drawing.Point(21, 244);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(110, 39);
            this.them.TabIndex = 28;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Mật khẩu:";
            // 
            // txt_Email
            // 
            this.txt_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.Location = new System.Drawing.Point(175, 158);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(213, 24);
            this.txt_Email.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã NV:";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenDangNhap.Location = new System.Drawing.Point(175, 27);
            this.txt_TenDangNhap.Multiline = true;
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(213, 24);
            this.txt_TenDangNhap.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 54);
            this.panel1.TabIndex = 3;
            // 
            // FormQuanLyTainKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 633);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuanLyTainKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQuanLyTainKhoan_FormClosed);
            this.Load += new System.EventHandler(this.FormQuanLyTainKhoan_Load);
            this.luoi.ResumeLayout(false);
            this.luoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox luoi;
        private System.Windows.Forms.Button bt_all;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ra_Email;
        private System.Windows.Forms.RadioButton ra_MaNV;
        private System.Windows.Forms.RadioButton ra_TenDangNhap;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.ComboBox txt_Quyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_TimKiemTaiKhoan;
        private System.Windows.Forms.RadioButton ra_Quyen;
        private System.Windows.Forms.ComboBox txt_MaNV;
    }
}
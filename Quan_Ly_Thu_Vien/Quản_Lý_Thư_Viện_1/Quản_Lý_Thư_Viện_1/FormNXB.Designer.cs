namespace Quản_Lý_Thư_Viện_1
{
    partial class FormNXB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNXB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_all = new System.Windows.Forms.Button();
            this.ra_DiaChiNXB = new System.Windows.Forms.RadioButton();
            this.ra_TenNXB = new System.Windows.Forms.RadioButton();
            this.ra_MaNXB = new System.Windows.Forms.RadioButton();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiemNXB = new System.Windows.Forms.TextBox();
            this.txt_TenNXB = new System.Windows.Forms.TextBox();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.txt_MaNXB = new System.Windows.Forms.TextBox();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.txt_DcNXB = new System.Windows.Forms.TextBox();
            this.bt_Them = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SđtNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 76);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(388, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT NHÀ XUẤT BẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1182, 457);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.DarkKhaki;
            this.groupBox2.Controls.Add(this.luoi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 457);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // luoi
            // 
            this.luoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(3, 21);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.RowTemplate.Height = 24;
            this.luoi.Size = new System.Drawing.Size(708, 385);
            this.luoi.TabIndex = 8;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_TenNXB);
            this.groupBox1.Controls.Add(this.bt_Thoat);
            this.groupBox1.Controls.Add(this.txt_MaNXB);
            this.groupBox1.Controls.Add(this.bt_Luu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_Xoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bt_Sua);
            this.groupBox1.Controls.Add(this.txt_DcNXB);
            this.groupBox1.Controls.Add(this.bt_Them);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_SđtNXB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(720, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 457);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.bt_all);
            this.groupBox3.Controls.Add(this.ra_DiaChiNXB);
            this.groupBox3.Controls.Add(this.ra_TenNXB);
            this.groupBox3.Controls.Add(this.ra_MaNXB);
            this.groupBox3.Controls.Add(this.bt_TimKiem);
            this.groupBox3.Controls.Add(this.txt_TimKiemNXB);
            this.groupBox3.Location = new System.Drawing.Point(3, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 160);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // bt_all
            // 
            this.bt_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_all.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_all.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_all.Location = new System.Drawing.Point(165, 78);
            this.bt_all.Name = "bt_all";
            this.bt_all.Size = new System.Drawing.Size(111, 61);
            this.bt_all.TabIndex = 12;
            this.bt_all.Text = "Hiển thị tất cả";
            this.bt_all.UseVisualStyleBackColor = false;
            this.bt_all.Click += new System.EventHandler(this.bt_all_Click);
            // 
            // ra_DiaChiNXB
            // 
            this.ra_DiaChiNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_DiaChiNXB.AutoSize = true;
            this.ra_DiaChiNXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_DiaChiNXB.Location = new System.Drawing.Point(22, 108);
            this.ra_DiaChiNXB.Name = "ra_DiaChiNXB";
            this.ra_DiaChiNXB.Size = new System.Drawing.Size(123, 23);
            this.ra_DiaChiNXB.TabIndex = 10;
            this.ra_DiaChiNXB.TabStop = true;
            this.ra_DiaChiNXB.Text = "Địa chỉ NXB";
            this.ra_DiaChiNXB.UseVisualStyleBackColor = true;
            // 
            // ra_TenNXB
            // 
            this.ra_TenNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_TenNXB.AutoSize = true;
            this.ra_TenNXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_TenNXB.Location = new System.Drawing.Point(22, 70);
            this.ra_TenNXB.Name = "ra_TenNXB";
            this.ra_TenNXB.Size = new System.Drawing.Size(97, 23);
            this.ra_TenNXB.TabIndex = 9;
            this.ra_TenNXB.TabStop = true;
            this.ra_TenNXB.Text = "Tên NXB";
            this.ra_TenNXB.UseVisualStyleBackColor = true;
            // 
            // ra_MaNXB
            // 
            this.ra_MaNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_MaNXB.AutoSize = true;
            this.ra_MaNXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_MaNXB.Location = new System.Drawing.Point(22, 32);
            this.ra_MaNXB.Name = "ra_MaNXB";
            this.ra_MaNXB.Size = new System.Drawing.Size(94, 23);
            this.ra_MaNXB.TabIndex = 8;
            this.ra_MaNXB.TabStop = true;
            this.ra_MaNXB.Text = "Mã NXB";
            this.ra_MaNXB.UseVisualStyleBackColor = true;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_TimKiem.Location = new System.Drawing.Point(317, 100);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(109, 39);
            this.bt_TimKiem.TabIndex = 7;
            this.bt_TimKiem.Text = "Tìm ";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // txt_TimKiemNXB
            // 
            this.txt_TimKiemNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiemNXB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TimKiemNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemNXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TimKiemNXB.Location = new System.Drawing.Point(165, 32);
            this.txt_TimKiemNXB.Multiline = true;
            this.txt_TimKiemNXB.Name = "txt_TimKiemNXB";
            this.txt_TimKiemNXB.Size = new System.Drawing.Size(261, 34);
            this.txt_TimKiemNXB.TabIndex = 6;
            // 
            // txt_TenNXB
            // 
            this.txt_TenNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenNXB.Location = new System.Drawing.Point(177, 60);
            this.txt_TenNXB.Multiline = true;
            this.txt_TenNXB.Name = "txt_TenNXB";
            this.txt_TenNXB.Size = new System.Drawing.Size(241, 24);
            this.txt_TenNXB.TabIndex = 3;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Thoat.BackColor = System.Drawing.Color.Red;
            this.bt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Thoat.ForeColor = System.Drawing.Color.White;
            this.bt_Thoat.Location = new System.Drawing.Point(316, 251);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(102, 37);
            this.bt_Thoat.TabIndex = 13;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // txt_MaNXB
            // 
            this.txt_MaNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaNXB.Location = new System.Drawing.Point(177, 21);
            this.txt_MaNXB.Multiline = true;
            this.txt_MaNXB.Name = "txt_MaNXB";
            this.txt_MaNXB.Size = new System.Drawing.Size(241, 24);
            this.txt_MaNXB.TabIndex = 1;
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Luu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Luu.Location = new System.Drawing.Point(40, 251);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(102, 37);
            this.bt_Luu.TabIndex = 12;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NXB:";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Xoa.Location = new System.Drawing.Point(177, 251);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(102, 37);
            this.bt_Xoa.TabIndex = 11;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên NXB:";
            // 
            // bt_Sua
            // 
            this.bt_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sua.Location = new System.Drawing.Point(177, 194);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(102, 37);
            this.bt_Sua.TabIndex = 10;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // txt_DcNXB
            // 
            this.txt_DcNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_DcNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DcNXB.Location = new System.Drawing.Point(177, 105);
            this.txt_DcNXB.Multiline = true;
            this.txt_DcNXB.Name = "txt_DcNXB";
            this.txt_DcNXB.Size = new System.Drawing.Size(241, 24);
            this.txt_DcNXB.TabIndex = 5;
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Them.Location = new System.Drawing.Point(40, 194);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(102, 37);
            this.bt_Them.TabIndex = 9;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ NXB:";
            // 
            // txt_SđtNXB
            // 
            this.txt_SđtNXB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SđtNXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SđtNXB.Location = new System.Drawing.Point(177, 146);
            this.txt_SđtNXB.Multiline = true;
            this.txt_SđtNXB.Name = "txt_SđtNXB";
            this.txt_SđtNXB.Size = new System.Drawing.Size(241, 24);
            this.txt_SđtNXB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Điện thoại NXB:";
            // 
            // FormNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNXB_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNXB_FormClosed);
            this.Load += new System.EventHandler(this.FormNXB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SđtNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_DcNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenNXB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ra_DiaChiNXB;
        private System.Windows.Forms.RadioButton ra_TenNXB;
        private System.Windows.Forms.RadioButton ra_MaNXB;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiemNXB;
        private System.Windows.Forms.Button bt_all;
    }
}
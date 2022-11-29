namespace Quản_Lý_Thư_Viện_1
{
    partial class FormTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTacGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_Luu = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Them = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaTG = new System.Windows.Forms.TextBox();
            this.txt_TenTG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_all = new System.Windows.Forms.Button();
            this.ra_TenTG = new System.Windows.Forms.RadioButton();
            this.ra_MaTG = new System.Windows.Forms.RadioButton();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiemTG = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT TÁC GIẢ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Thoat.BackColor = System.Drawing.Color.Red;
            this.bt_Thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Thoat.ForeColor = System.Drawing.Color.White;
            this.bt_Thoat.Location = new System.Drawing.Point(371, 207);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(110, 38);
            this.bt_Thoat.TabIndex = 4;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = false;
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Luu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Luu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Luu.Location = new System.Drawing.Point(43, 207);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(110, 38);
            this.bt_Luu.TabIndex = 3;
            this.bt_Luu.Text = "Lưu";
            this.bt_Luu.UseVisualStyleBackColor = false;
            this.bt_Luu.Click += new System.EventHandler(this.bt_Luu_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Xoa.Location = new System.Drawing.Point(211, 207);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(110, 38);
            this.bt_Xoa.TabIndex = 2;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = false;
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Sua.Location = new System.Drawing.Point(211, 143);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(110, 38);
            this.bt_Sua.TabIndex = 1;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = false;
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_Them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Them.Location = new System.Drawing.Point(42, 143);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(110, 38);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = false;
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(37, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã tác giả:";
            // 
            // txt_MaTG
            // 
            this.txt_MaTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaTG.Location = new System.Drawing.Point(148, 38);
            this.txt_MaTG.Multiline = true;
            this.txt_MaTG.Name = "txt_MaTG";
            this.txt_MaTG.Size = new System.Drawing.Size(345, 26);
            this.txt_MaTG.TabIndex = 3;
            // 
            // txt_TenTG
            // 
            this.txt_TenTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenTG.Location = new System.Drawing.Point(148, 88);
            this.txt_TenTG.Multiline = true;
            this.txt_TenTG.Name = "txt_TenTG";
            this.txt_TenTG.Size = new System.Drawing.Size(345, 26);
            this.txt_TenTG.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên tác giả:";
            // 
            // luoi
            // 
            this.luoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Location = new System.Drawing.Point(3, 21);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.RowTemplate.Height = 24;
            this.luoi.Size = new System.Drawing.Size(637, 398);
            this.luoi.TabIndex = 6;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.bt_Them);
            this.groupBox1.Controls.Add(this.bt_Thoat);
            this.groupBox1.Controls.Add(this.txt_TenTG);
            this.groupBox1.Controls.Add(this.bt_Sua);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bt_Xoa);
            this.groupBox1.Controls.Add(this.txt_MaTG);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bt_Luu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(649, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 422);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.bt_all);
            this.groupBox3.Controls.Add(this.ra_TenTG);
            this.groupBox3.Controls.Add(this.ra_MaTG);
            this.groupBox3.Controls.Add(this.bt_TimKiem);
            this.groupBox3.Controls.Add(this.txt_TimKiemTG);
            this.groupBox3.Location = new System.Drawing.Point(3, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 168);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // bt_all
            // 
            this.bt_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_all.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_all.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_all.Location = new System.Drawing.Point(38, 107);
            this.bt_all.Name = "bt_all";
            this.bt_all.Size = new System.Drawing.Size(173, 39);
            this.bt_all.TabIndex = 13;
            this.bt_all.Text = "Hiển thị tất cả";
            this.bt_all.UseVisualStyleBackColor = false;
            this.bt_all.Click += new System.EventHandler(this.bt_all_Click);
            // 
            // ra_TenTG
            // 
            this.ra_TenTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_TenTG.AutoSize = true;
            this.ra_TenTG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_TenTG.Location = new System.Drawing.Point(43, 72);
            this.ra_TenTG.Name = "ra_TenTG";
            this.ra_TenTG.Size = new System.Drawing.Size(110, 23);
            this.ra_TenTG.TabIndex = 9;
            this.ra_TenTG.TabStop = true;
            this.ra_TenTG.Text = "Tên tác giả";
            this.ra_TenTG.UseVisualStyleBackColor = true;
            // 
            // ra_MaTG
            // 
            this.ra_MaTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ra_MaTG.AutoSize = true;
            this.ra_MaTG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_MaTG.Location = new System.Drawing.Point(43, 34);
            this.ra_MaTG.Name = "ra_MaTG";
            this.ra_MaTG.Size = new System.Drawing.Size(107, 23);
            this.ra_MaTG.TabIndex = 8;
            this.ra_MaTG.TabStop = true;
            this.ra_MaTG.Text = "Mã tác giả";
            this.ra_MaTG.UseVisualStyleBackColor = true;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_TimKiem.Location = new System.Drawing.Point(368, 107);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(109, 39);
            this.bt_TimKiem.TabIndex = 7;
            this.bt_TimKiem.Text = "Tìm ";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // txt_TimKiemTG
            // 
            this.txt_TimKiemTG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TimKiemTG.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TimKiemTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemTG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TimKiemTG.Location = new System.Drawing.Point(205, 54);
            this.txt_TimKiemTG.Multiline = true;
            this.txt_TimKiemTG.Name = "txt_TimKiemTG";
            this.txt_TimKiemTG.Size = new System.Drawing.Size(273, 34);
            this.txt_TimKiemTG.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.luoi);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 422);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // FormTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTacGia_FormClosed);
            this.Load += new System.EventHandler(this.FormTacGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_Luu;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaTG;
        private System.Windows.Forms.TextBox txt_TenTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ra_TenTG;
        private System.Windows.Forms.RadioButton ra_MaTG;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiemTG;
        private System.Windows.Forms.Button bt_all;
    }
}
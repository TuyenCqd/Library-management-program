namespace Quản_Lý_Thư_Viện_1
{
    partial class FormUpdateSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdateSach));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ra_NXB = new System.Windows.Forms.RadioButton();
            this.ra_NamXB = new System.Windows.Forms.RadioButton();
            this.ra_TG = new System.Windows.Forms.RadioButton();
            this.ra_TL = new System.Windows.Forms.RadioButton();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiemSach = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rad_MaS = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.commatacgia = new System.Windows.Forms.ComboBox();
            this.comnhaxb = new System.Windows.Forms.ComboBox();
            this.comtheloai = new System.Windows.Forms.ComboBox();
            this.thoat = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.luu = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NamXB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.luoi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.ra_NXB);
            this.groupBox1.Controls.Add(this.ra_NamXB);
            this.groupBox1.Controls.Add(this.ra_TG);
            this.groupBox1.Controls.Add(this.ra_TL);
            this.groupBox1.Controls.Add(this.bt_TimKiem);
            this.groupBox1.Controls.Add(this.txt_TimKiemSach);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rad_MaS);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm sách";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quản_Lý_Thư_Viện_1.Properties.Resources.output_onlinegiftools;
            this.pictureBox1.Location = new System.Drawing.Point(22, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ra_NXB
            // 
            this.ra_NXB.AutoSize = true;
            this.ra_NXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_NXB.Location = new System.Drawing.Point(309, 49);
            this.ra_NXB.Name = "ra_NXB";
            this.ra_NXB.Size = new System.Drawing.Size(124, 23);
            this.ra_NXB.TabIndex = 7;
            this.ra_NXB.TabStop = true;
            this.ra_NXB.Text = "Nhà xuất bản";
            this.ra_NXB.UseVisualStyleBackColor = true;
            // 
            // ra_NamXB
            // 
            this.ra_NamXB.AutoSize = true;
            this.ra_NamXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_NamXB.Location = new System.Drawing.Point(309, 21);
            this.ra_NamXB.Name = "ra_NamXB";
            this.ra_NamXB.Size = new System.Drawing.Size(129, 23);
            this.ra_NamXB.TabIndex = 6;
            this.ra_NamXB.TabStop = true;
            this.ra_NamXB.Text = "Năm xuất bản";
            this.ra_NamXB.UseVisualStyleBackColor = true;
            // 
            // ra_TG
            // 
            this.ra_TG.AutoSize = true;
            this.ra_TG.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_TG.Location = new System.Drawing.Point(493, 49);
            this.ra_TG.Name = "ra_TG";
            this.ra_TG.Size = new System.Drawing.Size(110, 23);
            this.ra_TG.TabIndex = 5;
            this.ra_TG.TabStop = true;
            this.ra_TG.Text = "Tên tác giả";
            this.ra_TG.UseVisualStyleBackColor = true;
            // 
            // ra_TL
            // 
            this.ra_TL.AutoSize = true;
            this.ra_TL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ra_TL.Location = new System.Drawing.Point(493, 21);
            this.ra_TL.Name = "ra_TL";
            this.ra_TL.Size = new System.Drawing.Size(122, 23);
            this.ra_TL.TabIndex = 4;
            this.ra_TL.TabStop = true;
            this.ra_TL.Text = "Tên thể Loại";
            this.ra_TL.UseVisualStyleBackColor = true;
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bt_TimKiem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_TimKiem.Location = new System.Drawing.Point(958, 21);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(109, 39);
            this.bt_TimKiem.TabIndex = 3;
            this.bt_TimKiem.Text = "Tìm ";
            this.bt_TimKiem.UseVisualStyleBackColor = false;
            this.bt_TimKiem.Click += new System.EventHandler(this.bt_TimKiem_Click);
            // 
            // txt_TimKiemSach
            // 
            this.txt_TimKiemSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_TimKiemSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemSach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TimKiemSach.Location = new System.Drawing.Point(635, 26);
            this.txt_TimKiemSach.Multiline = true;
            this.txt_TimKiemSach.Name = "txt_TimKiemSach";
            this.txt_TimKiemSach.Size = new System.Drawing.Size(273, 34);
            this.txt_TimKiemSach.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButton2.Location = new System.Drawing.Point(154, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên Sách";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rad_MaS
            // 
            this.rad_MaS.AutoSize = true;
            this.rad_MaS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rad_MaS.Location = new System.Drawing.Point(154, 21);
            this.rad_MaS.Name = "rad_MaS";
            this.rad_MaS.Size = new System.Drawing.Size(92, 23);
            this.rad_MaS.TabIndex = 0;
            this.rad_MaS.TabStop = true;
            this.rad_MaS.Text = "Mã Sách";
            this.rad_MaS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.commatacgia);
            this.groupBox2.Controls.Add(this.comnhaxb);
            this.groupBox2.Controls.Add(this.comtheloai);
            this.groupBox2.Controls.Add(this.thoat);
            this.groupBox2.Controls.Add(this.import);
            this.groupBox2.Controls.Add(this.luu);
            this.groupBox2.Controls.Add(this.xoa);
            this.groupBox2.Controls.Add(this.sua);
            this.groupBox2.Controls.Add(this.them);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_NamXB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_TenS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_MaS);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật sách";
            // 
            // commatacgia
            // 
            this.commatacgia.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.commatacgia.FormattingEnabled = true;
            this.commatacgia.Location = new System.Drawing.Point(910, 69);
            this.commatacgia.Name = "commatacgia";
            this.commatacgia.Size = new System.Drawing.Size(258, 27);
            this.commatacgia.TabIndex = 20;
            // 
            // comnhaxb
            // 
            this.comnhaxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comnhaxb.FormattingEnabled = true;
            this.comnhaxb.Location = new System.Drawing.Point(524, 62);
            this.comnhaxb.Name = "comnhaxb";
            this.comnhaxb.Size = new System.Drawing.Size(258, 27);
            this.comnhaxb.TabIndex = 19;
            // 
            // comtheloai
            // 
            this.comtheloai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comtheloai.FormattingEnabled = true;
            this.comtheloai.Location = new System.Drawing.Point(910, 29);
            this.comtheloai.Name = "comtheloai";
            this.comtheloai.Size = new System.Drawing.Size(258, 27);
            this.comtheloai.TabIndex = 18;
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.Red;
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoat.ForeColor = System.Drawing.Color.White;
            this.thoat.Location = new System.Drawing.Point(979, 112);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(88, 42);
            this.thoat.TabIndex = 17;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // import
            // 
            this.import.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.import.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.import.Location = new System.Drawing.Point(773, 112);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(148, 42);
            this.import.TabIndex = 16;
            this.import.Text = "Hiển thị tất cả";
            this.import.UseVisualStyleBackColor = false;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // luu
            // 
            this.luu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.luu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.luu.Location = new System.Drawing.Point(579, 112);
            this.luu.Name = "luu";
            this.luu.Size = new System.Drawing.Size(88, 42);
            this.luu.TabIndex = 15;
            this.luu.Text = "Lưu";
            this.luu.UseVisualStyleBackColor = false;
            this.luu.Click += new System.EventHandler(this.luu_Click);
            // 
            // xoa
            // 
            this.xoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.xoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.xoa.Location = new System.Drawing.Point(393, 112);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(88, 42);
            this.xoa.TabIndex = 14;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = false;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sua.Location = new System.Drawing.Point(213, 112);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(88, 42);
            this.sua.TabIndex = 13;
            this.sua.Text = "Sửa";
            this.sua.UseVisualStyleBackColor = false;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.them.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.them.Location = new System.Drawing.Point(22, 112);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(88, 42);
            this.them.TabIndex = 12;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = false;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(829, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tác giả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(402, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nhà xuất bản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(829, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thể loại:";
            // 
            // txt_NamXB
            // 
            this.txt_NamXB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NamXB.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NamXB.Location = new System.Drawing.Point(524, 29);
            this.txt_NamXB.Multiline = true;
            this.txt_NamXB.Name = "txt_NamXB";
            this.txt_NamXB.Size = new System.Drawing.Size(258, 21);
            this.txt_NamXB.TabIndex = 5;
            this.txt_NamXB.TextChanged += new System.EventHandler(this.txt_NamXB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(402, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm xuất bản:";
            // 
            // txt_TenS
            // 
            this.txt_TenS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TenS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenS.Location = new System.Drawing.Point(101, 70);
            this.txt_TenS.Multiline = true;
            this.txt_TenS.Name = "txt_TenS";
            this.txt_TenS.Size = new System.Drawing.Size(258, 21);
            this.txt_TenS.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách:";
            // 
            // txt_MaS
            // 
            this.txt_MaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaS.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaS.Location = new System.Drawing.Point(101, 30);
            this.txt_MaS.Multiline = true;
            this.txt_MaS.Name = "txt_MaS";
            this.txt_MaS.Size = new System.Drawing.Size(258, 21);
            this.txt_MaS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách:";
            // 
            // luoi
            // 
            this.luoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.luoi.Location = new System.Drawing.Point(0, 256);
            this.luoi.Name = "luoi";
            this.luoi.RowHeadersWidth = 51;
            this.luoi.RowTemplate.Height = 24;
            this.luoi.Size = new System.Drawing.Size(1182, 341);
            this.luoi.TabIndex = 0;
            this.luoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luoi_CellContentClick);
            // 
            // FormUpdateSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.luoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUpdateSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUpdateSach_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdateSach_FormClosed);
            this.Load += new System.EventHandler(this.FormUpdateSach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView luoi;
        private System.Windows.Forms.TextBox txt_TimKiemSach;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rad_MaS;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button luu;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NamXB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox commatacgia;
        private System.Windows.Forms.ComboBox comnhaxb;
        private System.Windows.Forms.ComboBox comtheloai;
        private System.Windows.Forms.RadioButton ra_NXB;
        private System.Windows.Forms.RadioButton ra_NamXB;
        private System.Windows.Forms.RadioButton ra_TG;
        private System.Windows.Forms.RadioButton ra_TL;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
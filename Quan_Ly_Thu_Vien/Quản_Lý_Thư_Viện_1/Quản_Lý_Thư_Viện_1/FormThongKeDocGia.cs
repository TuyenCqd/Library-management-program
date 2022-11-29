using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quản_Lý_Thư_Viện_1
{
    public partial class FormThongKeDocGia : Form
    {
        public FormThongKeDocGia()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormThongKeDocGia(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        Update t = new Update();
        private void FormThongKeDocGia_Load(object sender, EventArgs e)
        {
            loaddata();
            tuychon.Text = "Tất cả độc giả";
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_DocGia");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Tên độc giả";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Lớp";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select distinct tb_DocGia.MaDG,tb_DocGia.TenDG, tb_DocGia.NgaySinh,tb_DocGia.GioiTinh, tb_DocGia.Lop from tb_DocGia, tb_PhieuMuon,tb_ChiTietPhieuMuon where (tb_DocGia.MaDG=tb_PhieuMuon.MaDG and tb_PhieuMuon.MaP=tb_ChiTietPhieuMuon.MaP and tb_ChiTietPhieuMuon.NgayHenTra<GETDATE())");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Tên độc giả";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới";
            luoi.Columns[4].HeaderText = "Lớp";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả độc giả")
                loaddata();
            else loaddata1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XuatExcel excel = new XuatExcel();
            if (tuychon.Text == "Tất cả độc giả")
            {
                DataTable dt = (DataTable)luoi.DataSource;
                excel.Export_DocGia(dt, "Độc giả", "Thống kê độc giả");
            }
            else
            {     
                DataTable dt1 = (DataTable)luoi.DataSource;
                excel.Export_DocGia(dt1, "Độc giả", "Thống kê các độc giả trễ hạn");
            }
        }
        private void FormThongKeDocGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

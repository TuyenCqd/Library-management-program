using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_1
{
    public partial class FormThongKeSach : Form
    {
        public FormThongKeSach()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormThongKeSach(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        private void FormThongKeSach_Load(object sender, EventArgs e)
        {
            tuychon.Text = "Tất cả sách";

            loaddata();
        }
        Update t = new Update();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select  MaS, TenS, TenNXB, NamXB, TenTG,TenTL \r\nfrom tb_Sach, tb_NhaXuatBan, tb_TheLoai ,tb_TacGia\r\nwhere tb_Sach.idNXB=tb_NhaXuatBan.idNXB  and tb_Sach.MaTG=tb_TacGia.MaTG and tb_Sach.MaTL=tb_TheLoai.MaTL");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Tác giả";
            luoi.Columns[5].HeaderText = "Thể loại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select tb_Sach.MaS, tb_Sach.TenS, tb_NhaXuatBan.TenNXB,tb_Sach.NamXB,tb_TacGia.TenTG,tb_TheLoai.TenTL from tb_Sach, tb_NhaXuatBan, tb_TheLoai,tb_TacGia, tb_ChiTietPhieuMuon where (tb_Sach.idNXB=tb_NhaXuatBan.idNXB and tb_Sach.MaTL=tb_TheLoai.MaTL and tb_Sach.MaTG=tb_TacGia.MaTG and tb_Sach.MaS=tb_ChiTietPhieuMuon.MaS)\r\n");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Tác giả";
            luoi.Columns[5].HeaderText = "Thể loại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select tb_Sach.MaS, tb_Sach.TenS, tb_NhaXuatBan.TenNXB,tb_Sach.NamXB,tb_TacGia.TenTG,tb_TheLoai.TenTL from tb_Sach, tb_NhaXuatBan, tb_TheLoai,tb_TacGia, tb_ChiTietPhieuMuon where (tb_Sach.idNXB=tb_NhaXuatBan.idNXB and tb_Sach.MaTL=tb_TheLoai.MaTL and tb_Sach.MaS=tb_ChiTietPhieuMuon.MaS and tb_Sach.MaTG=tb_TacGia.MaTG and tb_ChiTietPhieuMuon.NgayHenTra<GETDATE())\r\n");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Tác giả";
            luoi.Columns[5].HeaderText = "Thể loại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả sách")
                loaddata();
            else if (tuychon.Text == "Sách đang mượn")
                loaddata1();
            else if (tuychon.Text == "Sách trễ hạn")
                loaddata2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XuatExcel excel = new XuatExcel();
            if (tuychon.Text == "Tất cả sách")
            {
                DataTable dt = (DataTable)luoi.DataSource;
                excel.Export_Sach(dt, "Sách", "Thống kê tất cả sách");
            }
            else if (tuychon.Text == "Sách đang mượn")
            {
                DataTable dt1 = (DataTable)luoi.DataSource;
                excel.Export_Sach(dt1, "Sách", "Thống kê sách đang mượn");
            }
            else if (tuychon.Text == "Sách trễ hạn")
            {
                DataTable dt2 = (DataTable)luoi.DataSource;
                excel.Export_Sach(dt2, "Sách", "Thống kê sách trễ hạn");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void FormThongKeSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

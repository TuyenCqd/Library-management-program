using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Quản_Lý_Thư_Viện_1
{
    public partial class FormTimKiem : Form
    {
        public FormTimKiem()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormTimKiem(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        Update t = new Update();
        
        private void loaddataSach()
        {
            DataTable dt = t.docdulieu("select * from tb_Sach");
            l_SoSach.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoiSach.DataSource = dt;
            }
            luoiSach.Columns[0].HeaderText = "Mã sách";
            luoiSach.Columns[1].HeaderText = "Tên sách";
            luoiSach.Columns[2].Width = 50;
            luoiSach.Columns[2].HeaderText = "Năm xuất bản";
            luoiSach.Columns[3].HeaderText = "Mã nhà xuất bản";
            luoiSach.Columns[4].HeaderText = "Mã thể loại";
            luoiSach.Columns[5].HeaderText = "Mã tác giả";
            luoiSach.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoiSach.Enabled = true;

        }
        private void loaddataDocGia()
        {
            DataTable dt2 = t.docdulieu("select * from tb_DocGia");
            l_DG.Text = dt2.Rows.Count.ToString();

            if (dt2 != null)
            {
                luoiDocGia.DataSource = dt2;
            }
            luoiDocGia.Columns[0].HeaderText = "Mã độc giả";
            luoiDocGia.Columns[1].HeaderText = "Họ và tên";
            luoiDocGia.Columns[2].HeaderText = "Ngày sinh";
            luoiDocGia.Columns[3].HeaderText = "Giới tính";
            luoiDocGia.Columns[4].HeaderText = "Lớp";
            luoiDocGia.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoiDocGia.Enabled = true;

        }
        private void loaddataNhanVien()
        {
            DataTable dt1 = t.docdulieu("select * from tb_NhanVien");
            l_SoNV.Text = dt1.Rows.Count.ToString();

            if (dt1 != null)
            {
                luoiNV.DataSource = dt1;
            }
            luoiNV.Columns[0].HeaderText = "Mã nhân viên";
            luoiNV.Columns[1].Width = 200;
            luoiNV.Columns[1].HeaderText = "Họ và tên";
            luoiNV.Columns[2].HeaderText = "Ngày sinh";
            luoiNV.Columns[3].HeaderText = "Giới tính";
            luoiNV.Columns[4].HeaderText = "Địa chỉ";
            luoiNV.Columns[5].HeaderText = "Số điện thoại";
            luoiNV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoiNV.Enabled = true;

        }
        private void loaddataPhieu()
        {
            DataTable dtPhieu = t.docdulieu("select * from CTPhieu");
            DataTable dtSoPhieu = t.docdulieu("select distinct(MaP) from CTPhieu");
            l_Phiếu.Text = dtSoPhieu.Rows.Count.ToString();

            if (dtPhieu != null)
            {
                luoi_Phieu.DataSource = dtPhieu;
            }
            luoi_Phieu.Columns[0].Width = 60;
            luoi_Phieu.Columns[0].HeaderText = "Mã phiếu";
            luoi_Phieu.Columns[1].Width = 180;
            luoi_Phieu.Columns[1].HeaderText = "Tên độc giả";
            luoi_Phieu.Columns[2].Width = 180;
            luoi_Phieu.Columns[2].HeaderText = "Người lập phiếu";
            luoi_Phieu.Columns[3].Width = 60;
            luoi_Phieu.Columns[3].HeaderText = "Mã sách";
            luoi_Phieu.Columns[4].HeaderText = "Tên sách";
            luoi_Phieu.Columns[5].HeaderText = "Ngày mượn";
            luoi_Phieu.Columns[6].HeaderText = "Ngày hẹn trả";
            luoi_Phieu.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi_Phieu.Enabled = true;

        }
        private void FormTimKiem_Load(object sender, EventArgs e)
        {
            loaddataSach();
            loaddataDocGia();
            loaddataNhanVien();
            loaddataPhieu();
        }

        private void bt_ThoatTKSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_TimKiemDG_Click(object sender, EventArgs e)
        {
            DataTable dtMaDG = t.docdulieu("select * from tb_DocGia where MaDG = N'" + txt_TimKiemDG.Text + "'");
            DataTable dtTenDG = t.docdulieu("select * from tb_DocGia where TenDG = N'" + txt_TimKiemDG.Text + "'");
            DataTable dtGioiTinhDG = t.docdulieu("select * from tb_DocGia where GioiTinh = N'" + txt_TimKiemDG.Text + "'");
            DataTable dtLopDG = t.docdulieu("select * from tb_DocGia where Lop = N'" + txt_TimKiemDG.Text + "'");
            if (ra_MaDG.Checked == true)
            {
                luoiDocGia.DataSource = dtMaDG;
                if (luoiDocGia.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (rad_TenDG.Checked == true)
            {
                luoiDocGia.DataSource = dtTenDG;
                if (luoiDocGia.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_GioiTinh.Checked == true)
            {
                luoiDocGia.DataSource = dtGioiTinhDG;
                if (luoiDocGia.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_Lop.Checked == true)
            {
                luoiDocGia.DataSource = dtLopDG;
                if (luoiDocGia.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }
            private void bt_ThoatTKDG_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_TimNV_Click(object sender, EventArgs e)
        {
            DataTable dtMaNV = t.docdulieu("select * from tb_NhanVien where MaNV = N'" + txt_TimKiemNV.Text + "'");
            DataTable dtTenNV = t.docdulieu("select * from tb_NhanVien where TenNV = N'" + txt_TimKiemNV.Text + "'");
            DataTable dtGioiTinhNV = t.docdulieu("select * from tb_NhanVien where GioiTinh = N'" + txt_TimKiemNV.Text + "'");
            DataTable dtDiaChiNV = t.docdulieu("select * from tb_NhanVien where DaiChi = N'" + txt_TimKiemNV.Text + "'");
            DataTable dtSdtNV = t.docdulieu("select * from tb_NhanVien where Sdt = N'" + txt_TimKiemNV.Text + "'");
            if (ra_MaNV.Checked == true)
            {
                luoiNV.DataSource = dtMaNV;
                if (luoiNV.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (rad_TenNV.Checked == true)
            {
                luoiNV.DataSource = dtTenNV;
                if (luoiNV.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_GioiTinhNV.Checked == true)
            {
                luoiNV.DataSource = dtGioiTinhNV;
                if (luoiNV.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_DiaChiNV.Checked == true)
            {
                luoiNV.DataSource = dtDiaChiNV;
                if (luoiNV.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_SdtNV.Checked == true)
            {
                luoiNV.DataSource = dtSdtNV;
                if (luoiNV.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void bt_ThoatTimNV_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_allDG_Click(object sender, EventArgs e)
        {
            DataTable dtAllDG = t.docdulieu("select * from tb_DocGia ");
            luoiDocGia.DataSource = dtAllDG;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtAllNV = t.docdulieu("select * from tb_NhanVien ");
            luoiNV.DataSource = dtAllNV;
        }

        private void bt_ThoatPhieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_TimPhieu_Click(object sender, EventArgs e)
        {
            DataTable dtMaP = t.docdulieu("select * from CTPhieu where MaP = N'" + txt_TimKiemPhieu.Text + "'");
            DataTable dtTenDG = t.docdulieu("select * from CTPhieu where TenDG = N'" + txt_TimKiemPhieu.Text + "'");
            DataTable dtTenNV = t.docdulieu("select * from CTPhieu where TenNV = N'" + txt_TimKiemPhieu.Text + "'");
            if (ra_MaP.Checked == true)
            {
                luoi_Phieu.DataSource = dtMaP;
                if (luoi_Phieu.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_NVLapPhieu.Checked == true)
            {
                luoi_Phieu.DataSource = dtTenNV;
                if (luoi_Phieu.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TenDGMuon.Checked == true)
            {
                luoi_Phieu.DataSource = dtTenDG;
                if (luoi_Phieu.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void bt_allPhieu_Click(object sender, EventArgs e)
        {
            ra_MaP.Checked = false;
            ra_TenDGMuon.Checked = false;
            ra_NVLapPhieu.Checked = false;
            DataTable dtAllPhieu = t.docdulieu("select * from CTPhieu");
            luoi_Phieu.DataSource = dtAllPhieu;
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from tb_Sach where MaS = N'" + txt_TimKiemSach.Text + "'");
            DataTable dt6 = t.docdulieu("select * from tb_Sach where TenS = N'" + txt_TimKiemSach.Text + "'");
            DataTable dt7 = t.docdulieu("select * from tb_Sach where NamXB = N'" + txt_TimKiemSach.Text + "'");
            DataTable dt8 = t.docdulieu("select * from tb_Sach where idNXB in ( select idNXB from tb_NhaXuatBan where TenNXB = N'" + txt_TimKiemSach.Text + "')");
            DataTable dt9 = t.docdulieu("select * from tb_Sach where MaTL in ( select MaTL from tb_TheLoai where TenTL = N'" + txt_TimKiemSach.Text + "')");
            DataTable dt10 = t.docdulieu("select * from tb_Sach where MaTG in ( select MaTG from tb_TacGia where TenTG = N'" + txt_TimKiemSach.Text + "')");
            if (rad_MaS.Checked == true)
            {
                luoiSach.DataSource = dt5;
                if (luoiSach.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TenS.Checked == true)
            {
                luoiSach.DataSource = dt6;
                if (luoiSach.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_NamXB.Checked == true)
            {
                luoiSach.DataSource = dt7;
                if (luoiSach.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_NXB.Checked == true)
            {
                luoiSach.DataSource = dt8;
                if (luoiSach.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TL.Checked == true)
            {
                luoiSach.DataSource = dt9;
                if (luoiSach.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TG.Checked == true)
            {
                luoiSach.DataSource = dt10;
                if (luoiSach.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataTable dtAllSach = t.docdulieu("select * from tb_Sach ");
            luoiSach.DataSource = dtAllSach;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void FormTimKiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

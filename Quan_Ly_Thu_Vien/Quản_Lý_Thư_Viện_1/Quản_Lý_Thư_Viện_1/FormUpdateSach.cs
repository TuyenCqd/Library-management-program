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
    public partial class FormUpdateSach : Form
    {
        public FormUpdateSach()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormUpdateSach(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }

        private void FormUpdateSach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        Update t = new Update();
        
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_Sach");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].Width = 100;
            luoi.Columns[0].HeaderText = "Mã sách ";
            luoi.Columns[1].Width = 180;
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].Width = 100;
            luoi.Columns[2].HeaderText = "Năm XB";
            luoi.Columns[3].Width = 100;
            luoi.Columns[3].HeaderText = "Mã NXB";
            luoi.Columns[4].Width = 100;
            luoi.Columns[4].HeaderText = "Mã thể loại";
            luoi.Columns[5].Width = 100;
            luoi.Columns[5].HeaderText = "Mã tác giả";
            //luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from tb_NhaXuatBan");
            DataTable dt1 = t.docdulieu("select * from tb_TheLoai");
            DataTable dt2 = t.docdulieu("select * from tb_TacGia");
            comnhaxb.DataSource = dt;
            comnhaxb.DisplayMember = "TenNXB";
            comnhaxb.ValueMember = "idNXB";
            comtheloai.DataSource = dt1;
            comtheloai.DisplayMember = "TenTL";
            comtheloai.ValueMember = "MaTL";
            commatacgia.DataSource = dt2;
            commatacgia.DisplayMember = "TenTG";
            commatacgia.ValueMember = "MaTG";
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaS.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txt_TenS.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txt_NamXB.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comnhaxb.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            comtheloai.Text = luoi.CurrentRow.Cells[4].Value.ToString();
            commatacgia.Text = luoi.CurrentRow.Cells[5].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            txt_MaS.Text = "";
            txt_TenS.Text = "";
            luu.Enabled = true;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
            loadcombo();
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (txt_MaS.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                txt_MaS.Focus();
            }
            else if (txt_TenS.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txt_TenS.Focus();
            }
            else if (txt_NamXB.Text == "")
            {
                MessageBox.Show("Chưa nhập năm xuất bản");
                txt_NamXB.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO tb_Sach VALUES (N'" + txt_MaS.Text + "',N'" + txt_TenS.Text + "',N'" + txt_NamXB.Text + "',N'" + comnhaxb.SelectedValue.ToString() + "',N'" + comtheloai.SelectedValue.ToString() + "',N'" + commatacgia.SelectedValue.ToString() + "')") == true)
            {
                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi");
        }

        private void txt_NamXB_TextChanged(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(txt_NamXB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");

            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (sua.Text == "hủy")
            {
                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
                loaddata();
                luoi.Enabled = true;
            }
            else
            {
                txt_MaS.Enabled = false;
                if (txt_TenS.Text == "")
                {
                    txt_TenS.Focus();
                }
                else if (txt_NamXB.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txt_NamXB.Focus();

                    // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                }
                else if (t.thucthidulieu("update  tb_Sach set TenS=N'" + txt_TenS.Text + "', NamXB=N'" + txt_NamXB.Text + "', idNXB=N'" + comnhaxb.Text + "', MaTL=N'" + comtheloai.Text + "', MaTG=N'" + commatacgia.Text + "'where MaS=N'" + txt_MaS.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                    txt_MaS.Enabled = true;
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (xoa.Text == "hủy")
            {
                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
                loaddata();
                luoi.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txt_MaS.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from tb_Sach where MaS='" + txt_MaS.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata();
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void import_Click(object sender, EventArgs e)
        {
            DataTable dt11= t.docdulieu("select * from tb_Sach ");
            luoi.DataSource = dt11;
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
                luoi.DataSource = dt5;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (radioButton2.Checked == true)
            {
                luoi.DataSource = dt6;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_NamXB.Checked == true)
            {
                luoi.DataSource = dt7;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_NXB.Checked == true)
            {
                luoi.DataSource = dt8;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TL.Checked == true)
            {
                luoi.DataSource = dt9;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TG.Checked == true)
            {
                luoi.DataSource = dt10;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void FormUpdateSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult ret = MessageBox.Show(
                "Bạn có chắc muôn thoát không ?",
                "Lưu ý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
        private void FormUpdateSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

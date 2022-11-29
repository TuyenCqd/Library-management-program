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
    public partial class FormNXB : Form
    {
        public FormNXB()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormNXB(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        Update t = new Update();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_NhaXuatBan");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã nhà XB";
            luoi.Columns[1].HeaderText = "Tên nhà XB";
            luoi.Columns[2].HeaderText = "Địa chỉ";
            luoi.Columns[3].HeaderText = "Điện thoại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            bt_Xoa.Enabled = true;
            bt_Sua.Text = "Sửa";
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
            bt_Luu.Enabled = false;
            luoi.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bt_Xoa.Text == "hủy")
            {

                bt_Luu.Enabled = false;
                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Xoa.Text = "Xóa";
                bt_Sua.Text = "Sửa";
                bt_Them.Enabled = true;
                loaddata();
                luoi.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txt_MaNXB.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from tb_NhaXuatBan where idNXB='" + txt_MaNXB.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");
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

        private void FormNXB_FormClosing(object sender, FormClosingEventArgs e)
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

        private void FormNXB_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNXB.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txt_TenNXB.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txt_DcNXB.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            txt_SđtNXB.Text = luoi.CurrentRow.Cells[3].Value.ToString();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaNXB.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhà xuất bản");
                txt_MaNXB.Focus();

            }
            else if (txt_TenNXB.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhà xuất bản");
                txt_TenNXB.Focus();


            }
            else if (txt_DcNXB.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txt_DcNXB.Focus();


            }
            else if (txt_SđtNXB.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại");
                txt_SđtNXB.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO tb_NhaXuatBan VALUES (N'" + txt_MaNXB.Text + "',N'" + txt_TenNXB.Text + "',N'" + txt_DcNXB.Text + "',N'" + txt_SđtNXB.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            txt_MaNXB.Text = "";
            txt_TenNXB.Text = "";
            txt_DcNXB.Text = "";
            txt_SđtNXB.Text = "";
            bt_Luu.Enabled = true;
            bt_Xoa.Enabled = false;
            bt_Sua.Text = "hủy";
            bt_Them.Enabled = false;
            //luoi.Enabled = true;
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (bt_Sua.Text == "hủy")
            {
                bt_Luu.Enabled = false;
                bt_Sua.Enabled = true;
                bt_Xoa.Enabled = true;
                bt_Xoa.Text = "Xóa";
                bt_Sua.Text = "Sửa";
                bt_Them.Enabled = true;
                loaddata();
                luoi.Enabled = true;


            }
            else
            {


                if (txt_TenNXB.Text == "")
                {
                    MessageBox.Show("Nhà xuất bản chưa có thông tin");
                    txt_TenNXB.Focus();

                }
                else if (txt_DcNXB.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txt_DcNXB.Focus();


                }
                else if (t.thucthidulieu("update  tb_NhaXuatBan set TenNXB=N'" + txt_TenNXB.Text + "', DiaChi=N'" + txt_DcNXB.Text + "', Sdt='" + txt_SđtNXB.Text + "'where idNXB=N'" + txt_MaNXB.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = t.docdulieu("select * from tb_NhaXuatBan where idNXB = N'" + txt_TimKiemNXB.Text + "'");
            DataTable dt2 = t.docdulieu("select * from tb_NhaXuatBan where TenNXB = N'" + txt_TimKiemNXB.Text + "'");
            DataTable dt3 = t.docdulieu("select * from tb_NhaXuatBan where DiaChi = N'" + txt_TimKiemNXB.Text + "'");
            if (ra_MaNXB.Checked == true)
            {
                luoi.DataSource = dt1;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TenNXB.Checked == true)
            {
                luoi.DataSource = dt2; if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_DiaChiNXB.Checked == true)
            {
                luoi.DataSource = dt3; if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            DataTable dt4 = t.docdulieu("select * from tb_NhaXuatBan ");
            luoi.DataSource = dt4;
        }

        private void FormNXB_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

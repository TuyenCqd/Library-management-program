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
    public partial class FormQuanLyTainKhoan : Form
    {
        public FormQuanLyTainKhoan()
        {
            InitializeComponent();
        }
        Update t=new Update(); 
        private void FormQuanLyTainKhoan_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_TaiKhoan");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "Tên đăng nhập";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[1].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[2].HeaderText = "Mật Khẩu";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Quyền";
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
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
            DataTable dt = t.docdulieu("select * from tb_NhanVien");
            txt_MaNV.DataSource = dt;
            txt_MaNV.DisplayMember = "MaNV";
        }
        private void them_Click(object sender, EventArgs e)
        {
            txt_TenDangNhap.Text = "";
            txt_MaNV.Text = "";
            txt_MatKhau.Text = "";
            txt_Email.Text = "";

            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            dataGridView1.Enabled = false;

            loadcombo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_TenDangNhap.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_MaNV.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_MatKhau.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_Email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_Quyen.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
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

                if (txt_TenDangNhap.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên đăng nhập");
                    txt_TenDangNhap.Focus();

                }
                else if (txt_MaNV.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã nhân viên");
                    txt_MaNV.Focus();
                }
                else if (txt_MatKhau.Text == "")
                {
                    MessageBox.Show("Chưa nhập mật khẩu");
                    txt_MatKhau.Focus();
                }
                else if (txt_Email.Text == "")
                {
                    MessageBox.Show("Chưa nhập email");
                    txt_Email.Focus();
                }
                else if (txt_Quyen.Text == "")
                {
                    MessageBox.Show("Chưa nhập quyền");
                    txt_Quyen.Focus();
                }
                else if (t.thucthidulieu("update  tb_TaiKhoan set TenDangNhap=N'" + txt_TenDangNhap.Text + "', MaNV=N'" + txt_MaNV.Text + "', MatKhau=N'" + txt_MatKhau.Text + "', Email=N'" + txt_Email.Text + "', Quyen=N'" + txt_Quyen.Text + "'where TenDangNhap=N'" + txt_TenDangNhap.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (txt_TenDangNhap.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập");
                txt_TenDangNhap.Focus();

            }
            else if (txt_MaNV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txt_MaNV.Focus();
            }
            else if (txt_MatKhau.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txt_MatKhau.Focus();
            }
            else if (txt_Email.Text == "")
            {
                MessageBox.Show("Chưa nhập email");
                txt_Email.Focus();
            }
            else if (txt_Quyen.Text == "")
            {
                MessageBox.Show("Chưa nhập quyền");
                txt_Quyen.Focus();
            }
            else if (t.thucthidulieu("INSERT INTO tb_TaiKhoan VALUES (N'" + txt_TenDangNhap.Text + "',N'" + txt_MaNV.Text + "','" + txt_MatKhau.Text + "',N'" + txt_Email.Text + "',N'" + txt_Quyen.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else MessageBox.Show("Lỗi !!!");
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa tài khoản có mã " + txt_MaNV.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from tb_TaiKhoan where MaNV='" + txt_MaNV.Text + "'") == true)
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

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = t.docdulieu("select * from tb_TaiKhoan where TenDangNhap = N'" + txt_TimKiemTaiKhoan.Text + "'");
            DataTable dt2 = t.docdulieu("select * from tb_TaiKhoan where MaNV = N'" + txt_TimKiemTaiKhoan.Text + "'");
            DataTable dt3 = t.docdulieu("select * from tb_TaiKhoan where Email = N'" + txt_TimKiemTaiKhoan.Text + "'");
            DataTable dt4 = t.docdulieu("select * from tb_TaiKhoan where Quyen = N'" + txt_TimKiemTaiKhoan.Text + "'");
            if (ra_TenDangNhap.Checked == true)
            {
                dataGridView1.DataSource = dt1;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_MaNV.Checked == true)
            {
                dataGridView1.DataSource = dt2;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_Email.Checked == true)
            {
                dataGridView1.DataSource = dt3;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_Quyen.Checked == true)
            {
                dataGridView1.DataSource = dt4;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from tb_TaiKhoan");
            dataGridView1.DataSource = dt5;
        }

        private void FormQuanLyTainKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }
    }
}

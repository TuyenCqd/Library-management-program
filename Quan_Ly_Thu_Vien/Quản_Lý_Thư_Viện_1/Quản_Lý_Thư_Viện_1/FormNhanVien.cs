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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        Update t =new Update();
        
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_NhanVien");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã nhân viên";
            luoi.Columns[1].HeaderText = "Họ và tên";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Địa chỉ";
            luoi.Columns[5].HeaderText = "Điện thoại";


            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanhanvien.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttennhanvien.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtdiachi.Text = luoi.CurrentRow.Cells[4].Value.ToString();
            txtdienthoai.Text = luoi.CurrentRow.Cells[5].Value.ToString();

        }
        private void them_Click(object sender, EventArgs e)
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            txtdiachi.Text = "";
            txtdienthoai.Text = "";
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }

        private void luu_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhân viên");
                txtmanhanvien.Focus();

            }
            else if (txttennhanvien.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                txttennhanvien.Focus();


            }
            else if (txtdiachi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ");
                txtdiachi.Focus();


            }
            else if (txtdienthoai.Text == "")
            {
                MessageBox.Show("Chưa nhập điện thoại");
                txtdienthoai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO tb_NhanVien VALUES (N'" + txtmanhanvien.Text + "',N'" + txttennhanvien.Text + "','" + ngayhh + "',N'" + comgioitinh.Text + "',N'" + txtdiachi.Text + "','" + txtdienthoai.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");



                txtmanhanvien.Focus();

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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmanhanvien.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from tb_NhanVien where MaNV='" + txtmanhanvien.Text + "'") == true)
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

        private void sua_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");

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

                if (txttennhanvien.Text == "")
                {
                    txttennhanvien.Focus();

                }
                else if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtdiachi.Focus();


                }
                else if (txtdienthoai.Text == "")
                {
                    MessageBox.Show("Chưa nhập số điện thoại");
                    txtdienthoai.Focus();


                }
                else if (t.thucthidulieu("update  tb_NhanVien set TenNV=N'" + txttennhanvien.Text + "', NgaySinh='" + ngayhh + "', GioiTinh=N'" + comgioitinh.Text + "', DiaChi=N'" + txtdiachi.Text + "', Sdt='" + txtdienthoai.Text + "' where MaNV='" + txtmanhanvien.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            DataTable dt10 = t.docdulieu("select * from tb_NhanVien ");
            luoi.DataSource = dt10;
        }

        private void FormNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new FormMain();
            f.Show();
        }
    }
}

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
    public partial class FormDocGia : Form
    {
        public FormDocGia()
        {
            InitializeComponent();
        }
        Update t = new Update();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_DocGia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns[0].HeaderText = "Mã độc giả";
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[1].HeaderText = "Họ và tên";
            dataGridView1.Columns[2].HeaderText = "Ngày sinh";
            dataGridView1.Columns[3].HeaderText = "Giới tính";
            dataGridView1.Columns[4].Width = 180;
            dataGridView1.Columns[4].HeaderText = "Lớp";
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormDocGia(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        private void FormDocGia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmadocgia.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtlop.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void them_Click_1(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txttendocgia.Text = "";

            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            //dataGridView1.Enabled = false;
        }

        private void luu_Click_1(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");
            if (txtmadocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập mã độc giả");
                txtmadocgia.Focus();

            }
            else if (txttendocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên độc giả");
                txttendocgia.Focus();
            }
            else if (txtlop.Text == "")
            {
                MessageBox.Show("Chưa nhập lớp");
                txtlop.Focus();
            }
            else if (comgioitinh.Text == "")
            {
                MessageBox.Show("Chưa nhập giới tính");
                txtlop.Focus();
            }

            else if (t.thucthidulieu("INSERT INTO tb_DocGia VALUES (N'" + txtmadocgia.Text + "',N'" + txttendocgia.Text + "','" + ngayhh + "',N'" + comgioitinh.Text + "',N'" + txtlop.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi trùng khhóa");
                txtmadocgia.Focus();
            }
        }

        private void sua_Click_1(object sender, EventArgs e)
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

                if (txttendocgia.Text == "")
                {
                    txttendocgia.Focus();

                }
                else if (txtlop.Text == "")
                {
                    MessageBox.Show("Chưa nhập lớp");
                    txtlop.Focus();
                }
                else if (t.thucthidulieu("update  tb_DocGia set TenDG=N'" + txttendocgia.Text + "', NgaySinh=N'" + ngayhh + "', GioiTinh=N'" + comgioitinh.Text + "', Lop=N'" + txtlop.Text + "'where MaDG=N'" + txtmadocgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            }
        }

        private void xoa_Click_1(object sender, EventArgs e)
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txtmadocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from tb_DocGia where MaDG='" + txtmadocgia.Text + "'") == true)
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

        private void thoat_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = t.docdulieu("select * from tb_DocGia where MaDG = N'" + txt_TimKiemDocGia.Text + "'");
            DataTable dt2 = t.docdulieu("select * from tb_DocGia where TenDG = N'" + txt_TimKiemDocGia.Text + "'");
            DataTable dt3 = t.docdulieu("select * from tb_DocGia where Lop = N'" + txt_TimKiemDocGia.Text + "'");
            if (ra_MaDG.Checked == true)
            {
                dataGridView1.DataSource = dt1;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy ahihi !", "Thông báo");
                }
            }
            else if (ra_TenDG.Checked == true)
            {
                dataGridView1.DataSource = dt2;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_Lop.Checked == true)
            {
                dataGridView1.DataSource = dt3;
                if (dataGridView1.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            ra_MaDG.Checked=false;
            ra_TenDG.Checked = false;
            ra_Lop.Checked=false;
            DataTable dt4 = t.docdulieu("select * from tb_DocGia ");
            dataGridView1.DataSource = dt4;
        }

        private void FormDocGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap,MaNV,MatKhau,Email,Quyen);
            f.Show();
        } 
    }
}

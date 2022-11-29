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
    public partial class FormTheLoaiSach : Form
    {
        public FormTheLoaiSach()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormTheLoaiSach(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
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
            DataTable dt = t.docdulieu("select * from tb_TheLoai");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã thể loại";
            luoi.Columns[1].HeaderText = "Tên thể loại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            bt_Xoa.Enabled = true;
            bt_Sua.Text = "Sửa";
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
            bt_Luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void FormTheLoaiSach_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaTL.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txt_TenTL.Text = luoi.CurrentRow.Cells[1].Value.ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            txt_MaTL.Text = "";
            txt_TenTL.Text = "";
            bt_Luu.Enabled = true;
            //sua.Enabled = false;
            bt_Xoa.Enabled = false;
            bt_Sua.Text = "hủy";
            bt_Them.Enabled = false;
            luoi.Enabled = false;
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
                ///them.Enabled = false;
                /// sua.Text = "Cập nhật";
                ///xoa.Text = "hủy";

                if (txt_MaTL.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại");
                    txt_MaTL.Focus();

                }
                else if (txt_TenTL.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên thể loại");
                    txt_TenTL.Focus();


                }
                else if (t.thucthidulieu("update  tb_TheLoai set TenTL=N'" + txt_TenTL.Text + "'where MaTL=N'" + txt_MaTL.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaTL.Text == "")
            {
                MessageBox.Show("Chưa nhập mã thể loại");
                txt_MaTL.Focus();

            }
            else if (txt_TenTL.Text == "")
            {
                MessageBox.Show("Chưa nhập tên thể loại");
                txt_TenTL.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO tb_TheLoai VALUES (N'" + txt_MaTL.Text + "', N'" + txt_TenTL.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txt_MaTL.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from tb_TheLoai where MaTL='" + txt_MaTL.Text + "'");
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

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            DataTable dt4 = t.docdulieu("select * from tb_TheLoai ");
            luoi.DataSource = dt4;
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = t.docdulieu("select * from tb_TheLoai where MaTL = N'" + txt_TimKiemTL.Text + "'");
            DataTable dt2 = t.docdulieu("select * from tb_TheLoai where TenTL = N'" + txt_TimKiemTL.Text + "'");
            if (ra_MaTL.Checked == true)
            {
                luoi.DataSource = dt1;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TenTL.Checked == true)
            {
                luoi.DataSource = dt2;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void FormTheLoaiSach_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quản_Lý_Thư_Viện_1
{
    public partial class FormTacGia : Form
    {
        public FormTacGia()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormTacGia(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
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
            DataTable dt = t.docdulieu("select * from tb_TacGia");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã tác giả";
            luoi.Columns[1].HeaderText = "Tên tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            bt_Xoa.Enabled = true;
            bt_Sua.Text = "Sửa";
            bt_Them.Enabled = true;
            bt_Sua.Enabled = true;
            bt_Xoa.Enabled = true;
            bt_Luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void FormTacGia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaTG.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txt_TenTG.Text = luoi.CurrentRow.Cells[1].Value.ToString();
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            txt_MaTG.Text = "";
            txt_TenTG.Text = "";
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


                if (txt_MaTG.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã tác giả");
                    txt_MaTG.Focus();

                }
                else if (txt_MaTG.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên tác giả");
                    txt_TenTG.Focus();


                }
                else if (t.thucthidulieu("update  tb_TacGia set TenTG=N'" + txt_TenTG.Text + "'where MaTG=N'" + txt_MaTG.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txt_MaTG.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        if (t.thucthidulieu("delete from tb_TacGia where MaTG='" + txt_MaTG.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Không thể xóa", "Thông báo");
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

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            if (txt_MaTG.Text == "")
            {
                MessageBox.Show("Chưa nhập mã tác giả");
                txt_MaTG.Focus();

            }
            else if (txt_TenTG.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tác giả");
                txt_TenTG.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO tb_TacGia VALUES (N'" + txt_MaTG.Text + "', N'" + txt_TenTG.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dt1 = t.docdulieu("select * from tb_TacGia where MaTG = N'" + txt_TimKiemTG.Text + "'");
            DataTable dt2 = t.docdulieu("select * from tb_TacGia where TenTG = N'" + txt_TimKiemTG.Text + "'");
            if (ra_MaTG.Checked == true)
            {
                luoi.DataSource = dt1;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
            else if (ra_TenTG.Checked == true)
            {
                luoi.DataSource = dt2;
                if (luoi.RowCount == 1)
                {
                    MessageBox.Show("Không tìm thấy !", "Thông báo");
                }
            }
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            DataTable dt3 = t.docdulieu("select * from tb_TacGia ");
            luoi.DataSource = dt3;
        }

        private void FormTacGia_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }
    }
}

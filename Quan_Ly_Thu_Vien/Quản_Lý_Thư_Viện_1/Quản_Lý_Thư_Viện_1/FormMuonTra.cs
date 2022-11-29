using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Quản_Lý_Thư_Viện_1
{
    public partial class FormMuonTra : Form
    {
        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        public FormMuonTra()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormMuonTra(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        private void FormMuonTra_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();
        }
        Update t = new Update();
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from tb_PhieuMuon");
            //l.Text = dt.Rows.Count.ToString();
            loadcombo();
            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].Width = 180;
            luoi.Columns[0].HeaderText = "Mã phiếu mượn";
            luoi.Columns[1].Width = 180;
            luoi.Columns[1].HeaderText = "Mã độc giả";
            luoi.Columns[2].Width = 180;
            luoi.Columns[2].HeaderText = "Mã nhân viên";
            luoi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            xoa1.Enabled = true;
            sua1.Text = "Sửa";
            them1.Enabled = true;
            sua1.Enabled = true;
            xoa1.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }

        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from tb_DocGia");
            DataTable dt1 = t.docdulieu("select * from tb_Nhanvien");
            DataTable dt2 = t.docdulieu("select * from tb_PhieuMuon");
            DataTable dt3 = t.docdulieu("select * from tb_Sach");



            comdocgia.DataSource = dt;
            comdocgia.DisplayMember = "TenDG";
            comdocgia.ValueMember = "MaDG";

            comnhanvien.DataSource = dt1;
            comnhanvien.DisplayMember = "TenNV";
            comnhanvien.ValueMember = "MaNV";

            commaphieumuon.DataSource = dt2;
            commaphieumuon.DisplayMember = "MaP";
            commaphieumuon.ValueMember = "MaP";

            commasach.DataSource = dt3;
            commasach.DisplayMember = "MaS";
            commasach.ValueMember = "MaS";

        }

        private void them1_Click(object sender, EventArgs e)
        {
            ngaymuon.Text = "";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            ngaytra.Value = result;


            luu1.Enabled = true;

            xoa1.Enabled = false;
            sua1.Text = "hủy";
            them1.Enabled = false;
            luoi1.Enabled = false;
        }

        private void them_Click(object sender, EventArgs e)
        {
            DataTable dt = t.docdulieu("select * from tb_PhieuMuon");
            txtmaphieu.Text = "";
            //l.Text = dt.Rows.Count.ToString();
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (t.thucthidulieu("INSERT INTO tb_PhieuMuon VALUES (N'"+txtmaphieu.Text + "',N'"  + comdocgia.SelectedValue.ToString() + "','" + comnhanvien.SelectedValue.ToString() + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thêm");
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

                if (comdocgia.Text == "")
                {
                    MessageBox.Show("Chưa chọn mã độc giả");
                }
                else if (comnhanvien.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                }
                else if (t.thucthidulieu("update  tb_PhieuMuon set MaDG=N'" + comdocgia.Text + "', MaNV=N'" + comnhanvien.Text + "'where MaP=N'" + txtmaphieu.Text + "'") == true)
                {
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa phiếu có mã số " + txtmaphieu.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        t.thucthidulieu("delete from tb_PhieuMuon where MaP='" + txtmaphieu.Text + "'");
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

        private void luoi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            commaphieumuon.Text = luoi1.CurrentRow.Cells[0].Value.ToString();
            commasach.Text = luoi1.CurrentRow.Cells[1].Value.ToString();
            ngaymuon.Text = luoi1.CurrentRow.Cells[2].Value.ToString();
            ngaytra.Text = luoi1.CurrentRow.Cells[3].Value.ToString();
            ghichu.Text = luoi1.CurrentRow.Cells[4].Value.ToString();
        }

        private void ghichu_TextChanged(object sender, EventArgs e)
        {
            txtmaphieu.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            comdocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            comnhanvien.Text = luoi.CurrentRow.Cells[2].Value.ToString();
        }

        private void luu1_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            DataTable dt = t.docdulieu("select * from tb_ChiTietPhieuMuon where MaS= N'" + commasach.Text + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
                commasach.Focus();
            }
            else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("INSERT INTO tb_ChiTietPhieuMuon VALUES (N'" + commaphieumuon.SelectedValue.ToString() + "',N'" + commasach.SelectedValue.ToString() + "','" + ngayhh + "','" + ngayhhh + "',N'" + ghichu.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata1();
            }
            else
            {
                MessageBox.Show("Lỗi không thể thực hiện được");
            }
        }

        private void sua1_Click(object sender, EventArgs e)
        {
            string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(ngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            if (sua1.Text == "hủy")
            {
                luu1.Enabled = false;
                sua1.Enabled = true;
                xoa1.Enabled = true;
                xoa1.Text = "Xóa";
                sua1.Text = "Gia hạn";
                them1.Enabled = true;
                loaddata1();
                luoi1.Enabled = true;
            }
            else if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                ngaytra.Focus();

            }
            else if (t.thucthidulieu("update  tb_ChiTietPhieuMuon set NgayHenTra='" + ngayhhh + "'where MaS=N'" + commasach.Text + "'") == true)
            {

                MessageBox.Show("Gia hạn thành công");
                loaddata1();


            }
            else MessageBox.Show("Không thể gia hạn sách");
        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            if (xoa1.Text == "hủy")
            {

                luu1.Enabled = false;
                sua1.Enabled = true;
                xoa1.Enabled = true;
                xoa1.Text = "Trả sách";
                sua1.Text = "Gia hạn";
                them1.Enabled = true;
                loaddata1();
                luoi1.Enabled = true;
            }
            else
            {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa trả sách có mã " + commasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from tb_ChiTietPhieuMuon where MaS='" + commasach.Text + "'");
                        MessageBox.Show("Đã trả sách " + commasach.Text + "", "Thông báo");
                        loaddata1();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata1();
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void bt_all_Click(object sender, EventArgs e)
        {
            DataTable dt4 = t.docdulieu("select * from tb_PhieuMuon ");
            luoi.DataSource = dt4;
        }

        private void bt_all1_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from tb_ChiTietPhieuMuon ");
            luoi.DataSource = dt5;
        }

        private void luoi_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphieu.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            comdocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            comnhanvien.Text = luoi.CurrentRow.Cells[2].Value.ToString();
        }

        private void FormMuonTra_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form f = new FormMain(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select * from tb_ChiTietPhieuMuon");
            l.Text = dt.Rows.Count.ToString();
            //l.Text = dt.Rows.Count.ToString();
            //loadcombo();
            if (dt != null)
            {
                luoi1.DataSource = dt;
            }
            luoi1.Columns[0].HeaderText = "Mã phiếu mượn";
            luoi1.Columns[1].HeaderText = "Mã sách";
            luoi1.Columns[2].HeaderText = "Ngày mượn";
            luoi1.Columns[3].HeaderText = "Ngày trả";
            luoi1.Columns[4].HeaderText = "Ghi chú";


            xoa1.Enabled = true;
            sua1.Text = "Gia hạn";
            them1.Enabled = true;
            sua1.Enabled = true;
            xoa1.Enabled = true;
            luu1.Enabled = false;
            luoi1.Enabled = true;

        }
    }
}

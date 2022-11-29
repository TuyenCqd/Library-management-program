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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string TenDangNhap = "", MaNV = "", MatKhau = "", Email = "", Quyen = "";
        public FormMain(string TenDangNhap, string MaNV, string MatKhau, String Email, String Quyen)
        {
            InitializeComponent();
            this.TenDangNhap = TenDangNhap;
            this.MaNV = MaNV;
            this.MatKhau = MatKhau;
            this.Email = Email;
            this.Quyen = Quyen;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (Quyen == "user")
            {
                nhânViênToolStripMenuItem.Enabled = false;
                tàiKhoảnToolStripMenuItem.Enabled = false;
            }
        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormDangNhap();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormNXB(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormTacGia(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void thểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormTheLoaiSach(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }


        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormUpdateSach(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void độcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormDocGia(TenDangNhap,MaNV,MatKhau,Email,Quyen);
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormNhanVien();
            f.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormMuonTra(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mọi sự trợ giúp xin vui lòng liên hệ 0396930708 !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormTimKiem(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormThongKeSach(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void độcGiảToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormThongKeDocGia(TenDangNhap, MaNV, MatKhau, Email, Quyen);
            f.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form f = new FormQuanLyTainKhoan();
            f.Show();
        }
    }
}


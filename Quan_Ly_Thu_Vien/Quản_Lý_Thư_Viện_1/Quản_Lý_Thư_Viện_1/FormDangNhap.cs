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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        Update t = new Update();
        private void Form1_Load(object sender, EventArgs e)
        {
            picUnShow.Visible= false;
            txt_Password.Focus();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = t.docdulieu("select * from tb_TaiKhoan where TenDangNhap = '" + txt_User.Text + "' and MatKhau = '" + txt_Password.Text + "'");
            if (txt_User.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
                txt_User.Focus();
            }
            else if (txt_Password.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txt_Password.Focus();
            }
            else if (dt.Rows.Count!=0 )
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                Form f = new FormMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString());
                f.ShowDialog();
            }
            else { MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai"); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txt_Password.PasswordChar == '*')
            {
                picShow.BringToFront();
                txt_Password.PasswordChar = '\0';
                picUnShow.Visible = true;
                picShow.Visible = false;
            }
        }

        private void picUnShow_Click(object sender, EventArgs e)
        {
            if (txt_Password.PasswordChar == '\0')
            {
                picUnShow.BringToFront();
                txt_Password.PasswordChar = '*';
                picShow.Visible = true;
                picUnShow.Visible = false;
            }
        }

        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form f = new FormQuenMatKhau();
            f.Show();
        }

        private void FormDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void txt_User_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_DangNhap.PerformClick();
            }
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                bt_DangNhap.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

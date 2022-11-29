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
    public partial class FormQuenMatKhau : Form
    {
        public FormQuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Update t = new Update();
        private void FormQuenMatKhau_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = t.docdulieu("select * from tb_TaiKhoan where Email = '" + txt_Email.Text + "'");
            //string query = "select * from tb_TaiKhoan where Email = '" + txt_Email.Text + "'";
            if (txt_Email.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email");
                txt_Email.Focus();
            }
            //else if (t.TaiKhoans(query).Count != 0)
            else if(dt.Rows.Count != 0)
            {
                label2.ForeColor = Color.Blue;
                label2.Text = "Thông Báo đã được gửi tới Email của quý khách";
            }
            else
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Email này chưa được đăng ký !!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new FormDangNhap();
            f.Show();
        }

        private void FormQuenMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
           this.Hide();
            Form f = new FormDangNhap();
            f.Show();
        }
    }
}

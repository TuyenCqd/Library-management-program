using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_Lý_Thư_Viện_1
{
    internal class Update
    {//192.168.1.48,1433;Initial Catalog=Quan_Ly_Thu_Vien;Integrated Security=True; User id=user Password=123
        SqlConnection con = new SqlConnection(@"Data Source=26.210.244.23;Initial Catalog=Quan_Ly_Thu_Vien;Integrated Security=True;User id=tuyen Password=123");//biến con sqlconection để kêt nối đến CSDL

        public void moketnoi() //Phương thức kết nối
        {
            if (con.State == ConnectionState.Closed) //kiểm tra nếu trường hợp chưa kết nối thì mở kêt nối
            {
                con.Open();
            }
        }

        public void dongketnoi()//kiểm tra nếu trường hợp mở kết nối thì đóng kêt nối
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }
        public Boolean thucthidulieu(string cmd) //hàm thực thi dữ liệu có tham số cmd
        {
            moketnoi();//mở kết nối dữ liệu
            Boolean check = false;// gán check = sai
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            dongketnoi();
            return check;//nếu thực thi câu lệnh sql được thì hảm trả về check= đúng ngược lại check=sai.
        }
        public DataTable docdulieu(string cmd)//hàm đọc dữ liệu đỗ dữ liệu vào lướisử dụng sqldatadapter để chuyển đổi dữ liệu từ lệnh cmd trả về. Sau đó thì dùng Fill để đổ dữ liệu từ adapter vào datatable và cuối cùng là trả về một bảng chứa dữ liệu đã truy vấn.
        {
            moketnoi();
            DataTable da = new DataTable();
            try
            {
                SqlCommand sc = new SqlCommand(cmd, con);
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(da);
            }
            catch (Exception)
            {
                da = null;
            }
            dongketnoi();
            return da;
        }
        /*public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            moketnoi();
            SqlCommand sc = new SqlCommand(query, con);
            SqlDataReader dataReader = sc.ExecuteReader();
            while (dataReader.Read())
            {
                taiKhoans.Add(new TaiKhoan(dataReader.GetString(0),dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4)));
            }
            dongketnoi();
            return taiKhoans;
        }*/
    }
}

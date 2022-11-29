using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_Lý_Thư_Viện_1
{
    internal class TaiKhoan
    {
        private string TenDangNhap;
        private string MaNV;
        private string MatKhau;
        private String Email;
        private String Quyen;

        public TaiKhoan() { }

        public TaiKhoan(string tenDangNhap, string maNV, string matKhau, string email, string quyen)
        {
            TenDangNhap1 = tenDangNhap;
            MaNV1 = maNV;
            MatKhau1 = matKhau;
            Email1 = email;
            Quyen1 = quyen;
        }

        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string MaNV1 { get => MaNV; set => MaNV = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Quyen1 { get => Quyen; set => Quyen = value; }
    }
    
}

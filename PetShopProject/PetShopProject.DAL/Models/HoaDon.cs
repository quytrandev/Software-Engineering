using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }
        public DateTime NgayLap { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public virtual NhanVien nhanVien { get; set; }
        public virtual KhachHang khachHang { get; set; }
        public HashSet<ChiTietHoaDon> chiTietHoaDons = new HashSet<ChiTietHoaDon>();
    }
}

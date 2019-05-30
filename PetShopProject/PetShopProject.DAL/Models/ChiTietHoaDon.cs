using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
    public class ChiTietHoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaSanPham { get; set; }
        public int Soluong { get; set; }
        public int tien { get; set; }
        public virtual HoaDon hoadon { get; set; }
        public virtual ProductModel productModel { get; set; }

    }
}

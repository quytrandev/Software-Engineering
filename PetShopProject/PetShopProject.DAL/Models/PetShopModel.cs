using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
    public class ProductModel
    {      
        public int MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongSP { get; set; }
        public int GiaBan { get; set; }
        public int MaLoaiSP { get; set; }
        public string NhaSanXuat { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
   public class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public string SDT { get; set; }
        public string GioiTinh { get; set; }
        public int MaLoaiNV { get; set; }
        public virtual LoaiNhanVien loaiNhanVien { get; set; }
    }
}

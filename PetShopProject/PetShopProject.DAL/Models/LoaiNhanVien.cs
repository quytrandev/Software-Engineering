using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
   public class LoaiNhanVien
    {
        public int MaLoaiNV { get; set; }
        public string TenLoaiNV { get; set; }
        public HashSet<NhanVien> nhanViens { get; set; }

    }
}

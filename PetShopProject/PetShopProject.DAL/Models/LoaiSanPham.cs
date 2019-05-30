using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
   public class LoaiSanPham
    {
        public int MaLoaiSP { get ; set; }
        public string TenLoaiSP { get ; set; }
        public HashSet<ProductModel> productModels { get; set; }
        
    }
}

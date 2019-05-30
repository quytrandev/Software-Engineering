using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.DAL.Models
{
    #region tngo add start
    public class EmployeeModel
    {
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public int Tuoi { get; set; }
        public string SoDT { get; set; }
        public string GioiTinh { get; set; }
        public int MaLoaiNV { get; set; }
    }
    #endregion
}

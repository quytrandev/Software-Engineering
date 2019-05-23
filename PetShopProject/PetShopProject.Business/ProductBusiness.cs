using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopProject.DAL;
using PetShopProject.DAL.Models;
using System.Data;

namespace PetShopProject.Business
{
    public class ProductBusiness
    {
        private ProductRepository _productRepository;
        public ProductBusiness()
        {
            _productRepository = new ProductRepository();
        }
        public List<ProductModel> GetProductList()
        {
            DataTable dt = _productRepository.GetProductList();
            List<ProductModel> productLst = new List<ProductModel>();
            foreach (DataRow row in dt.Rows)
            {
                productLst.Add(new ProductModel()
                {
                    MaSanPham = row["MaSanPham"].ToString(),
                    TenSanPham = row["TenSanPham"].ToString(),
                    SoLuongSP = Convert.ToInt32(row["SoLuongSP"]),
                    GiaBan = Convert.ToInt32(row["GiaBan"]),
                    MaLoaiSP = row["MaLoaiSP"].ToString(),
                    NhaSanXuat = row["NhaSanXuat"].ToString().Trim()
                });
            }
            return productLst;
        }
    }
}

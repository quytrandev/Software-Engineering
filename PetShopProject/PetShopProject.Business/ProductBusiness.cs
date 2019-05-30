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
                    MaSanPham = Convert.ToInt32(row["MaSanPham"]),
                    TenSanPham = row["TenSanPham"].ToString(),
                    SoLuongSP = Convert.ToInt32(row["SoLuongSP"]),
                    GiaBan = Convert.ToInt32(row["GiaBan"]),
                    MaLoaiSP = Convert.ToInt32(row["MaLoaiSP"]),
                    
                    NhaSanXuat = row["NhaSanXuat"].ToString().Trim()
                });
            }
            return productLst;
        }
        public DataTable GetProductTypeIDList()
        {
            DataTable dt = _productRepository.GetProductTypeIDList();
            return dt;
        }
        public int AddProduct(ProductModel product)
        {
            int result = _productRepository.AddProduct(product);
            return result;
        }
        public int EditProduct(ProductModel product)
        {
            int result = _productRepository.EditProduct(product);
            return result;
        }
        public int DeleteProduct(string productID)
        {
            int result = _productRepository.DeleteProduct(productID);
            return result;
        }
        public List<ProductModel> GetSearchList(string productName)
        {
            DataTable dt = _productRepository.SearchProduct(productName);
            List<ProductModel> productLst = new List<ProductModel>();
            foreach (DataRow row in dt.Rows)
            {
                productLst.Add(new ProductModel()
                {
                    MaSanPham = Convert.ToInt32(row["MaSanPham"]),
                    TenSanPham = row["TenSanPham"].ToString(),
                    SoLuongSP = Convert.ToInt32(row["SoLuongSP"]),
                    GiaBan = Convert.ToInt32(row["GiaBan"]),
                    MaLoaiSP = Convert.ToInt32(row["MaLoaiSP"]),

                    NhaSanXuat = row["NhaSanXuat"].ToString().Trim()
                });
            }
            return productLst;
        }
    }
}

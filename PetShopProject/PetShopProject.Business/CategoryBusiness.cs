using PetShopProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetShopProject.DAL;

namespace PetShopProject.Business
{
   public class CategoryBusiness
    {
        private CategoryRepository categoryRepository;
        public CategoryBusiness()
        {
            categoryRepository = new CategoryRepository();
        }
        public DataSet getCategoryList()
        {
            return categoryRepository.getCategoryList();
        }
        public bool AddCategory(LoaiSanPham loaiSanPham, ref string err)
        {
            return categoryRepository.AddCategory(loaiSanPham, ref err);
        }
        public bool EditCategory(LoaiSanPham loaiSanPham,ref string err)
        {
            return categoryRepository.EditCategory(loaiSanPham, ref err);
        }
        public bool DeleteCategory(int categoryID, ref string err)
        {
            return categoryRepository.DeleteCategory(categoryID, ref err);
        }
        public DataSet searchCategory(string categoryname)
        {
            return categoryRepository.searchCategory(categoryname);
        }
    }
}

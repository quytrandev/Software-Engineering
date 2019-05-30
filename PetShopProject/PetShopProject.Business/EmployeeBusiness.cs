using PetShopProject.DAL;
using PetShopProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopProject.Business
{
    #region tngo add start
    public class EmployeeBusiness
    {
        private EmployeeRepository _employeeRepository;
        public EmployeeBusiness()
        {
            _employeeRepository = new EmployeeRepository();
        }
        public List<EmployeeModel> GetEmployeeList()
        {
            DataTable dt = _employeeRepository.GetEmployeeList();
            List<EmployeeModel> EmployeeLst = new List<EmployeeModel>();
            foreach (DataRow row in dt.Rows)
            {
                EmployeeLst.Add(new EmployeeModel()
                {
                    MaNhanVien = Convert.ToInt32(row["MaNhanVien"]),
                    TenNhanVien = row["TenNhanVien"].ToString(),
                    Tuoi = Convert.ToInt32(row["Tuoi"]),
                    SoDT = row["SoDT"].ToString(),
                    GioiTinh = row["GioiTinh"].ToString(),
                    MaLoaiNV = Convert.ToInt32(row["MaLoaiNV"]),
                });
            }
            return EmployeeLst;
        }
        public DataTable GetEmployeeTypeIDList()
        {
            DataTable dt = _employeeRepository.GetEmployeeTypeIDList();
            return dt;
        }
        public int AddEmployee(EmployeeModel employee)
        {
            int result = _employeeRepository.AddEmployee(employee);
            return result;
        }
        public int EditEmployee(EmployeeModel employee)
        {
            int result = _employeeRepository.EditEmployee(employee);
            return result;
        }
        public int DeleteEmployee(int employeeID)
        {
            int result = _employeeRepository.DeleteEmployee(employeeID);
            return result;
        }

        public DataTable SearchEmployee(string employeeName)
        {
            return _employeeRepository.SearchEmployee(employeeName);
        }
    }
    #endregion
}


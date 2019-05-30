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
    public class AccountBusiness
    {
        private AccountRepository _accountRepository;



        public AccountBusiness()
        {
            _accountRepository = new AccountRepository();
        }

        public bool Login (AccountModel account)
        {
            bool result = _accountRepository.Login(account);
            return result;
        }

        public int ChangePassword(AccountModel account)
        {
            int result = _accountRepository.ChangePassword(account);
            return result;
        }

        public int CreateAccount(AccountModel account)
        {
            int result = _accountRepository.CreateAccount(account);
            return result;
        }

        public DataTable GetEmployeeTypeIDList1()
        {
            DataTable dt = _accountRepository.GetEmployeeTypeIDList1();
            return dt;
        }

        public DataTable CheckUsername(string username)
        {
            return _accountRepository.CheckUsername(username);
        }
    }
}

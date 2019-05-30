using PetShopProject.DAL;
using PetShopProject.DAL.Models;
using System;
using System.Collections.Generic;
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
    }
}

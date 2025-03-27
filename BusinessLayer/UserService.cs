using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataLayer;
using TransferObject;

namespace BusinessLayer
{
    public class UserService
    {
        private static UserService _instance;
        private readonly NhanVienData _accountData;
        private Account _acc;

        public static UserService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserService();
                }
                return _instance;
            }
        }

        public Account Acc
        {
            get { return _acc; }
        }

        private UserService() // Private constructor
        {
            _accountData = new NhanVienData();
            _acc = null;
        }

        public bool AuthenticateUser(string username, string password)
        {
            Account account = _accountData.GetUserByUsernameAndPassword(username, password);

            if (account != null)
            {
                _acc = account;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            _acc = null;
        }
    }
}

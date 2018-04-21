using Register.DAL;
using Register.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.BLL
{
    public class UserInfoBLL
    {
        UserInfoDAL userInfoDal = new UserInfoDAL();
        public int Login(UserInfo user)
        {
            int count = userInfoDal.UserLogin(user);
            return count;
        }
        public void Insert(UserInfo user)
        {
            userInfoDal.Insert(user);
        }
    }
}

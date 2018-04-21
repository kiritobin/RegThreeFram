using Register.DBHelper;
using Register.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.DAL
{
    public class UserInfoDAL
    {
        SQLHelper sqlHelp = new SQLHelper();
        public int UserLogin(UserInfo user)
        {
            int i = (int)sqlHelp.ExecuteScalar("select count(*) from T_login where UserName=@UserName",
                 new SqlParameter("@UserName", user.userName));
            return i;
        }
        public void Insert(UserInfo user)
        {
            sqlHelp.ExecuteNonQuery(@"INSERT INTO T_login
                       (UserName,PassWord)                                 
                        VALUES
                       (@UserName,@password)",
                new SqlParameter("@UserName", user.userName),
                new SqlParameter("@password", user.password));
        }
    }
}

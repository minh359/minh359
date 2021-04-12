using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Model.Framework;

namespace Model
{
    public class tTaiKhoanModel
    {
        private WebBanGiayDbContext context = null;
        public tTaiKhoanModel()
        {
            context = new WebBanGiayDbContext();
        }
        public bool Login(string username ,string password)
        {
            object[] sqlparams =
            {
                new SqlParameter("@TenTk",username),
                new SqlParameter("@Password",password)
            };
            var res = context.Database.SqlQuery<bool>("sp_login @TenTK @Password", sqlparams).SingleOrDefault();
            return res;
        }
    }
}

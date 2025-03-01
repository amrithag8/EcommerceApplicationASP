using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class LoginClass
    {
        ConnectionClass conObj = new ConnectionClass();
        public string Fn_Login(string username, string password)
        {
            string str = "select count(RegID) from Login_table where Username='" + username + "' and Password='" + password + "'";
            string isLogin = conObj.Fn_ExecuteScalar(str);
            return isLogin;
        }

        public string GetRegId(string username, string password)
        {
            string str1 = "select RegID from Login_table where Username='" + username + "' and Password='" + password + "' ";
            string id = conObj.Fn_ExecuteScalar(str1);
            return id;
        }

        public string getLogType(string username, string password)
        {
            string str2 = "select Log_type from Login_table where Username='" + username + "' and Password='" + password + "' ";
            string logType = conObj.Fn_ExecuteScalar(str2);
            return logType;
        }
    }
}

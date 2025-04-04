using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class FeedbackRplyClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public SqlDataReader getUserEmail(int userid)
        {
            string str="select user_name, user_email from User_table where user_id="+userid+"";
            SqlDataReader i = conObj.Fn_ExecuteReader(str);
            return i;
        }

        public string getAdminEmail(int adminID)
        {
            string str="select admin_email from admin_table where admin_ID="+ adminID + "";
            string i = conObj.Fn_ExecuteScalar(str);
            return i;
        }

        public int updateRplyMsg(int fid, string rplyMsg)
        {
            string str="update Feedback_Table set replyMsg='"+rplyMsg+"', fbStatus='inactive' where feedbackID="+fid+"";
            int i = conObj.Fn_ExecuteNonQuery(str);
            return i;
        }
    }
}

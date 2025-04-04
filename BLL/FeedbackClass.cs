using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class FeedbackClass
    {
        ConnectionClass obj = new ConnectionClass();

        public int enterIntoTable(int userid, string msg)
        {
            string str = "insert into Feedback_Table (UserID, feedbackMsg, Date, fbStatus) values("+userid+",'"+msg+"', '"+ DateTime.Now.Date.ToString("yyyy-MM-dd") + "', 'active' )";
            int i = obj.Fn_ExecuteNonQuery(str);
            return i;
        }
    }
}

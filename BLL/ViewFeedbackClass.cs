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
    public class ViewFeedbackClass
    {
        ConnectionClass obj = new ConnectionClass();
        public DataSet getFeedbackDetails()
        {
            string str="select feedbackID, UserID, feedbackMsg, Date, fbStatus from Feedback_Table where fbStatus='active'";
            DataSet ds = obj.Fn_Adapter(str);
            return ds;
        }
    }
}

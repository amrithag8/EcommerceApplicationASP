using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class RegistrationClass
    {
        ConnectionClass conObj = new ConnectionClass();
        public int FindRegID()
        {

            string MaxVal = "select max(RegID) from Login_table";
            int regID = 0;
            string ID = conObj.Fn_ExecuteScalar(MaxVal);
            if (ID == "")
            {
                regID = 1;
            }
            else
            {
                regID = Convert.ToInt32(ID) + 1;
            }
            return regID;
        }

        public int InserIntoAdminTable(int regID, string name, string email, string phone)
        {
            string insertAdminDetails = "insert into admin_table values("+ regID + ",'"+name+"','"+email+"', '"+phone+"' )";
            int isRegistered = conObj.Fn_ExecuteNonQuery(insertAdminDetails);
            return isRegistered;


        }

        public int InsertIntoUserTable(int regID, string name, int age, string email, string phone, string address, string city, string state, string pincode, string user_status)
        {
            string insertUserDetails = "insert into User_table values("+regID+", '" + name + "', " + age + ", '" + email + "', '" + phone + "', '" + address + "', '" + city + "', '" + state + "', '" + pincode + "', '"+user_status+"')";
            int isRegistered = conObj.Fn_ExecuteNonQuery(insertUserDetails);
            return isRegistered;
        }

        public int InserIntoLoginTable(int regID, string username, string password, string logType)
        {
            string insertAdminDetails = "insert into Login_table values(" + regID + ",'" + username + "','" + password + "', '" + logType + "' )";
            int isRegistered = conObj.Fn_ExecuteNonQuery(insertAdminDetails);
            return isRegistered;


        }


    }
}

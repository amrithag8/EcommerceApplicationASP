using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CategoryClass
    {
        ConnectionClass conObj = new ConnectionClass();

        public int insertIntoCategoryTable(string cName, string cImage, string cDesc)
        {
            string str = "insert into Category_table values('"+ cName + "','"+ cImage + "', '"+ cDesc + "', 'available' )";
            int IsInserted = conObj.Fn_ExecuteNonQuery(str);
            return IsInserted;

        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	SqlConnection con = new SqlConnection(@"server=LAPTOP-5LKA3HOK\SQLEXPRESS; database=EcommerceProject; Integrated security=true");


	public string getAccountNumber(string accno)
    {
        if (con.State == ConnectionState.Open)
        {
			con.Close();
        }
		string str = "select count(AccntNo) from Account_Details where AccntNo='" + accno + "'";
		SqlCommand cmd = new SqlCommand(str, con);
		con.Open();
		string result = cmd.ExecuteScalar().ToString();
		con.Close();
		return result;
	}


	public string BalanceCheck(string accno)
    {
		if (con.State == ConnectionState.Open)
		{
			con.Close();
		}
		string str = "select BalanceAmt from Account_Details where AccntNo='" + accno + "'";
		SqlCommand cmd = new SqlCommand(str, con);
		con.Open();
		string result = cmd.ExecuteScalar().ToString();
		con.Close();
		return result;
	}

	public int UpdateBalance(string accno, decimal balance)
    {
		if (con.State == ConnectionState.Open)
		{
			con.Close();
		}
		string str = "update Account_Details set BalanceAmt="+balance+" where AccntNo='" + accno + "'";
		SqlCommand cmd = new SqlCommand(str, con);
		con.Open();
		int result = cmd.ExecuteNonQuery();
		con.Close();
		return result;
	}
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}

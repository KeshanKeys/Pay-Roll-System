using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace GrifindoPayrollSystem
{
    public class Salary
    {

        public void InsertSalaries(string empid,string month,double nopay,double basepay,double grosspay) {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-4TO03GQ;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert into Salary(EmpId,NoPay,BasePay,GrossPay,Date) values ('"+empid+"','"+nopay+"','"+basepay+"','"+grosspay+"','"+month+"')";

            cmd.ExecuteReader();

            con.Close();
        
        
        }

        public string[] getEmployeeValues(string empid,string date) {

            string[] vals = new string[6];

           

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-4TO03GQ;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "select * from Employee where Id='"+empid+"'";

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read()) {


                vals[0]=sdr["Monthly_Sal"].ToString();
                vals[1] = sdr["Allowances"].ToString();
                vals[2] = sdr["Overtime_Rate"].ToString();




            }


            con.Close();


            con.Open();

            cmd.CommandText = "select * from Salary where EmpId='" + empid + "' and Date='"+date+"'";

            sdr = cmd.ExecuteReader();

            while (sdr.Read()) {

                vals[3] = sdr["NoPay"].ToString();
                vals[4] = sdr["BasePay"].ToString();
                vals[5] = sdr["GrossPay"].ToString();



            }



            con.Close();

            return vals;

        }


        public SqlDataAdapter getSalarySummaryMonths(string date1,string date2,string empid) {

            SqlDataAdapter sda = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-4TO03GQ;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            sda = new SqlDataAdapter("select * from Salary where EmpId='"+empid+"' and Date between '"+date1+"' and '"+date2+"'", con);

            con.Close();



            return sda;
        }


        public SqlDataAdapter getAllSalarySummaryMonths(string date1, string date2)
        {

            SqlDataAdapter sda = null;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-4TO03GQ;Initial Catalog=GrifindoDB;Integrated Security=True";

            con.Open();

            sda = new SqlDataAdapter("select * from Salary where Date between '" + date1 + "' and '" + date2 + "'", con);

            con.Close();



            return sda;
        }










    }
}

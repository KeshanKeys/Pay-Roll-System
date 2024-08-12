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

            SqlConnection CONN = new SqlConnection();
            CONN.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=GrifindoDB;Integrated Security=True";

            CONN.Open();

            SqlCommand CMD = new SqlCommand();
            CMD.Connection = CONN;
            CMD.CommandType = System.Data.CommandType.Text;
            CMD.CommandText = "insert into Salary(EmpId,NoPay,BasePay,GrossPay,Date) values ('"+empid+"','"+nopay+"','"+basepay+"','"+grosspay+"','"+month+"')";

            CMD.ExecuteReader();

            CONN.Close();
        
        
        }

        public string[] getEmployeeValues(string empid,string date) {

            string[] vals = new string[6];

           

            SqlConnection CONN1 = new SqlConnection();
            CONN1.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=GrifindoDB;Integrated Security=True";

            CONN1.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CONN1;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.CommandText = "select * from Employee where Id='"+empid+"'";

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read()) {


                vals[0]=sdr["Monthly_Sal"].ToString();
                vals[1] = sdr["Allowances"].ToString();
                vals[2] = sdr["Overtime_Rate"].ToString();




            }


            CONN1.Close();


            CONN1.Open();

            cmd.CommandText = "select * from Salary where EmpId='" + empid + "' and Date='"+date+"'";

            sdr = cmd.ExecuteReader();

            while (sdr.Read()) {

                vals[3] = sdr["NoPay"].ToString();
                vals[4] = sdr["BasePay"].ToString();
                vals[5] = sdr["GrossPay"].ToString();



            }



            CONN1.Close();

            return vals;

        }


        public SqlDataAdapter getSalarySummaryMonths(string date1,string date2,string empid) {

            SqlDataAdapter SDA = null;

            SqlConnection CONN2 = new SqlConnection();
            CONN2.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=GrifindoDB;Integrated Security=True";

            CONN2.Open();

            SDA = new SqlDataAdapter("select * from Salary where EmpId='"+empid+"' and Date between '"+date1+"' and '"+date2+"'", CONN2);

            CONN2.Close();



            return SDA;
        }


        public SqlDataAdapter getAllSalarySummaryMonths(string date1, string date2)
        {

            SqlDataAdapter SDA1 = null;

            SqlConnection CONN3 = new SqlConnection();
            CONN3.ConnectionString = "Data Source=DESKTOP-IHF5JOA\\SQLEXPRESS;Initial Catalog=GrifindoDB;Integrated Security=True";

            CONN3.Open();

            SDA1 = new SqlDataAdapter("select * from Salary where Date between '" + date1 + "' and '" + date2 + "'", CONN3);

            CONN3.Close();



            return SDA1;
        }










    }
}

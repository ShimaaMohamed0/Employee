using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmt2
{
    internal class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string constr;
        public Function()
        {
            constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\dubai key\OneDrive\المستندات\EmpDb.mdf"";Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(constr);
            cmd = new SqlCommand();
            cmd.Connection = con;


        }

        public DataTable GetData(string Query)
        {

        }
    }
}

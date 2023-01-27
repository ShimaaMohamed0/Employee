using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeMgmt2
{
    public partial class Salaries : Form
    {
        Function Con;
        public Salaries()
        {
            InitializeComponent();
            con = new Function();
            ShowSalary();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string Query = "Select * from EmployeeTb1";
            EmpCb.DisplayMember = Con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = Con.GetData(Query).Columns["Empid"].ToString();
            EmpCb.DataSource = Con.GetData(Query);

        }
        private void ShowSalaries()
        {
            try
            {
                string Query = "Select * from SalaryTb1";
                SalaryList.DataSource = con.GetData(Query);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
            private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Salaries_Load(object sender, EventArgs e)
        {

        }
    }
}

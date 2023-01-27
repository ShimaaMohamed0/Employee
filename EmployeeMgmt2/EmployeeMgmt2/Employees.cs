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
    public partial class Employees : Form
    {
        Function con;
        public Employees()
        {
            InitializeComponent();
            con = new Function();
            ShowEmp();
        }
        private void ShowEmp()
        {
            string Query = "Select * from EmployeeTb1";
            EmployeeList.DataSource = con.GetData(Query);
        }
        private void GetDepartment()
        {
            string Query = "Select * from DepartmentTb1";
            DepCb.DisplayMember = con.GetData(Query).Columns["Depname"].ToString();
            DepCb.ValueMember = con.GetData(Query).Columns["Depid"].ToString();
            DepCb.DataSource = con.GetData(Query);

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

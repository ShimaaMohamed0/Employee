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
    public partial class Departments : Form
    {
        Function con;

        public Departments()
        {
            InitializeComponent();
            con = new Function();
            ListerDepartment();
        }
        private void ListerDepartment()
        {
            string Query = "Select * from DepartmentTbl";
            Deplist.DataSource = con.GetData(Query)
        }
        private void Departments_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

        }
    }
}

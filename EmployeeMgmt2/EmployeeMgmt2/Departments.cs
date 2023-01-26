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
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTbl";
            Deplist.DataSource = con.GetData(Query);
        }
        private void Departments_Load(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else

                {
                    string Dep = DepNameTb.Text;
                    string Query = "insert into DepartmentTbl values('{0}')";
                    Query = string.Format( Query,DepNameTb.Text);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Added!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);

            }
        }

        int key = 0;
        private void Deplist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
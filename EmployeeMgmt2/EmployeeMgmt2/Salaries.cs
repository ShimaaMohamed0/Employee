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
        Function con;
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
            EmpCb.DisplayMember = con.GetData(Query).Columns["EmpName"].ToString();
            EmpCb.ValueMember = con.GetData(Query).Columns["Empid"].ToString();
            EmpCb.DataSource = con.GetData(Query);

        }
        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            string Query = "Select EmpSal from EmployeeTb1 where Empid = {0}";
            Query = string.Format(Query, EmpCb.SelectedValue.ToString());
            foreach (DataRow dr in con.GetData(Query).Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }
            //MessageBox.Show(DSal+ "");

            if (DaysTb.Text == "Rs")
            {
                EmpCb.Text = "" + (d * DSal);
            }
            else
            {
                d = Convert.ToInt32(DaysTb.Text);
                EmpCb.Text = "Rs" + (d * DSal);
            }
        }
        private void ShowSalary()
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
        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    Period = PeriodTb.Value.Date.Month.ToString() + "-" + PeriodTb.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);
                    string Query = "Update SalaryTb1 values({0},{1},'{2}',{3},'{4}',)";
                    Query = string.Format(Query, EmpCb.SelectedValue.ToString(), Days, Period, Amount, DateTime.Today.Date);
                    con.SetData(Query);
                    ShowSalary();
                    MessageBox.Show("Salary  Paid!!!");
                    DaysTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void EmpCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            login Obj = new login();
            Obj.Show();
            this.Hide();
        }
    }
}
        

    

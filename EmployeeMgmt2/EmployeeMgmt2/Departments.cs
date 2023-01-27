using System;
using System.Collections;
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
            DepNameTb.Text = Deplist.SelectedRows[0].Cells[1].Value.ToString();
            if (DepNameTb.Text == "") 
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Deplist.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    {
                        string Dep = DepNameTb.Text;
                        string Query = "Update DepartmentTb1 set Depname = '{0}' where Depid = {1}";
                        Query = string.Format(Query, DepNameTb.Text, key);
                        con.SetData(Query);
                        ShowDepartments();
                        MessageBox.Show("Department Updated!!!");
                        DepNameTb.Text = "";
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                    string Query = "Delete from DepartmentTb1 where Depid = {0}";
                    Query = string.Format(Query, key);
                    con.SetData(Query);
                    ShowDepartments();
                    MessageBox.Show("Department Deleted!!!");
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }

    }


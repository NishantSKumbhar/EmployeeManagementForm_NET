using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementForm
{
    public partial class frm_RegisterForm : Form
    {
        public frm_RegisterForm()
        {
            InitializeComponent();
        }

        SqlConnection sql_con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Student_Management_DB;Integrated Security=True");

        void Close_Connection()
        {
            sql_con.Close();
        }

        void Open_Connection()
        {
            sql_con.Open();
        }
        private void clearControl()
        {
            tb_EmpName.Clear();
            cmb_Department.SelectedIndex = -1;
            tb_Location.Clear();
        }


        private void lnk_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void frm_RegisterForm_Load(object sender, EventArgs e)
        {
            lbl_EmpName.Focus();
        }

        
    }
}

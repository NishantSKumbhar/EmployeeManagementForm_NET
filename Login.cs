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
    public partial class frm_Login : Form
    {
        public frm_Login()
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
            tb_UserName.Clear();
            tb_Password.Clear();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {

            Open_Connection();

            SqlCommand sql_cmd = new SqlCommand("SELECT COUNT(*) FROM Login_Details WHERE Username = @uname AND Password = @pwd", sql_con);
            sql_cmd.Parameters.Add("uname", SqlDbType.NVarChar).Value = tb_UserName.Text;
            sql_cmd.Parameters.Add("pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            int cnt = Convert.ToInt32(sql_cmd.ExecuteScalar());

            if(cnt > 0)
            {
                Shared_Content.User_Name = tb_UserName.Text;
                MessageBox.Show("Login Successfull !");
                lbl_Error.Visible = false;
                frm_Home home = new frm_Home();
                
                home.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Text = "Please, Enter Valid Credentials.";
                lbl_Error.Visible = true;
                clearControl();
                tb_UserName.Focus();
            }


            Close_Connection();

            

            
            
            

            //clearControl();
        }

        private void lnk_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_RegisterForm obj = new frm_RegisterForm();
            obj.Show();
            this.Hide();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_UserName.Focus();
        }

        private void tb_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void tb_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar)     // Allowing only any letter OR Digit

            || e.KeyChar == '\b')                 // Allowing BackSpace character

            {

                e.Handled = false;

            }

            else

            {

                e.Handled = true;

            }
        }
    }
}

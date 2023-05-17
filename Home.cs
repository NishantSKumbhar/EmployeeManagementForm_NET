using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementForm
{
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            lbl_Uname_header.Text = Shared_Content.User_Name;
        }

        private void lnk_Logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login loginObj = new frm_Login();
            loginObj.Show();
            this.Hide();
        }
    }
}

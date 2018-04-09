using BestGrill.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestGrill
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            var checkLogin = UserProvider.Instance.checkUser(username, password);
            if (checkLogin)
            {             
                this.Close();
                AdminUi adUi = new AdminUi();
                adUi.BringToFront();
                adUi.TopMost = true;
                adUi.Show();
            }
        }
    }
}

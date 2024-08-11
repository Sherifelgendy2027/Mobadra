using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssignment
{
    public partial class LoginFrm : Form
    {
        static int firstTime = 0;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            MyAdo.Begin("Server=DESKTOP-LKL9JTH;Database=tb;Trusted_Connection=True;");

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            string UserName,Password;
            UserName = UserTxt.Text;
            Password = PasswordTxt.Text;
            if(firstTime !=0)
            {
                Controller.SetTheSeen();
            }
            if(UserName != "" &&  Password != "")
               {
                    if( MyAdo.CheckUsers(UserName, Password) == 1)
                    Controller.forms[0].Show();
                    else
                    MessageBox.Show("wrong username or password try again or create new account");

            }
            else
                MessageBox.Show("Please enter a valid username and password!");
            firstTime++;
        }

        private void CreatBtn_Click(object sender, EventArgs e)
        {
            Controller.forms[1].Show();
        }
    }
}

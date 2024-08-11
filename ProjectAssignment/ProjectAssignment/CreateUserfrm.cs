using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssignment
{
    public partial class CreateUserfrm : Form
    {
        string fullName, userName, password;
        public CreateUserfrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fullName = FullNameTxt.Text;
            userName = UserNameTxt.Text;
            password = passwordTxt.Text;

            if (!String.IsNullOrEmpty(fullName) && !String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(password))
            {
                if (password == ConfirmPassTxt.Text) 
                {
                    if (MyAdo.CreateUser(userName, password) == 1)
                        MessageBox.Show("this user is already taken");
                    else
                    {
                        MyAdo.NewUser(userName, fullName, password);
                        //MainFrm mainFrm = new MainFrm();///back to form1
                        //mainFrm.Show();
                        this.Visible = false;
                    }
                }
                else
                    MessageBox.Show("Please make sure that Password equals Confirm password");
            }
            else
                MessageBox.Show("Invalid Input please Enter a valid one !");
        }
    }
}

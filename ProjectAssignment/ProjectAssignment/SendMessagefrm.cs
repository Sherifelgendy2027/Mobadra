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
    public partial class SendMessagefrm : Form
    {
        public SendMessagefrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

       

       

        private void SendMessagefrm_Load(object sender, EventArgs e)
        {
            List<string> list = MyAdo.GetUsers();
            for(int i = 0;i<list.Count ;i++)
            {
                if (i == Controller.ID - 1)
                    continue;
                usersListbox.Items.Add(list[i]);
            }

        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            string subject, message;
            subject = SubjecttextBox.Text;
            message = Msgbodytxt.Text;
            int msgId = 0;
            if (!String.IsNullOrEmpty(subject) && !String.IsNullOrEmpty(message))
                msgId = MyAdo.SaveMaessageData(subject, message);
            else
                MessageBox.Show("You can not send empty message or subject");
            foreach(var item in usersListbox.CheckedItems) 
                MyAdo.SaveRecivedUsers(item.ToString(), msgId);
            
            MessageBox.Show("all done");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAssignment
{
    public class Controller
    {
         static Controller()
         {
            SetTheSeen();
         }
        public static List<Form> forms = new List<Form>() ;

        public static void SetTheSeen()
        {
            if(forms.Count != 0) 
                forms.Clear();
            CreateTheForms();
        }

        public static void CreateTheForms()
        {
            // Form1 form1 = new Form1();
            MainFrm mainFrm = new MainFrm();
            SendMessagefrm sendMessagefrm = new SendMessagefrm();
            InboxFrm inboxFrm = new InboxFrm();
            CreateUserfrm createUserfrm = new CreateUserfrm();
            forms.Add(mainFrm);//0
            forms.Add(createUserfrm);//1
            forms.Add(sendMessagefrm);//2
            forms.Add(inboxFrm);//3
        }
        
        public static int ID;
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectAssignment
{
    public static class MyAdo
    {

        private static SqlConnection con = new SqlConnection();
        private static SqlCommand cmd = new SqlCommand();
        private static SqlDataReader dr;
        static string query;
        private static int checker = 0;

        public static void Begin(string sql)
        {
            con.ConnectionString = sql;
            con.Open();
            cmd.Connection = con;
        }

        public static int Save(string sl)
        {
            cmd.CommandText = sl;
            return cmd.ExecuteNonQuery();
        }
        //any SQL statement except Select
        public static string GetValue(string sl)
        {
            cmd.CommandText = sl;
            if (cmd.ExecuteScalar() != null)
                return cmd.ExecuteScalar().ToString();
            else
                return null;
        }

        public static void FillGrid(string sl, DataGridView grid)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = sl;
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            rd.Close();
            grid.DataSource = dt;
            grid.Refresh();
        }

        public static int CheckUsers (string Username,string Password) 
        {
            query = $"select count(1)  from UserTb ut where ut.username ='{Username}' and ut.password = '{Password}'";
            cmd.CommandText = query;
            int res = Convert.ToInt32(cmd.ExecuteScalar());
            if (res != 1) return res;
             query = $"SELECT Id FROM UserTb ut WHERE ut.UserName = '{Username}' AND ut.password = '{Password}'";
            cmd.CommandText = query;
            object result = cmd.ExecuteScalar();
            Controller.ID =(int) result;
            return res;
            
        }

        public static int CreateUser(string Username, string Password)
        {
            return CheckUsers(Username, Password);
        }
        public static void NewUser(string Username,string fullName, string Password) 
        {
            query = $"insert into UserTb (username,fullname, password) values ('{Username}', '{fullName}','{Password}')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public static List<string> GetUsers()
        {
            List<string> users = new List<string>();
            query = $"select fullname from UserTb";
            cmd.CommandText = query;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                users.Add(dr.GetString(0));
            }
            dr.Close();
            return users;
        }

        public static DataTable GetMessageData(int Id)
        {
            query = $"select  m.Sender,m.MsgSubject,m.MsgDetail,a.status from messages m join Action a  on m.Id = a.MsgId where a.Reciver = {Id}";
            cmd.CommandText = query;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public static void SetAllAsread(int id) ///there is an error in saving as read 
        {
            query = $"update Action set status = 1 where Reciver = {id}";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        public static int SaveMaessageData(string subject , string message)
        {
            
            int msgId;
            query = $"insert into messages(MsgSubject,MsgDetail,Sender) values ('{subject}','{message}','{GetFullName(Controller.ID)}')";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            
            query = $"select top 1 id from messages order by id desc";
            cmd.CommandText = query;
            object messageId = cmd.ExecuteScalar();
            msgId = (int)messageId;
            return msgId;
        }

        public static string GetFullName(int id) 
        {
            string fullName;
            query = $"select FullName from UserTb where id = {id}";
            cmd.CommandText = query;
            object name = cmd.ExecuteScalar();
            fullName = (string)name;
            return fullName;
        }
        public static void  SaveRecivedUsers(string name ,int msgId) 
        {
            query = $"insert into Action(MsgId, Sender, Reciver, status) values({msgId},{Controller.ID},{GetId(name)},0)";
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }
        public static int GetId(string fullName)
        {
            query = $"select Id from UserTb where FullName ='{fullName}'";
            cmd.CommandText = query;
            object id = cmd.ExecuteScalar();
            if (id == null)
                return 0;
            return (int) id;
        }
    }
}

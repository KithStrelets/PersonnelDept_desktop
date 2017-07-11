using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PersonnelDepartment
{
    public partial class MainForm : Form
    {
        protected static string rules; static User userlog;
        DBConnect dbConnect;
        public MainForm()
        {
            InitializeComponent();          
            dbConnect = new DBConnect();
            menuMainPage.Enabled = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }
        OperationsForm oper;
        private void personnelPage_Click(object sender, EventArgs e)
        {
            oper.Show();
            sched.Hide();                     
        }
        ScheduleForm sched;
        private void schedulePage_Click(object sender, EventArgs e)
        {
            sched.Show();
            oper.Hide();
            
               
        }
        aboutForm about = new aboutForm();
        private void aboutPage_Click(object sender, EventArgs e)
        {
            
            about.Close();
            about = new aboutForm();
            about.Show();
        }

        private void operPage_Click(object sender, EventArgs e)
        {
            oper.Show();
            sched.Hide();
        }

        private void exitSession_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            userlog = new User();
            userlog.username = login.Text;
            userlog.password = pass.Text;
            List<string>[] selected = dbConnect.Select("person", 13, "", "username=" + dbConnect.Transform(userlog.username));
            try {
                if (userlog.password.Equals(selected[0][12])) { userlog.id = new Guid(selected[0][0]); menuMainPage.Enabled = true; 
                
            
            selected = dbConnect.Select("job", 5, "", "idjob=" + dbConnect.Transform(selected[0][7].ToString()));
            if (selected[0][1].Equals("Admin")) { userlog = new Administrator(); rules = userlog.sendRules(); }
            else if (selected[0][1].Equals("Director")) { userlog = new Director(); rules = userlog.sendRules(); }
            else { userlog = new Secretary(); rules = userlog.sendRules(); }
            oper= new OperationsForm(userlog, rules);
            sched = new ScheduleForm(rules, userlog);
            sched.MdiParent = this;
            oper.MdiParent = this;
            pass.Clear();
            panelMain.Hide();
            oper.Show();
                }
                else { MessageBox.Show("Введён неверный логин/пароль"); }
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("Введён неверный логин/пароль"); }
        }

        private void changeUserSession_Click(object sender, EventArgs e)
        {
            oper.Hide();
            sched.Hide();
            about.Hide();
            panelMain.Show();
        }

    }
}

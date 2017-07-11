using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    public partial class DepartmentForm : Form
    {
        private DBConnect dbConnect;
        private List<Job> jobs;
        Department targetDept { get; set; }
        protected static string rules; static User user; 
        public DepartmentForm()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }
        internal DepartmentForm(string _rules, User us)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            jobs = new List<Job>();
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else {
                us = new Secretary();
                jobAddBtn.Enabled = false;
                jobClearBtn.Enabled = false;
                addDepBtn.Enabled = false;
                saveDepBtn.Enabled = false;
                deleteDepBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.appData.department);
            // TODO: This line of code loads data into the 'appData.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.appData.job);
        }
                
        private void jobAddBtn_Click(object sender, EventArgs e)
        {            
                string where = "idjob=" + dbConnect.Transform(jobsName.SelectedValue.ToString());
                List<string>[] selection = dbConnect.Select("job", 5, "", where);
                Job newJob = new Job(selection[0][1], selection[0][2], Convert.ToInt32(selection[0][3]));                  //////dobavit list workers cherez id workera
                newJob.id = new Guid(jobsName.SelectedValue.ToString());
                int cycle = (int)numberOfJob.Value;
                for (int a = 0; a < cycle; a++)
                {
                    string res = newJob.jobName + "(" + newJob.jobRank + "), ставка: " + newJob.salary + "$";
                    listJobs.Items.Add(res);
                    jobs.Add(newJob);
                }
        }

        private void addDepBtn_Click(object sender, EventArgs e)
        {
            if (depName.Text.Equals("") || jobs.Count.Equals(0)) MessageBox.Show("Поле названия отдела или список должностей отдела");
            else {
                Department newDept = new Department(depName.Text, jobs);
                string where = "name=" + dbConnect.Transform(newDept.departmentName);
                List<string>[] selection = dbConnect.Select("department", 3, "", where);
                if (selection.Length.Equals(0))
                {
                    List<string> jobsListNameList = new List<string>();
                    foreach(Job sub in jobs)
                    {
                        jobsListNameList.Add(sub.id.ToString());
                    }
                    dbConnect.Insert("department", dbConnect.Transform(newDept.id.ToString()), dbConnect.Transform(newDept.departmentName), dbConnect.Transform(String.Join(",", jobsListNameList)));
                    DepartmentForm_Load(sender, e);
                }
                else { MessageBox.Show("Такая должность уже существует"); }
                depName.Clear();
                listJobs.Items.Clear();
            }
        }

        private void chooseDept_DropDownClosed(object sender, EventArgs e)
        {
            listJobs.Items.Clear();
            try {
                jobs.Clear(); 
                string where = "iddept=" + dbConnect.Transform(chooseDept.SelectedValue.ToString());
                List<string>[] selection = dbConnect.Select("department", 3, "", where);
                List<string> selectedJobs = selection[0][2].Split(',').ToList();
                string res = "", previous = ""; Job tempJob = new Job();
                foreach (string sub in selectedJobs)
                {                    
                    if (sub.Equals(previous)) { Job subJob = tempJob; jobs.Add(subJob); listJobs.Items.Add(res); continue; }
                    else {
                        where = "idjob=" + dbConnect.Transform(sub);
                        try {
                            List<string>[] subSelection = dbConnect.Select("job", 5, "", where);
                            Job subJob = new Job(subSelection[0][1], subSelection[0][2], Convert.ToInt32(subSelection[0][3]));

                            subJob.id = new Guid(sub); tempJob = subJob;
                            res = subJob.jobName + "(" + subJob.jobRank + "), ставка: " + subJob.salary + "$";
                            listJobs.Items.Add(res);
                            jobs.Add(subJob);
                            previous = sub;
                        }
                        catch (Exception) { }
                    }
                }
                targetDept = new Department(chooseDept.Text, jobs);
            }
            catch (NullReferenceException) { }
        }

        private void jobClearBtn_Click(object sender, EventArgs e)
        {
            try {
                jobs.RemoveAt(listJobs.SelectedIndex);
                listJobs.Items.Remove(listJobs.SelectedItem);
            }
            catch (Exception) { }
            }

        private void deleteDepBtn_Click(object sender, EventArgs e)
        {
            Department delDept = new Department(chooseDept.Text, jobs);
            delDept.id = (Guid)chooseDept.SelectedValue;
            string where = "iddept=" + dbConnect.Transform(delDept.id.ToString());
            dbConnect.Delete("department", where);
            DepartmentForm_Load(sender, e);
        }

        private void saveDepBtn_Click(object sender, EventArgs e)
        {
            if (depName.Text.Equals("") || jobs.Count.Equals(0)) MessageBox.Show("Поле названия отдела или список должностей отдела");
            else {
                Department changeDep = new Department(depName.Text, jobs);
                List<string> jobsListNameList = new List<string>();
                foreach (Job sub in jobs)
                {
                    jobsListNameList.Add(sub.id.ToString());
                }
                string wherechange = "name=" + dbConnect.Transform(changeDep.departmentName) + " and joblist="+ dbConnect.Transform(String.Join(",", jobsListNameList));
                List<string>[] selection = dbConnect.Select("department", 3, "", wherechange);
                if (selection.Length.Equals(0))
                {
                    string where = "name=" + dbConnect.Transform(targetDept.departmentName);
                    string set = "name=" + dbConnect.Transform(changeDep.departmentName) + ", joblist=" + dbConnect.Transform(String.Join(",", jobsListNameList));
                    dbConnect.Update("department", where, set);
                }
                else { MessageBox.Show("Такая должность уже существует"); }

                DepartmentForm_Load(sender, e);
            }
        }        
    }
}

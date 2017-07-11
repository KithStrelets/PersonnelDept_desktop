using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace PersonnelDepartment
{
    public partial class ScheduleForm : Form
    {
        DBConnect dbConnect;
        List<string> listSched;
        List<CheckedListBox> cbAllControl;
        protected static string rules; static User user;
        public ScheduleForm()
        {
            InitializeComponent();
            dbConnect = new DBConnect();
        }
        internal ScheduleForm(string _rules, User us)
        {
            InitializeComponent();
            dbConnect = new DBConnect();
            listSched = new List<string>();
            cbAllControl = new List<CheckedListBox>();
            cbAllControl.Add(firstMonCheckedList); cbAllControl.Add(firstTueCheckedList); cbAllControl.Add(firstWedCheckedList);
            cbAllControl.Add(firstThuCheckedList); cbAllControl.Add(firstFriCheckedList); cbAllControl.Add(firstSatCheckedList);
            cbAllControl.Add(firstSunCheckedList);
            cbAllControl.Add(secondMonCheckedList); cbAllControl.Add(secondTueCheckedList); cbAllControl.Add(secondWedCheckedList);
            cbAllControl.Add(secondThuCheckedList); cbAllControl.Add(secondFriCheckedList); cbAllControl.Add(secondSatCheckedList);
            cbAllControl.Add(secondSunCheckedList);
            if (_rules.Equals("admin")) us = new Administrator();
            else if (_rules.Equals("director")) us = new Director();
            else {
                us = new Secretary();
                saveScheduleBtn.Enabled = false;
                delSchedBtn.Enabled = false;
            }
            rules = _rules;
            user = us;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.job' table. You can move, or remove it, as needed.
            this.jobTableAdapter.Fill(this.appData.job);
            // TODO: This line of code loads data into the 'appData.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.appData.department);

        }

        private void saveScheduleBtn_Click(object sender, EventArgs e)
        {
            listSched.Clear();     
            foreach (CheckedListBox sub in cbAllControl)
            {
                resultChecker(sub);
            }          
            Department schedDept = new Department(); schedDept.id = (Guid)chooseDept.SelectedValue;
            Job schedJob = new Job(); schedJob.id = (Guid)chooseJob.SelectedValue;
            Schedule sh = new Schedule(schedDept, schedJob, listSched.ToArray());
            string where = "fk_department=" + dbConnect.Transform(sh.dept.id.ToString()) + " and fk_job=" + dbConnect.Transform(sh.job.id.ToString());
            List<string>[] selection = dbConnect.Select("schedule", 17, "", where);
            if (selection.Length.Equals(0))
            {
                dbConnect.Insert("schedule", dbConnect.Transform(sh.id.ToString()), dbConnect.Transform(sh.dept.id.ToString()), dbConnect.Transform(sh.job.id.ToString()), String.Join(",", listSched));
                MessageBox.Show("Создано новое расписание");
            }
            else
            {
                string set = "fmonday=" + sh.firstmonday + ", ftuesday=" + sh.firsttuesday +
                    ", fwednesday=" + sh.firstwednesday + ", fthursday=" + sh.firstthursday + ", ffriday=" +
                    sh.firstfriday + ", fsaturday=" + sh.firstsaturday + ", fsunday=" + sh.firstsunday +

                    ", smonday=" + sh.secondmonday + ", stuesday=" + sh.secondtuesday +
                    ", swednesday=" + sh.secondwednesday + ", sthursday=" + sh.secondthursday + ", sfriday=" +
                    sh.secondfriday + ", ssaturday=" + sh.secondsaturday + ", ssunday=" + sh.secondsunday;
                dbConnect.Update("schedule", where, set);
                MessageBox.Show("Расписание обновлено");
            }
            ScheduleForm_Load(sender, e);
        }
        private void resultChecker(CheckedListBox cb)
        {
            List<string> checkText = new List<string>();
            foreach (object itemChecked in cb.Items)
            {
                if(cb.GetItemChecked(cb.Items.IndexOf(itemChecked))) checkText.Add(itemChecked.ToString());
                else
                {
                    checkText.Add("none");
                }
            }
            listSched.Add(dbConnect.Transform(String.Join(",", checkText)));
        }

        private void chooseDept_DropDownClosed(object sender, EventArgs e)
        {
            Guid deptId = (Guid)chooseDept.SelectedValue;
            List<string[]> selectedDays = new List<string[]>();
            if (chooseJob.SelectedItem != null)
            {
                string where = "fk_department=" + dbConnect.Transform(chooseDept.SelectedValue.ToString()) + " and fk_job=" + dbConnect.Transform(chooseJob.SelectedValue.ToString());
                List<string>[] selection = dbConnect.Select("schedule", 17, "", where);
                if (!selection.Length.Equals(0))
                {
                    for (int a = 3; a < selection[0].Count; a++)
                    {
                        selectedDays.Add(selection[0][a].Split(','));
                    }
                    int countCB = 0;
                    foreach (string[] sub in selectedDays)
                    {
                        for (int a = 0; a < 3; a++)
                        {
                            if (sub[a].Equals("none")) cbAllControl[countCB].SetItemChecked(a, false);
                            else
                            {
                                cbAllControl[countCB].SetItemChecked(a, true);
                            }
                        }
                        countCB++;
                    }
                }
                else { MessageBox.Show("Для вашего запроса расписание ещё не назначено");
                    foreach (CheckedListBox sub in cbAllControl)
                    {
                        for (int a = 0; a < sub.Items.Count; a++)
                        {
                            sub.SetItemChecked(a, false);
                        }
                    }
                }
            }
        }

        private void chooseJob_DropDownClosed(object sender, EventArgs e)
        {
            Guid jobId = (Guid)chooseJob.SelectedValue;
            List<string[]> selectedDays = new List<string[]>();
            if (chooseDept.SelectedItem != null)
            {
                string where = "fk_department=" + dbConnect.Transform(chooseDept.SelectedValue.ToString()) + " and fk_job=" + dbConnect.Transform(chooseJob.SelectedValue.ToString());
                List<string>[] selection = dbConnect.Select("schedule", 17, "", where);
                if (!selection.Length.Equals(0))
                {
                    for (int a = 3; a < selection[0].Count; a++)
                    {
                        selectedDays.Add(selection[0][a].Split(','));
                    }
                    int countCB = 0;
                    foreach (string[] sub in selectedDays)
                    {
                        for (int a = 0; a < 3; a++)
                        {
                            if (sub[a].Equals("none")) cbAllControl[countCB].SetItemChecked(a, false);
                            else
                            {
                                cbAllControl[countCB].SetItemChecked(a, true);
                            }
                        }
                        countCB++;
                    }
                }
                else
                {
                    MessageBox.Show("Для вашего запроса расписание ещё не назначено");
                    foreach (CheckedListBox sub in cbAllControl)
                    {
                        for (int a = 0; a < sub.Items.Count; a++)
                        {
                            sub.SetItemChecked(a, false);
                        }
                    }
                }
            }
        }

        private void delSchedBtn_Click(object sender, EventArgs e)
        {
            Department schedDept = new Department(); schedDept.id = (Guid)chooseDept.SelectedValue;
            Job schedJob = new Job(); schedJob.id = (Guid)chooseJob.SelectedValue;
            Schedule delSched = new Schedule();
            delSched.dept = schedDept; delSched.job = schedJob;
            string where = "fk_department=" + dbConnect.Transform(delSched.dept.id.ToString()) + " and fk_job=" + dbConnect.Transform(delSched.job.id.ToString());
            List<string>[] selection = dbConnect.Select("schedule", 17, "", where);
            if (!selection.Length.Equals(0)) { dbConnect.Delete("schedule", where); MessageBox.Show("Расписание удалено");
                foreach (CheckedListBox sub in cbAllControl)
                {
                    for (int a = 0; a < sub.Items.Count; a++)
                    {
                        sub.SetItemChecked(a, false);
                    }
                }
            }
            else { MessageBox.Show("Для вашего запроса расписание ещё не назначено"); }
            ScheduleForm_Load(sender, e);
        }
    }
}

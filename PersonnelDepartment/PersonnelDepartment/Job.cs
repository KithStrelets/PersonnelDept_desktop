using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
    class Job
    {
        public Guid id { get; set; }
        public string jobName { get; set; }
        public string jobRank { get; set; }
        public int salary { get; set; }
        public virtual ICollection<Worker> workers { get; set; }

        public Job()
        {
            id = Guid.NewGuid();
            workers = new List<Worker>();
        }
        public Job(string _jobName, string _jobRank, int _salary)
        {
            id = Guid.NewGuid();
            jobName = _jobName;
            jobRank = _jobRank;
            salary = _salary;
            workers = new List<Worker>();
        }
    }
}

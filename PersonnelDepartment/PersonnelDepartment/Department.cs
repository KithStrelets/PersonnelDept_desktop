using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelDepartment
{
    class Department
    {
        public Guid id { get; set; }
        public string departmentName { get; set; }
        public ICollection<Job> jobs { get; set; }

        public Department()
        {
            id = Guid.NewGuid();
            jobs = new List<Job>();
        }
        public Department(string _departmentName, List<Job> _jobs)
        {
            id = Guid.NewGuid();
            departmentName = _departmentName;
            jobs = _jobs;
        }
    }
}

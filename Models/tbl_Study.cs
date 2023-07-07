using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Models
{
    public class tbl_Study
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int patientId { get; set; }
        public DateTime Date { get; set; }
    }
}

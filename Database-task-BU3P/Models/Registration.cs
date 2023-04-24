using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_task_BU3P.Models
{
    class Registration
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public string Date { get; set; }
        
        public string Technician { get; set; }
        public string Category { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicHandle.Model
{
    public class TimeTableProperty
    {
        public string task { get; set; }
        public string description { get; set; }
        public DateTime duedate { get; set; }
        public string[] aims { get; set; }
        public bool status { get; set; } = false;
        public string[] level_important { get; set; } = { "Khẩn cấp", "Quan Trọng", "Trung" }; 
    }
}

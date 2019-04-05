using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public class ToDoItem {
        public int Id { get; set; }
        public string Work { get; set; }
        public DateTime Strart { get; set; }
        public DateTime? ControlDate { get; set; } = null;
        public DateTime? Ended { get; set; } = null;

        public ToDoItem(string work, string controlDate=""){
            Work = work;
            Strart = DateTime.Now;
        }
    }
}

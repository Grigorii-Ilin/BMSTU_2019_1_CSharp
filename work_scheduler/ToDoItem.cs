using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public class ToDoItem {
        public Guid Id { get; set; }
        public string WorkingName { get; set; }
        public DateTime Strart { get; set; }
        public DateTime? ControlDate { get; set; } = null;
        public DateTime? Ended { get; set; } = null;

        public ToDoItem(string workingName, string controlDate = "") {
            this.Id = Guid.NewGuid();
            this.WorkingName = workingName;
            this.Strart = DateTime.Now.Date;

            DateTime dtForParse;
            if (DateTime.TryParse(controlDate, out dtForParse)) {
                this.ControlDate = dtForParse;
            }
        }

        public ToDoItem() { }
    }
}

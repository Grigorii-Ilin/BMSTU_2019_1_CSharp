using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_events {
    public class Subscriber {

        public void Message(DateTime changedDT, FileHistory fileHistory) {
            MessageBox.Show(fileHistory.fileName);
        }
    }
}

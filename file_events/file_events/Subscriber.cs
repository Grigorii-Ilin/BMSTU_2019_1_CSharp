using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_events {
    class Subscriber {

        public void Message() {
            MessageBox.Show("Подписчик получил сообщение");
        }
    }
}

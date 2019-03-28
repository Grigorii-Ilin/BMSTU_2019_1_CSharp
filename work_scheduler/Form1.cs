using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace work_scheduler {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvScheduleViewer.Columns.Add("Id", "Номер");
            dgvScheduleViewer.Columns.Add("Work", "Задание");
            dgvScheduleViewer.Columns.Add("Start", "Начато");
            dgvScheduleViewer.Columns.Add("End", "Окончено");

        }
    }
} 

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

        private ToDoWorking toDoWorking;

        //private void ShowOnGrid(List<ToDoItem> toDoItems) {
        //    dgvScheduleViewer.DataSource= dgvScheduleViewer.getnew
        //}

        private void Form1_Load(object sender, EventArgs e) {
            //dgvScheduleViewer.Columns.Add("Id", "Номер");
            //dgvScheduleViewer.Columns.Add("Work", "Задание");
            //dgvScheduleViewer.Columns.Add("Start", "Начато");
            //dgvScheduleViewer.Columns.Add("End", "Окончено");

            //dgvScheduleViewer.Columns.Add(nameof(ToDoItem.Id), "Идентификатор");
            //dgvScheduleViewer.Columns.Add(nameof(ToDoItem.Work), "Задание");
            //dgvScheduleViewer.Columns.Add(nameof(ToDoItem.Strart), "Начато");
            //dgvScheduleViewer.Columns.Add(nameof(ToDoItem.ControlDate), "Контрольный срок");
            //dgvScheduleViewer.Columns.Add(nameof(ToDoItem.Ended), "Окончено");

            toDoWorking = new ToDoWorking();

            dgvScheduleViewer.DataSource = toDoWorking.ShowAll();

        }
    }
} 

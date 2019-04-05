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
        //FilterType filterType= FilterType.ShowAll;
        //SortingType sortingType=SortingType.WithoutSorting;

        private void Form1_Load(object sender, EventArgs e) {
            toDoWorking = new ToDoWorking();
            dgvScheduleViewer.DataSource = toDoWorking.Show();
        }

        //private int GetTagOfCheckedRadioButton(Panel panel) {
        //    int result = -1;
        //    foreach (var control in paFilter.Controls) {
        //        if (control.GetType()==typeof(RadioButton)) {
        //            var rbControl = (RadioButton)control;
        //            if (rbControl.Checked) {
        //                result = (int)rbControl.Tag;
        //                break;
        //            }
        //        }
        //    }
        //    return result;
        //}

        private void btShow_Click(object sender, EventArgs e) {
            //FilterType filterType = GetTagOfCheckedRadioButton(paFilter);
        }

        private void rbShowAll_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.ShowAll;
        }

        private void rbOnlyUnended_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.OnlyUnended;
        }

        private void rbOnlyEnded_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.OnlyEnded;
        }

        private void rbOnlyWithTime_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.OnlyWithTime;
        }

        private void rbWithoutTime_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.WithoutTime;
        }

        private void rbBeforeDate_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.BeforeDate;
        }

        private void rbWithoutSorting_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.sortingType = SortingType.WithoutSorting;
        }

        private void rbAlphabetSorting_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.sortingType = SortingType.AlphabetSorting;
        }

        private void rbControlDateSorting_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.sortingType = SortingType.ControlDateSorting;
        }
    }
} 

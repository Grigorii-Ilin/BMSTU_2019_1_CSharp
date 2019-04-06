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

        private void Form1_Load(object sender, EventArgs e) {
            toDoWorking = new ToDoWorking();
            toDoWorking.Load();
            dgvScheduleViewer.DataSource = toDoWorking.ToDoItemsForDGV;
            toDoWorking.Show();
        }

        private void btSave_Click(object sender, EventArgs e) {
            toDoWorking.Save();
            MessageBox.Show("Данные сохранены");
        }

        private void rbShowAll_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.ShowAll;
            toDoWorking.Show();
        }

        private void rbOnlyUnended_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.OnlyUnended;
            toDoWorking.Show();
        }

        private void rbOnlyEnded_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.OnlyEnded;
            toDoWorking.Show();
        }

        private void rbOnlyWithTime_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.OnlyWithTime;
            toDoWorking.Show();
        }

        private void rbWithoutTime_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.WithoutTime;
            toDoWorking.Show();
        }

        private void rbBeforeDate_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.filterType = FilterType.BeforeDate;
            toDoWorking.Show(dtpDateSelector.Value);
        }

        private void rbWithoutSorting_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.sortingType = SortingType.WithoutSorting;
            toDoWorking.Show();
        }

        private void rbAlphabetSorting_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.sortingType = SortingType.AlphabetSorting;
            toDoWorking.Show();
        }

        private void rbControlDateSorting_CheckedChanged(object sender, EventArgs e) {
            toDoWorking.sortingType = SortingType.ControlDateSorting;
            toDoWorking.Show();
        }


        private void dtpDateSelector_Enter(object sender, EventArgs e) {
            if (dgvScheduleViewer.SelectedCells[0].ColumnIndex>=2) {
                dgvScheduleViewer.CurrentCell.Value = dtpDateSelector.Value.ToLongDateString();
            }
        }
    }
} 

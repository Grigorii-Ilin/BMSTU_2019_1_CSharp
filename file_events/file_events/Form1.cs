using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_events {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK) {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
            //FileSystemWatcher;
        }
    }
}
